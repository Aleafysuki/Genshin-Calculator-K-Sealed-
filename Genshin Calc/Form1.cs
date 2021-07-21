using System;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Data;
using System.Threading;
using System.Threading.Tasks;

namespace Genshin_Calc
{
    public partial class Form1 : Form
    {
        #region 初始化各变量
        bool Sw = true, check = false;
        /// <summary>
        /// 文件操作相关变量
        /// </summary>
        bool FileEx_xlsx = false, FileEx_conf = false;
        bool SettingsChanged = false, Filesave = false;
        string FileLocation = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\Genshin Calculator\";
        string FileLocation2 = "";
        /// <summary>
        /// 攻击乘区的特殊数据
        /// </summary>
        int DEF2ATK, HP2ATK;
        /// <summary>
        /// 伤害计算结果
        /// </summary>
        double Normal = 0, Crit = 0, Avg = 0;
        /// <summary>
        /// 抗性计算区所需变量
        /// </summary>
        double Resistance = 1;
        /// <summary>
        /// 反应乘区所需变量
        /// </summary>
        double React = 1, rp = 1;
        /// <summary>
        /// 防御计算区所需变量
        /// </summary>
        double def1, def2, defu;
        /// <summary>
        /// 数值可视化图表所需变量
        /// </summary>
        double[] Contents = new double[8], Tmp = new double[8];
        string[] Attributes;
        string[] Values;
        /// <summary>
        /// 在各窗口之间进行数据传递用的变量组
        /// </summary>
        double[] DataStream = new double[20];
        DataTable Comtable = new DataTable();
        Thread ChartDrawing;
        #endregion

        #region 初始化窗体
        private void Form1_Load(object sender, EventArgs e)
        {
        }
        public Form1()
        {
            //FontIn();
            try
            {
                FileLocation2 = Convert.ToString(Environment.GetCommandLineArgs().GetValue(2));
            }
            catch (Exception)
            { }
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            Text = "原神计算器 " + System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString();
            if (File.Exists(FileLocation + "Configuration.Config"))
            {
                SettingsChange(true);
                LoadSettings();
                SettingsChange(false);
            }
            Calculate();
            RESCalc();
            FileCheck();
            Cocogoat圣遗物导入ToolStripMenuItem.Visible = false;
            ChartDrawing = new Thread(DetailedCalculate);
            ChartDrawing.Start();
        }
        #endregion

        #region 录入设置项
        private void LoadSettings()
        {
            Settings settings = new Settings();
            ATK1.Maximum = (int)settings.Output(0, "MAX");
            ATKPlus1.Maximum = (int)settings.Output(1, "MAX");
            CritDMG1.Maximum = (int)settings.Output(2, "MAX");
            EP1.Maximum = (int)settings.Output(3, "MAX");
            Skill1.Maximum = (int)settings.Output(4, "MAX");
            EnemyRES1.Minimum = (int)settings.Output(5, "MAX");
            EnemyRES1.Maximum = (int)settings.Output(6, "MAX");
            EM1.Maximum = (int)settings.Output(7, "MAX");
            ReactBuff1.Maximum = (int)settings.Output(8, "MAX");
            Other1.Maximum = (int)settings.Output(9, "MAX");
        }
        public void SettingsChange(bool s)
        {
            SettingsChanged = s;
        }
        #endregion

        #region 文件相关操作
        /// <summary>
        /// 读取文件中的值
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void FileWriter()
        {
            var xlsx_url = "https://genshincalc.oss-cn-beijing.aliyuncs.com/xlsx/%E8%AF%A6%E7%BB%86%E6%95%B0%E6%8D%AE.xlsx";
            var conf_url = "https://genshincalc.oss-cn-beijing.aliyuncs.com/conf/Configuration.Config";
            var font_url = "https://genshincalc.oss-cn-beijing.aliyuncs.com/font/FZXIANGSU12.TTF";
            if (File.Exists("详细数据.xlsx"))
            {
                FileInfo xlsx = new FileInfo("详细数据.xlsx");
                xlsx.CopyTo(FileLocation + "详细数据.xlsx", true);
            }
            else
            {
                ReadFile Document = new ReadFile();
                Document.Download(xlsx_url, FileLocation + "详细数据.xlsx");
            }
            if (File.Exists("Configuration.Config"))
            {
                FileInfo conf = new FileInfo("Configuration.Config");
                conf.CopyTo(FileLocation + "Configuration.Config", true);
            }
            else
            {
                ReadFile configuration = new ReadFile();
                configuration.Download(conf_url, FileLocation + "Configuration.Config");
            }
            if (File.Exists("FZXIANGSU12.TTF"))
            {
                FileInfo conf = new FileInfo("FZXIANGSU12.TTF");
                conf.CopyTo(FileLocation + "FZXIANGSU12.TTF", true);
            }
            else
            {
                ReadFile configuration = new ReadFile();
                configuration.Download(font_url, FileLocation + "FZXIANGSU12.TTF");
            }
        }
        public void FileCheck()//检查文件是否还在
        {
            修复字体ToolStripMenuItem.Visible = !(File.Exists(@"C:\Windows\Fonts\FZXIANGSU12.TTF") || File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\Microsoft\Windows\Fonts\FZXIANGSU12.TTF"));
            var xlsx_name = "\n\t角色和武器的数值表格";
            var conf_name = "\n\t数值设定文件";
            if (!Directory.Exists(FileLocation))
            {
                DialogResult err;
                err = MessageBox.Show("未找到本地存档文件夹。\n查询功能和自定义设置暂时被禁用。\n是否允许创建文件夹？创建后将会允许一些高级功能。", "提示", MessageBoxButtons.YesNo);
                if (err == DialogResult.Yes)
                {
                    Directory.CreateDirectory(FileLocation);
                    FileWriter();
                }
            }
            if (File.Exists(FileLocation + "详细数据.xlsx"))
            {
                FileEx_xlsx = true;
                xlsx_name = "";
            }
            if (File.Exists(FileLocation + "Configuration.Config"))
            {
                FileEx_conf = true;
                conf_name = "";
            }
            if (!(FileEx_conf && FileEx_xlsx))
            {
                DialogResult err;
                err = MessageBox.Show("未找到本地存档文件。\n下列功能暂时无法使用。" + xlsx_name + conf_name + "\n是否允许自动部署？部署后可启用全部功能。", "提示", MessageBoxButtons.YesNo);
                if (err == DialogResult.Yes)
                {
                    FileWriter();
                    err = MessageBox.Show("已创建文件。\n重新打开计算器后，相应功能会自动生效。", "提示", MessageBoxButtons.YesNo);
                    if (err == DialogResult.Yes)
                        Process.GetCurrentProcess().Kill();
                }
            }
            查询ToolStripMenuItem.Visible = FileEx_xlsx;
            查询ToolStripMenuItem.Enabled = FileEx_xlsx;
            数值上下限设置ToolStripMenuItem.Visible = FileEx_conf;
            数值上下限设置ToolStripMenuItem.Enabled = FileEx_conf;
        }

        private void 数据存放文件夹ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\Genshin Calculator\");
        }
        public void Save()
        {
            SaveFileDialog ctrl_s = new SaveFileDialog
            {
                Title = "保存预设",
                Filter = "预设文档(*.calo)|*.calo"
            };
        }
        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
        private void 数值上下限设置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Settings settingwindow = new Settings();
            if (ATKLC <= 5000)
            {
                settingwindow.Input(
                      ATK1.Maximum,
                      ATKPlus1.Maximum,
                      CritDMG1.Maximum,
                      EP1.Maximum,
                      Skill1.Maximum,
                      EnemyRES1.Minimum,
                      EnemyRES1.Maximum,
                      EM1.Maximum,
                      ReactBuff1.Maximum,
                      Other1.Maximum);
                settingwindow.ShowDialog();
            }
            else
            {
                DialogResult wip;
                wip = MessageBox.Show("施工中");
            }
            if (File.Exists(FileLocation + "Configuration.Config"))
            {
                LoadSettings();
            }
        }
        private void 修复字体ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult FontCheck;
            FontCheck =
                MessageBox.Show("缺失非必要的字体文件，是否进行安装？\n若不安装会导致显示发生变化，但不影响正常使用", "提示", MessageBoxButtons.YesNo);
            if (FontCheck == DialogResult.Yes)
            {
                DialogResult chk;
                if (File.Exists("FZXIANGSU12.TTF"))
                {
                    chk = MessageBox.Show("已找到文件。\n请点击新窗口中的【安装】按钮并重新启动计算器。");
                }
                else
                {
                    DialogResult err;
                    err = MessageBox.Show("未找到文件。\n需要从网络中下载指定字体文件。");
                    ReadFile down = new ReadFile();
                    down.Download("https://genshincalc.oss-cn-beijing.aliyuncs.com/font/FZXIANGSU12.TTF", "FZXIANGSU12.TTF");
                    chk = MessageBox.Show("已下载文件。\n请点击新窗口中的【安装】按钮并重新启动计算器。");
                }
                try
                {
                    File.Copy("FZXIANGSU12.TTF", @"C:\Windows\Fonts" + @"\FZXIANGSU12.TTF", true);
                }
                catch (UnauthorizedAccessException)
                {
                    DialogResult err;
                    err = MessageBox.Show("没有安装字体的权限。\n请使用管理员权限重新打开再试试。");
                }
                catch (Exception error)
                {
                    DialogResult err;
                    err = MessageBox.Show($"由于某些信息安装失败。\n错误信息：{error.Message}。");
                }
            }


        }
        #endregion

        #region 输入各项数据
        //白字攻击力：角色+武器//
        private void ATK1_Scroll(object sender, EventArgs e)
        {
            ATK.Text = ATK1.Value.ToString();
            Calculate();
        }
        private void ATK_TextChanged(object sender, EventArgs e)
        {
            TrackBarSync(ATK1, ATK);
        }
        //绿字攻击力：圣遗物等加成//
        private void ATKPlus1_Scroll(object sender, EventArgs e)
        {
            ATKPlus.Text = ATKPlus1.Value.ToString();
            Calculate();
        }
        private void ATKPlus_TextChanged(object sender, EventArgs e)
        {
            TrackBarSync(ATKPlus1, ATKPlus);
        }
        //暴击率输入//
        private void CritRate1_Scroll(object sender, EventArgs e)
        {
            CritRate.Text = Convert.ToString(Convert.ToDouble(CritRate1.Value) / 10);
            Calculate();
        }
        private void CritRate_TextChanged(object sender, EventArgs e)
        {
            TrackBarSync(CritRate1, CritRate, "5", 5, 10);
        }
        //暴击伤害输入//
        private void CritDMG1_Scroll(object sender, EventArgs e)
        {
            CritDMG.Text = Convert.ToString(Convert.ToDouble(CritDMG1.Value) / 10);
            Calculate();
        }
        private void CritDMG_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToDouble(CritDMG.Text) < 50 && CritDMG.Text != null)
                {
                    CritDMG.BackColor = System.Drawing.SystemColors.Control;
                }
                else
                {
                    CritDMG.BackColor = System.Drawing.SystemColors.Window;
                    TrackBarSync(CritDMG1, CritDMG, "50", 50, 10);
                }
            }
            catch (Exception)
            {
            }
        }
        //元素精通//
        private void EM1_Scroll(object sender, EventArgs e)
        {
            EM.Text = EM1.Value.ToString();
            Calculate();
        }
        private void EM_TextChanged(object sender, EventArgs e)
        {
            TrackBarSync(EM1, EM);
            Calculate();
        }
        //元素伤害加成//
        private void EP1_Scroll(object sender, EventArgs e)
        {
            EP.Text = Convert.ToString(Convert.ToDouble(EP1.Value) / 10);
            Calculate();
        }
        private void EP_TextChanged(object sender, EventArgs e)
        {
            TrackBarSync(EP1, EP, "0", 0, 10);
        }
        //伤害加深：百分比//
        private void DMGBuff1_Scroll(object sender, EventArgs e)
        {
            DMGBuff.Text = Convert.ToString(Convert.ToDouble(DMGBuff1.Value) / 10);
            Calculate();
        }
        private void DMGBuff_TextChanged(object sender, EventArgs e)
        {
            TrackBarSync(DMGBuff1, DMGBuff, "0", 0, 10);
        }
        //伤害加深：按层数的百分比//
        private void DMGBuff1_S_Scroll(object sender, EventArgs e)
        {
            DMGBuff_S.Text = Convert.ToString(Convert.ToDouble(DMGBuff1_S.Value) / 10);
            Calculate();
        }
        private void DMGBuff_S_TextChanged(object sender, EventArgs e)
        {
            TrackBarSync(DMGBuff1_S, DMGBuff_S, "0", 0, 10);
        }
        //伤害加深：层数//
        private void DMGBuff1_Sf_Scroll(object sender, EventArgs e)
        {
            DMGBuff_Sf.Text = DMGBuff1_Sf.Value.ToString();
            Calculate();
        }
        private void DMGBuff_Sf_TextChanged(object sender, EventArgs e)
        {
            TrackBarSync(DMGBuff1_Sf, DMGBuff_Sf, "0", 0, 10);
        }
        //攻击加成：固定值//
        private void ATKBuff1_Scroll_1(object sender, EventArgs e)
        {
            ATKBuff.Text = Convert.ToString(ATKBuff1.Value);
            Calculate();
        }
        private void ATKBuff_TextChanged_1(object sender, EventArgs e)
        {
            TrackBarSync(ATKBuff1, ATKBuff);
        }
        //攻击加成：百分比//
        private void ATKBuff1_P_Scroll(object sender, EventArgs e)
        {
            ATKBuff_P.Text = Convert.ToString(Convert.ToDouble(ATKBuff1_P.Value) / 10);
            Calculate();
        }
        private void ATKBuff_P_TextChanged(object sender, EventArgs e)
        {
            TrackBarSync(ATKBuff1_P, ATKBuff_P, "0", 0, 10);
        }
        //攻击加成：百分比（算层数）//
        private void ATKBuff1_S_Scroll_1(object sender, EventArgs e)
        {
            ATKBuff_S.Text = Convert.ToString(Convert.ToDouble(ATKBuff1_S.Value) / 10);
            Calculate();
        }
        private void ATKBuff_S_TextChanged_1(object sender, EventArgs e)
        {
            TrackBarSync(ATKBuff1_S, ATKBuff_S, "0", 0, 10);
        }
        //攻击加成：层数//
        private void ATKBuff1_Sf_Scroll_1(object sender, EventArgs e)
        {
            ATKBuff_Sf.Text = ATKBuff1_Sf.Value.ToString();
            Calculate();
        }
        private void ATKBuff_Sf_TextChanged(object sender, EventArgs e)
        {
            TrackBarSync(ATKBuff1_Sf, ATKBuff_Sf);
        }
        //等级和抗性输入：我方//
        private void PlayerLevel1_Scroll(object sender, EventArgs e)
        {
            PlayerLevel.Text = Convert.ToString(PlayerLevel1.Value);
            Calculate();
        }
        private void PlayerLevel_TextChanged(object sender, EventArgs e)
        {
            TrackBarSync(PlayerLevel1, PlayerLevel, "1", 1, 1);
        }
        //等级和抗性输入：敌方//
        private void EnemyLevel1_Scroll(object sender, EventArgs e)
        {
            EnemyLevel.Text = Convert.ToString(EnemyLevel1.Value);
            Calculate();
        }
        private void EnemyLevel_TextChanged(object sender, EventArgs e)
        {
            TrackBarSync(EnemyLevel1, EnemyLevel, "1", 1, 1);
        }
        //防御增减效果//
        private void Defense1_Scroll(object sender, EventArgs e)
        {
            Defense.Text = Convert.ToString(Convert.ToDouble(Defense1.Value) / 10);
            Calculate();
        }
        private void Defense_TextChanged(object sender, EventArgs e)
        {
            TrackBarSync(Defense1, Defense, "0", 0, 10);
        }
        //抗性计算//
        private void RESCalc()
        {
            if (float.Parse(EnemyRES.Text) < 0)
            {
                Resistance = 1 - float.Parse(EnemyRES.Text) / 200;
            }
            else if (0 <= float.Parse(EnemyRES.Text) && float.Parse(EnemyRES.Text) <= 75)
            {
                Resistance = 1 - float.Parse(EnemyRES.Text) / 100;
            }
            else if (75 < float.Parse(EnemyRES.Text))
            {
                Resistance = 1 / (1 + 4 * (float.Parse(EnemyRES.Text) / 100));
            }
            Calculate();
        }
        private void EnemyRES1_Scroll(object sender, EventArgs e)
        {
            EnemyRES.Text = Convert.ToString(Convert.ToDouble(EnemyRES1.Value) / 10);
            RESCalc();
        }
        private void EnemyRES_TextChanged(object sender, EventArgs e)
        {
            TrackBarSync(EnemyRES1, EnemyRES, "0", 0, 10);
            RESCalc();
        }
        //技能倍率//
        private void Skill1_Scroll(object sender, EventArgs e)
        {
            Skill.Text = Convert.ToString(Convert.ToDouble(Skill1.Value) / 10);
            Calculate();
        }
        private void Skill_TextChanged(object sender, EventArgs e)
        {
            TrackBarSync(Skill1, Skill, "0", 0, 10);
        }
        //其他额外的乘算加伤//
        private void Other1_Scroll(object sender, EventArgs e)
        {
            Other.Text = Convert.ToString(Convert.ToDouble(Other1.Value) / 10);
            Calculate();
        }
        private void Other_TextChanged(object sender, EventArgs e)
        {
            TrackBarSync(Other1, Other, "0", 0, 10);
        }
        //反应伤害增强//
        private void ReactBuff1_Scroll(object sender, EventArgs e)
        {
            ReactBuff.Text = Convert.ToString(Convert.ToDouble(ReactBuff1.Value) / 10);
            Calculate();
        }
        private void ReactBuff_TextChanged(object sender, EventArgs e)
        {
            TrackBarSync(ReactBuff1, ReactBuff, "0", 0, 10);
        }
        //确定反应倍率//
        private void Reaction_Choose_SelectedIndexChanged(object sender, EventArgs e)
        {
            Calculate();
            Calculate();
        }
        /// <summary>
        /// 检测到输入框有误时进行纠正操作。 
        /// 1.输入框为空或格式有误(FormatException) 时将其设为0，且将对应的trackBar设为零值；
        /// 2.输入越界(ArgumentOutOfRangeException) 时将其设为对应trackbar的最大值。
        /// </summary>
        /// <param name="Val">TrackBar</param>
        /// <param name="Txt">Textbox</param>
        public void TrackBarSync(TrackBar Val, TextBox Txt)
        {
            try
            {
                if (Txt.Text == "")
                {
                    Txt.Text = "0";
                }
                Val.Value = Convert.ToInt32(Txt.Text);
            }
            catch (FormatException)
            {
            }
            catch (ArgumentOutOfRangeException)
            {
                Txt.Text = Val.Maximum.ToString();
            }
            Streamer();
            Calculate();
        }
        /// <summary>
        /// TrackBarSync的重载
        /// </summary>
        /// <param name="Val">TrackBar</param>
        /// <param name="Txt">Textbox</param>
        /// <param name="DefaultText">文本框的默认值</param>
        /// <param name="DefaultValue">数值条的默认位置</param>
        public void TrackBarSync(TrackBar Val, TextBox Txt, string DefaultText, int DefaultValue, float Scale)
        {
            try
            {
                if (Txt.Text == "")
                {
                    Txt.Text = DefaultText;
                }
                Val.Value = Convert.ToInt32(float.Parse(Txt.Text) * Scale);
            }
            catch (FormatException)
            {
            }
            catch (ArgumentOutOfRangeException)
            {
                Txt.Text = Convert.ToDouble(Txt.Text) < Val.Minimum / Scale ?
                    (Val.Minimum / Scale).ToString() :
                    (Val.Maximum / Scale).ToString();
            }
            Streamer();
            Calculate();
        }
        #endregion 

        //窗口透明化//
        private void TransButton_MouseDown(object sender, MouseEventArgs e)
        {
            Opacity = 0.09;
        }
        private void TransButton_MouseUp(object sender, MouseEventArgs e)
        {
            Opacity = 1;
        }
        #region 对文件的读取和写入
        //读取
        private void OpenFiles_Drag(object sender, DragEventArgs e)
        {
            Filesave = false;
            SaveFiles();
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.All;                                                              //重要代码：表明是所有类型的数据，比如文件路径
            else
                e.Effect = DragDropEffects.None;
            ReadFromFile(File.ReadAllText(((Array)e.Data.GetData(DataFormats.FileDrop)).GetValue(0).ToString()));
        }
        private void DragComplete(object sender, DragEventArgs e)
        {
            Filesave = true;
            Calculate();
        }
        private void DragBreak(object sender, EventArgs e)
        {
            ReadFromFile(File.ReadAllText(FileLocation + "Temp.yschar"));
            Filesave = false;
            Calculate();
            File.Delete(FileLocation + "Temp.yschar");
        }
        private void OpenFiles(object sender, EventArgs e)
        {
            OpenFile.ShowDialog();
            try
            {
                ReadFromFile(File.ReadAllText(OpenFile.FileName));
            }
            catch (Exception)
            {
            }
            Calculate();
        }
        private void ReadFromFile(string text)
        {
            string[] subs = text.Split(new char[3] { '\t', '\n', '\r' });
            Attributes = new string[subs.Length];
            Values = new string[subs.Length];
            for (int i = 0; i < subs.Length; i++)
            {
                if (!(subs[i].Contains("<") && subs[i] == null))
                {
                    string[] spd = subs[i].Split(']');
                    Attributes[i] = spd[0] + (spd[0].Contains('[') ? "]" : "");
                    if (spd.Length > 1)
                    {
                        Values[i] = spd[1];
                    }
                }
            }
            ATK.Text = ContentDisplay("[白攻]");
            ATKPlus.Text = ContentDisplay("[绿攻]");
            CritRate.Text = ContentDisplay("[暴率]");
            CritDMG.Text = ContentDisplay("[暴伤]");
            EM.Text = ContentDisplay("[精通]");
            EP.Text = ContentDisplay("[元素]");
            ATKBuff.Text = ContentDisplay("[固定攻击]");
            ATKBuff_P.Text = ContentDisplay("[比率攻击]");
            ATKBuff_DEF.Text = ContentDisplay("[防御收益]");
            ATKBuff_HP.Text = ContentDisplay("[生命收益]");
            ATKBuff_S.Text = ContentDisplay("[叠加攻击]");
            ATKBuff_Sf.Text = ContentDisplay("[叠攻层数]");
            PlayerLevel.Text = ContentDisplay("[我方等级]");
            EnemyLevel.Text = ContentDisplay("[敌方等级]");
            Defense.Text = ContentDisplay("[防御变化]");
            EnemyRES.Text = ContentDisplay("[敌人抗性]");
            DMGBuff.Text = ContentDisplay("[伤害提升]");
            DMGBuff_S.Text = ContentDisplay("[叠加伤害]");
            DMGBuff_Sf.Text = ContentDisplay("[叠伤层数]");
            ReactBuff.Text = ContentDisplay("[反应加剧]");
            Skill.Text = ContentDisplay("[天赋倍率]");
            Other.Text = ContentDisplay("[额外乘区]");
            switch (ContentDisplay("[反应类型]"))
            {
                case "不触发反应": Reaction_Choose.SelectedIndex = 0; break;
                case "触发超导反应": Reaction_Choose.SelectedIndex = 1; break;
                case "触发扩散反应": Reaction_Choose.SelectedIndex = 2; break;
                case "触发感电反应": Reaction_Choose.SelectedIndex = 3; break;
                case "触发碎冰反应": Reaction_Choose.SelectedIndex = 4; break;
                case "触发超载反应": Reaction_Choose.SelectedIndex = 5; break;
                case "触发增幅反应(小)": Reaction_Choose.SelectedIndex = 6; break;
                case "触发增幅反应(大)": Reaction_Choose.SelectedIndex = 7; break;
            }
            toolStrips.Visible = true;
            toolStrips.Text = ContentDisplay("[备注]");
        }
        private string ContentDisplay(string name)
        {
            var rtn = "0";
            try
            {
                foreach (string str in Attributes)
                {
                    if (str == name)
                    {
                        rtn = Values[Array.IndexOf(Attributes, str)];
                    }
                }
            }
            catch (Exception)
            { }
            return rtn;
        }
        //写入
        private void SaveFiles(object sender, EventArgs e)
        {
            if (!Filesave)
            {
                Filesave = true;
                SaveFiles();
                Filesave = false;
            }
            else SaveFiles();
        }
        private void SaveFiles()
        {
            string[] text = new string[8];
            text[0] = string.Format("<面板>\t[白攻]{0}\t[绿攻]{1}\t[暴率]{2}\t[暴伤]{3}\t[精通]{4}\t[元素]{5}", ATK.Text, ATKPlus.Text, CritRate.Text, CritDMG.Text, EM.Text, EP.Text);
            text[1] = string.Format("<加攻>\t[固定攻击]{0}\t[比率攻击]{1}\t[防御收益]{2}\t[生命收益]{3}\t[叠加攻击]{4}\t[叠攻层数]{5}", ATKBuff.Text, ATKBuff_P.Text, ATKBuff_DEF.Text, ATKBuff_HP.Text, ATKBuff_S.Text, ATKBuff_Sf.Text);
            text[2] = string.Format("<等级>\t[我方等级]{0}\t[敌方等级]{1}\t[防御变化]{2}\t[敌人抗性]{3}", PlayerLevel.Text, EnemyLevel.Text, Defense.Text, EnemyRES.Text);
            text[3] = string.Format("<加伤>\t[伤害提升]{0}\t[叠加伤害]{1}\t[叠伤层数]{2}\t[反应加剧]{3}", DMGBuff.Text, DMGBuff_S.Text, DMGBuff_Sf.Text, ReactBuff.Text);
            text[4] = string.Format("<其他>\t[天赋倍率]{0}\t[额外乘区]{1}\t[反应类型]{2}", Skill.Text, Other.Text, Reaction_Choose.SelectedItem.ToString());
            text[5] = string.Format("<输出>\t[未暴击]{0}\t[已暴击]{1}\t[平均值]{2}", Normal, Crit, Avg);
            text[6] = string.Format("<注解>\t[备注]{0}", toolStrips.Text == "点击此处添加备注" ? "文件创建于" + DateTime.Now : toolStrips.Text);
            try
            {
                if (Filesave)
                {
                    SaveFile.Filter = "计算器角色文件|*.yschar";
                    SaveFile.ShowDialog();
                    File.WriteAllLines(SaveFile.FileName, text);
                }
                else
                {
                    File.WriteAllLines(FileLocation + "Temp.yschar", text);
                }
            }
            catch (Exception)
            {
            }
        }
        private void Notes(object sender, EventArgs e)//添加备注
        {
            bool topmosted = false;
            if (TopMost)
            {
                TopMost = false;
                topmosted = true;
            }
            NoteAdd note = new NoteAdd();
            note.RecvNote(toolStrips.Text);
            note.ShowDialog();
            if (note.ReturnedText() == null)
            {
            }
            else if (note.ReturnedText() != " ")
            {
                toolStrips.Text = note.ReturnedText();
            }
            else if (note.ReturnedText() == " ")
            {
                toolStrips.Text = "点击此处添加备注";
            }
            if (topmosted)
            {
                TopMost = true;
            }
        }
        #endregion
        //“帮助”项//
        private void 计算公式来源ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("https://bbs.nga.cn/read.php?tid=25564438");
        }
        private void 关于ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About AboutForm = new About();
            AboutForm.ShowDialog();
        }

        #region 其他计算器
        private void 治疗量计算器ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool topmosted = false;
            if (TopMost)
            {
                TopMost = false;
                topmosted = true;
            }
            try
            {
                Thread HealThread = new Thread(new ThreadStart(_Healing));
                HealThread.Start();
            }
            catch (Exception)
            { }
            if (topmosted)
            {
                TopMost = true;
            }
        }
        private void _Healing()
        {
            Heal Healing = new Heal();
            Healing.ShowDialog();
        }
        private void 锚定伤害计算器ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool topmosted = false;
            if (TopMost)
            {
                TopMost = false;
                topmosted = true;
            }
            try
            {
                Thread TargetedThread = new Thread(new ThreadStart(_TargetedCalc));
                TargetedThread.Start();
            }
            catch (Exception)
            { }
            if (topmosted)
            {
                TopMost = true;
            }
        }
        private void _TargetedCalc()
        {
            CalculatorPro p = new CalculatorPro();
            p.Input((int)(ATK1.Value + ATKPlus1.Value //攻击力
                        + ATKBuff1.Value + DEF2ATK + HP2ATK
                        + (double.Parse(ATKBuff_P.Text) / 100 * ATK1.Value)//攻击力加成
                        + double.Parse(ATKBuff_S.Text) / 100 * ATK1.Value * ATKBuff1_Sf.Value)//攻击力加成(层数)
                    , double.Parse(CritRate.Text)
                    , double.Parse(CritDMG.Text)
                    , EM1.Value
                    , double.Parse(EP.Text) //元素伤害
                        + double.Parse(DMGBuff.Text)//伤害提升
                        + double.Parse(DMGBuff_S.Text) * DMGBuff1_Sf.Value//伤害提升(层数)
                    , double.Parse(Skill.Text)
                    , double.Parse(Other.Text)
                    , PlayerLevel1.Value
                    , EnemyLevel1.Value
                    , double.Parse(EnemyRES.Text)
                    , double.Parse(Defense.Text)
                    , Reaction_Choose.SelectedIndex
                    , double.Parse(ReactBuff.Text)
                    );
            p.ShowDialog();
        }
        private void Windows计算器ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("calc");
        }
        private void DPS简易计算ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool topmosted = false;
            if (TopMost)
            {
                TopMost = false;
                topmosted = true;
            }
            try
            {
                Thread DPSThread = new Thread(new ThreadStart(_DPSCalc));
                DPSThread.Start();
            }
            catch (Exception)
            { }
            if (topmosted)
            {
                TopMost = true;
            }
        }
        private void _DPSCalc()
        {
            DPSCalc _Calc = new DPSCalc();
            _Calc.Input(
                Convert.ToDouble(Skill.Text) / 100,
                BUFLV,
                ATKLC * DEFLC * float.Parse(Other.Text) / 100 * (1 + float.Parse(CritRate.Text) * float.Parse(CritDMG.Text) / 10000)
                , (float)ReactBuff1.Value / 1000
                , EM1.Value
                , PlayerLevel1.Value);
            _Calc.ShowDialog();
        }
        private void 圣遗物简易比较器ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool topmosted = false;
            if (TopMost)
            {
                TopMost = false;
                topmosted = true;
            }
            try
            {
                Thread CMPThread = new Thread(new ThreadStart(_Compare));
                CMPThread.Start();
            }
            catch (Exception)
            { }
            if (topmosted)
            {
                TopMost = true;
            }
        }
        private void _Compare()
        {
            ArtifactCompare CompareTool = new ArtifactCompare();
            CompareTool.ShowDialog();
        }
        #endregion

        #region 特殊角色定制计算器
        //////特殊角色定制计算器//////
        private void 诺艾尔防御转攻击ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool topmosted = false;
            if (TopMost)
            {
                TopMost = false;
                topmosted = true;
            }
            Noelle_Calc DEFin = new Noelle_Calc();
            DEFin.Input(def1, def2, defu);
            //数值读取至窗口中
            DEFin.ShowDialog();
            //显示对话框
            def1 = DEFin.ATKAdd() != 0 ? DEFin.Output(1) : 0;
            def2 = DEFin.ATKAdd() != 0 ? DEFin.Output(2) : 0;
            defu = DEFin.ATKAdd() != 0 ? DEFin.Output(4) : 0;
            DEF2ATK = (int)DEFin.ATKAdd();
            //将数值保存至此进程内存中
            ATKBuff_DEF.Text = Convert.ToString(DEF2ATK);

            Calculate();
            //进行一遍计算
            if (topmosted)
            {
                TopMost = true;
            }
            //最后执行窗口置顶的回正
        }
        private void 阿贝多防御值加伤替换攻击ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Thread Albedo = new Thread(new ThreadStart(Albedo_Function));
            bool topmosted = false;
            if (TopMost)
            {
                TopMost = false;
                topmosted = true;
            }
            Albedo.Start();

            if (topmosted)
            {
                TopMost = true;
            }
        }
        private void Albedo_Function()
        {
            RESCalc();
            Calculate();
            Albedo_Calc DEF_A = new Albedo_Calc();
            DEF_A.Input(
                ATKLC,
                1 + (DataStream[5] + DataStream[6]) / 100,
                DataStream[15] * DataStream[12],
                DataStream[3] / 100 + 1,
                1 + float.Parse(CritRate.Text) * float.Parse(CritDMG.Text) / 10000);
            DEF_A.ShowDialog();
        }
        private void 胡桃生命值加攻ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool topmosted = false;
            if (TopMost)
            {
                TopMost = false;
                topmosted = true;
            }
            Hutao_Calc _Calc = new Hutao_Calc();
            _Calc.Input(
                    ATKLC
                    , double.Parse(CritRate.Text) / 100
                    , double.Parse(CritDMG.Text) / 100
                    , (100 + ELMLV + BUFLV) / 100
                    , React * DEFLC * Resistance * float.Parse(Other.Text) / 100);//其他乘区计算
            _Calc.ShowDialog();
            HP2ATK = _Calc.Output(_Calc.DialogResult);
            ATKBuff_HP.Text = Convert.ToString(HP2ATK);
            Calculate();
            if (topmosted)
            {
                TopMost = true;
            }
        }
        private void 钟离生命值加伤ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool topmosted = false;
            if (TopMost)
            {
                TopMost = false;
                topmosted = true;
            }
            Zhongli_Calc _Calc = new Zhongli_Calc();
            _Calc.Input(
                float.Parse(Skill.Text)
                , ATKLC
                , (100 + ELMLV + BUFLV) / 100
                , DEFLC * float.Parse(Other.Text) / 100//其他乘区计算
                , float.Parse(EnemyRES.Text)//抗性计算
                , float.Parse(EnemyRES.Text)
                , float.Parse(CritRate.Text)
                , float.Parse(CritDMG.Text));
            _Calc.UpdateIndex();
            _Calc.ShowDialog();
            if (topmosted)
            {
                TopMost = true;
            }
        }
        #endregion
        //窗口置顶开关//
        private void 窗口置顶ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TopMost = TopMost ? false : true;
        }
        #region 查询工具
        private void 敌人抗性快速查询ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            bool topmosted = false;
            if (TopMost)
            {
                TopMost = false;
                topmosted = true;
            }
            try
            {
                Thread EnemyThread = new Thread(new ThreadStart(_Enemy));
                EnemyThread.Start();
            }
            catch (Exception)
            { }
            if (topmosted)
            {
                TopMost = true;
            }
        }
        private void _Enemy()
        {
            EnemyTable enemy = new EnemyTable();
            try
            {
                enemy.EnemyCheck();
                enemy.ShowDialog();
            }
            catch (NullReferenceException)
            {
                DialogResult err;
                err = MessageBox.Show("文件似乎正在被占用。\n请关闭相应的表格文件后重试。", "提示");
            }
            EnemyRES.Text = Math.Round(enemy.Output() * 100, 0).ToString();
            Calculate();
            if (EnemyRES.Text == "∞")
            {
                DialogResult err;
                err = MessageBox.Show("你选的抗性是无限大啊。\n都免疫了还算啥伤害。", "免疫预警");
            }
        }
        private void 角色与武器快捷输入ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            bool topmosted = false;
            if (TopMost)
            {
                TopMost = false;
                topmosted = true;
            }
            try
            {
                Thread ChThread = new Thread(new ThreadStart(_Characters));
                ChThread.Start();
            }
            catch (Exception)
            { }
            if (topmosted)
            {
                TopMost = true;
            }
        }
        private void _Characters()
        {
            Characters_Weapons cw = new Characters_Weapons();
            try
            {
                cw.ShowDialog();
                if (cw.Output() != -1)
                {
                    ATK1.Value = cw.Output();
                }
                ATK.Text = ATK1.Value.ToString();
            }
            catch (NullReferenceException)
            {
                DialogResult err;
                err = MessageBox.Show("文件似乎正在被占用。\n请关闭相应的表格文件后重试。", "提示");
            }
            catch (ObjectDisposedException)
            {

            }
            Calculate();
        }
        #endregion

        #region ////////////计算过程////////////
        Upheaval upheaval = new Upheaval();
        /// <summary>
        /// 总防御乘区
        /// </summary>
        double DEFLC;
        /// <summary>
        /// 总攻击及攻击乘区
        /// </summary>
        double ATKLC;
        /// <summary>
        /// 元素加伤与其他加伤乘区
        /// </summary>
        double ELMLV, BUFLV;

        public void ReactionCalculator(int index)
        {
            var ReactType = 2000;
            // 伤害类型测定
            if (index <= 5 && index > 0)
            {
                rp = 16.0;          // 剧变反应
            }
            else
            {
                rp = 2.78;          // 增幅反应
                ReactType = 1400;
            }
            // 数值计算
            // 关于反应伤害的计算：
            // 剧变反应伤害 = [等级~剧变反应基数] * [1 + Σ反应加成] * [抗性系数](* [1 + 深渊反应buff])
            // 增幅反应伤害 = 未触发反应的伤害 * [1 + Σ反应加成] (* [1 + 深渊反应buff])
            ///React：反应加成
            React = 1
                + ((float)rp / (1 + ReactType / (float)EM1.Value)
                + (float)ReactBuff1.Value / 1000);

            switch (index)
            {
                case 1: React *= 0.25; break;  //超导
                case 2: React *= 0.30; break;  //扩散
                case 3: React *= 0.60; break;  //感电
                case 4: React *= 0.75; break;  //碎冰
                case 5: React *= 1.00; break;  //超载
                case 6: React *= 1.50; break;  //1.5倍增幅
                case 7: React *= 2.00; break;  //2.0倍增幅
                default: Reaction_Choose.Text = "不触发反应"; break;
            }
            if (index == 0) React = 1;// 无反应
        }
        /// <summary>
        /// 计算伤害的主要公式
        /// </summary>
        public void Calculate()
        {
            try
            {
                DEFLC = (PlayerLevel1.Value + 100) / (PlayerLevel1.Value + 100 + (1 + float.Parse(Defense.Text) / 100) * (EnemyLevel1.Value + 100));
                ATKLC = ATK1.Value + ATKPlus1.Value //攻击力
                        + ATKBuff1.Value + DEF2ATK + HP2ATK + (float.Parse(ATKBuff_P.Text) / 100 * ATK1.Value)//攻击力加成
                        + float.Parse(ATKBuff_S.Text) / 100 * ATK1.Value * ATKBuff1_Sf.Value;//攻击力加成(层数)
                ELMLV = float.Parse(EP.Text);
                BUFLV = float.Parse(DMGBuff.Text)//伤害提升
                        + float.Parse(DMGBuff_S.Text) * DMGBuff1_Sf.Value;//伤害提升(层数) 

                //反应伤害相关计算
                ReactionCalculator(Reaction_Choose.SelectedIndex);

                if (Reaction_Choose.SelectedIndex >= 6 || Reaction_Choose.SelectedIndex == 0)
                {
                    //基础、增幅伤害相关计算
                    check = false;
                    Normal = ATKLC                       //总攻击力
                        * (1 + (ELMLV + BUFLV) / 100)    //伤害加成
                        * React                          //元素精通
                        * DEFLC                          //防御属性
                        * Resistance                     //抗性计算
                        * float.Parse(Skill.Text) / 100  //技能倍率
                        * float.Parse(Other.Text) / 100; //其他乘区
                    //等级压制计算,参考：https://bbs.nga.cn/read.php?tid=24358389
                    if (PlayerLevel1.Value - EnemyLevel1.Value > 70 && EnemyLevel1.Value <= 10)
                        Normal *= 1.5;
                    else if (EnemyLevel1.Value - PlayerLevel1.Value > 70 && PlayerLevel1.Value <= 10)
                        Normal *= 0.5;

                    Crit = Normal * (1 + float.Parse(CritDMG.Text) / 100);
                    Avg = Normal * (1 + float.Parse(CritRate.Text) * float.Parse(CritDMG.Text) / 10000);

                    //暴击时的伤害修正
                    //满暴击时,普通伤害等于暴击伤害
                    if (float.Parse(CritRate.Text) == 100)
                    {
                        Normal = Crit;
                    }
                    //不暴击时,暴击伤害等于普通伤害
                    else if (float.Parse(CritRate.Text) == 0)
                    {
                        Crit = Normal;
                    }
                }
                else    //剧变反应伤害相关计算
                {
                    check = true;
                    Normal = React * upheaval.Upheaval_Damage(PlayerLevel1.Value, false) * Resistance;
                    Avg = Normal;
                }
                //免疫相关显示
                if (EnemyRES.Text.Contains("∞"))
                {
                    Normal = 0;
                    Avg = 0;
                    Crit = 0;
                    Resistance = 0;
                }
                //伤害数值转为文本
                Normal_DMG.Text = Convert.ToString(Normal);
                Crit_DMG.Text = check ? "N/A" : Convert.ToString(Crit);
                Avg_DMG.Text = Convert.ToString(Avg);
            }
            catch { }
            if (P1.SelectedTab == tabPage5)
            {
                DetailedCalculate();
            }
            Streamer();
        }
        #region 数据转化为表格
        private void DetailedCalculate(object sender, EventArgs e)
        {
            DetailedCalculate();
        }
        private async void DetailedCalculate()
        {
            var CritValue = 1D;
            var ContentsTemp = new double[8];
            if (DMGType0.Checked)
            {
                CritValue = 1d;
            }
            else if (DMGType1.Checked)
            {
                CritValue = 1 + Convert.ToDouble(CritDMG1.Value) / 1000;
            }
            else
            {
                CritValue = 1 + float.Parse(CritRate.Text) * float.Parse(CritDMG.Text) / 10000;
            }
            AttributeList.BeginUpdate();
            if (Reaction_Choose.SelectedIndex <= 5 && Reaction_Choose.SelectedIndex >= 1)
            {
                Contents = new double[8] { 0, 0, 0, 0, 0, Resistance, React, 0 };
                AttributeList.Items[0].SubItems[1].Text = upheaval.Upheaval_Damage(PlayerLevel1.Value, false).ToString();
            }
            else
            {
                Contents = new double[8]
                {
                    (ATKLC - ATK1.Value) / ATK1.Value
                    ,Convert.ToDouble(Skill1.Value) / 1000
                    ,((ELMLV + BUFLV) / 100) + 1
                    ,CritValue
                    ,DEFLC
                    ,Resistance
                    ,React
                    ,Convert.ToDouble(Other1.Value) / 1000
                };
                AttributeList.Items[0].SubItems[1].Text = ATK.Text;

            }
            for (int i = 1; i <= 8; i++)
            {
                ListProvider(i);
                ContentsTemp[i - 1] = 100 * Contents[i - 1] / Contents.Sum();
                Tmp[i - 1] = 100 * (Contents[i - 1] - 1) / (Contents.Sum() - 8);
            }
            AttributeList.EndUpdate();
            var TrailedTmp = Tmp;
            for (int i = 0; i < Tmp.Length; i++)
            {
                TrailedTmp[i] = Tmp[i] <= 0 ? 0 : Tmp[i];
            }
            ComChart.Series[0].Points.DataBindXY(new string[] { "攻击加成", "天赋倍率", "伤害加深", "暴击伤害", "防御计算", "抗性计算", "元素反应", "额外乘区" }, Sw ? ContentsTemp : TrailedTmp);
            for (int i = 1; i <= 8; i++)
            {
                AttributeList.Items[i].SubItems[2].Text = await OutStr2(i, !Sw);
            }

        }

        private void ComChart_Click(object sender, EventArgs e)
        {
            Sw = !Sw;
            DetailedCalculate();
            ComChart.Annotations[1].Visible = Sw;
            ComChart.Annotations[2].Visible = !Sw;
        }
        private async void ListProvider(int x)
        {
            string OutputString1 = Convert.ToString(string.Format("{0:N7}", Contents[x - 1]));
            string OutputString2 = await OutStr2(x, false);
            if (OutputString1.Contains("."))
            {
                OutputString1 = OutputString1.TrimEnd('0').TrimEnd('.');
                OutputString2 = OutputString2.TrimEnd('0').TrimEnd('.');
            }
            AttributeList.Items[x].SubItems[1].Text = OutputString1 + "x";
            AttributeList.Items[x].SubItems[2].Text = OutputString2;
        }
        Task<string> OutStr2(int x, bool sw)
        {
            if (sw) return Task.Run(() => string.Format("{0:N4}", 100 * (Contents[x - 1] - 1) / (Contents.Sum() - 8)) + "%");
            else return Task.Run(() => string.Format("{0:N4}", 100 * (Contents[x - 1]) / (Contents.Sum())) + "%");
        }
        #endregion
        #endregion //////////计算部分结束///////////
        /// <summary>
        /// 对各变量进行汇总
        /// </summary>
        public void Streamer()
        {
            DataStream[0] = ATK1.Value;                         // 白字攻击力     
            DataStream[1] = ATKPlus1.Value;                     // 绿字攻击力     
            DataStream[2] = (double)CritRate1.Value / 10;       // 暴击率        
            DataStream[3] = (double)CritDMG1.Value / 10;        // 暴击伤害      
            DataStream[4] = EM1.Value;                          // 元素精通      
            DataStream[5] = ELMLV;                              // 元素伤害加成   
            DataStream[6] = BUFLV;                              // 其他伤害加成   
            DataStream[7] = PlayerLevel1.Value;                 // 我方等级      
            DataStream[8] = EnemyLevel1.Value;                  // 敌方等级      
            DataStream[9] = Defense1.Value;                     // 防御变化      
            DataStream[10] = (double)EnemyRES1.Value / 1000;    // 敌方抗性      
            DataStream[11] = (double)Skill1.Value / 1000;       // 天赋倍率      
            DataStream[12] = (double)Other1.Value / 1000;       // 额外乘区      
            DataStream[13] = Reaction_Choose.SelectedIndex;     // 反应类型      
            DataStream[14] = ATKLC;                             // 攻击力乘区之和 
            DataStream[15] = DEFLC;                             // 防御力乘区之和 
            //DataStream[16]=                 //预留
        }
    }
    #region 剧变反应伤害数值
    //参考：https://bbs.mihoyo.com/ys/article/2215872
    public class Upheaval
    {
        readonly double[] UpheavalBase =                //1.6版本及以后的剧变反应基准值
            {0,   33,     37,     38,     42,     44,     49,     52,     57,     62,     68,    //01~10级
                  73,     81,     89,     97,    107,    118,    128,    139,    150,    161,    //11~20级
                 172,    183,    194,    206,    217,    226,    236,    246,    259,    272,    //21~30级
                 284,    298,    310,    323,    338,    352,    368,    383,    399,    414,    //31~40级
                 430,    448,    467,    487,    511,    537,    562,    590,    618,    647,    //41~50级
                 673,    700,    729,    757,    797,    832,    868,    906,    944,    986,    //51~60级
                1027,   1078,   1130,   1184,   1248,   1302,   1359,   1416,   1472,   1531,    //61~70级
                1589,   1649,   1702,   1754,   1828,   1893,   1958,   2022,   2089,   2154,    //71~80级
                2219,   2286,   2352,   2420,   2507,   2578,   2650,   2727,   2810,   2893     //81~90级
            };

        readonly double[] OldUpheavalbase =             //早期的剧变反应基准值
            {0,   33,     37,     38,     42,     44,     49,     52,     57,     62,     68,    //01~10级
                  73,     81,     89,     97,    107,    118,    128,    139,    150,    161,    //11~20级
                 172,    183,    194,    206,    217,    226,    236,    246,    259,    272,    //21~30级
                 284,    298,    310,    323,    338,    352,    368,    383,    399,    414,    //31~40级
                 430,    448,    467,    487,    511,    537,    562,    590,    618,    647,    //41~50级
                 673,    700,    729,    757,    797,    832,    868,    904,    942,    980,    //51~60级
                1019,   1064,   1112,   1160,   1216,   1260,   1306,   1350,   1394,   1440,    //61~70级
                1484,   1530,   1568,   1607,   1661,   1708,   1754,   1800,   1847,   1892,    //71~80级
                1937,   1981,   2027,   2072,   2132,   2179,   2229,   2282,   2343,   2406     //81~90级
            };
        public double Upheaval_Damage(int level, bool Type)
        {
            try
            {
                if (Type)
                {
                    return OldUpheavalbase[level];
                    //return -7E-05 * Math.Pow(level, 4) + 0.0136 * Math.Pow(level, 3) - 0.5231 * Math.Pow(level, 2) + 14.259 * level - 14.578;
                }
                else
                {
                    return UpheavalBase[level];
                    //return -2E-06 * Math.Pow(level, 5) + 0.0004 * Math.Pow(level, 4) - 0.0246 * Math.Pow(level, 3) + 0.7445 * Math.Pow(level, 2) - 1.6865 * level + 34.394;
                }
            }
            catch (Exception)
            {
                return 0;
            }
        }
    }
    #endregion
}