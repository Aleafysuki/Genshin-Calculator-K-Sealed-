using System;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Data;
using System.Threading;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

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
        //private DataTable Comtable = new DataTable();
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
            Reaction_Choose.SelectedIndex = 0;
            if (File.Exists(FileLocation + "Configuration.Config"))
            {
                SettingsChange(true);
                LoadSettings();
                SettingsChange(false);
            }
            Calculate();
            RESCalc();
            FileCheck();
            //Cocogoat圣遗物导入ToolStripMenuItem.Visible = false;
        }
        #endregion

        #region 录入设置项
        Settings settings = new Settings();
        private void LoadSettings()
        {
            ATK_Basic.Maximum = (int)settings.Output(0, "MAX");
            ATK_Added.Maximum = (int)settings.Output(1, "MAX");
            Crit_Damage.Maximum = (int)settings.Output(2, "MAX");
            DamageBuff_Elem.Maximum = (int)settings.Output(3, "MAX");
            Skill.Maximum = (int)settings.Output(4, "MAX");
            Resistance_Percent.Minimum = (int)settings.Output(5, "MAX");
            Resistance_Percent.Maximum = (int)settings.Output(6, "MAX");
            ElemMastery.Maximum = (int)settings.Output(7, "MAX");
            DamageBuff_Reaction.Maximum = (int)settings.Output(8, "MAX");
            Other.Maximum = (int)settings.Output(9, "MAX");
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
                      ATK_Basic.Maximum,
                      ATK_Added.Maximum,
                      Crit_Damage.Maximum,
                      DamageBuff_Elem.Maximum,
                      Skill.Maximum,
                      Resistance_Percent.Minimum,
                      Resistance_Percent.Maximum,
                      ElemMastery.Maximum,
                      DamageBuff_Reaction.Maximum,
                      Other.Maximum);
                settingwindow.ShowDialog();
            }
            else
            {
                _ = MessageBox.Show("施工中");
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
                if (File.Exists("FZXIANGSU12.TTF"))
                {
                    _ = MessageBox.Show("已找到文件。\n请点击新窗口中的【安装】按钮并重新启动计算器。");
                }
                else
                {
                    _ = MessageBox.Show("未找到文件。\n需要从网络中下载指定字体文件。");
                    ReadFile down = new ReadFile();
                    down.Download("https://genshincalc.oss-cn-beijing.aliyuncs.com/font/FZXIANGSU12.TTF", "FZXIANGSU12.TTF");
                    _ = MessageBox.Show("已下载文件。\n请点击新窗口中的【安装】按钮并重新启动计算器。");
                }
                try
                {
                    File.Copy("FZXIANGSU12.TTF", @"C:\Windows\Fonts" + @"\FZXIANGSU12.TTF", true);
                }
                catch (UnauthorizedAccessException)
                {
                    _ = MessageBox.Show("没有安装字体的权限。\n请使用管理员权限重新打开再试试。");
                }
                catch (Exception error)
                {
                    _ = MessageBox.Show($"由于某些信息安装失败。\n错误信息：{error.Message}。");
                }
            }
        }
        #endregion

        #region 窗体相关操作
        //窗口透明化//
        private void TransButton_MouseDown(object sender, MouseEventArgs e)
        {
            Opacity = 0.09;
        }
        private void TransButton_MouseUp(object sender, MouseEventArgs e)
        {
            Opacity = 1;
        }
        //窗口置顶开关//
        private void 窗口置顶ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TopMost = !TopMost;
        }
        #endregion

        #region 输入各项数据
        private void ValueSet(object sender, EventArgs e)
        {
            ValueSet();
        }
        private async void ValueSet()
        {
            DEFLC = (Level_Player.Current + 100)
                    / (Level_Player.Current + 100 + (1 + (float)Defence_Debuff.Current / 1000) * (Level_Enemy.Current + 100));
            ATKLC = ATK_Basic.Current + ATK_Added.Current   // 攻击力
                    + ATKBuff_Static.Current                // 攻击力加成
                    + ATKBuff_Percent.Current / 1000        // 攻击力加成 
                    + DEF2ATK
                    + HP2ATK
                    + ATKBuff_Stack_Percent.Current / 1000 * ATK_Basic.Current * ATKBuff_Stack_Count.Current;// 攻击力加成(层数)
            ELMLV = DamageBuff_Elem.Current / 10;
            BUFLV = (DamageBuff_Percent.Current                                                 // 伤害提升
                    + DamageBuff_Stack_Percent.Current * DamageBuff_Stack_Count.Current)
                    / 10;  // 伤害提升(层数) 
            await Calc_Await();
        }
        Task<int> Calc_Await()
        {
            return Task.Run(() =>
            {
                RESCalc();
                Calculate();
                return 0;
            });
        }
        //抗性计算//
        private void RESCalc()
        {
            if (float.Parse(Resistance_Percent.Value.Text) < 0)
            {
                Resistance = 1 - float.Parse(Resistance_Percent.Value.Text) / 200;
            }
            else if (0 <= float.Parse(Resistance_Percent.Value.Text) && float.Parse(Resistance_Percent.Value.Text) <= 75)
            {
                Resistance = 1 - float.Parse(Resistance_Percent.Value.Text) / 100;
            }
            else if (75 < float.Parse(Resistance_Percent.Value.Text))
            {
                Resistance = 1 / (1 + 4 * (float.Parse(Resistance_Percent.Value.Text) / 100));
            }

        }
        //确定反应倍率//
        private void Reaction_Choose_SelectedIndexChanged(object sender, EventArgs e)
        {
            Calculate();
        }
        #endregion 

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
            ATK_Basic.Value.Text = ContentDisplay("[白攻]");
            ATK_Added.Value.Text = ContentDisplay("[绿攻]");
            Crit_Rate.Value.Text = ContentDisplay("[暴率]");
            Crit_Damage.Value.Text = ContentDisplay("[暴伤]");
            ElemMastery.Value.Text = ContentDisplay("[精通]");
            DamageBuff_Elem.Value.Text = ContentDisplay("[元素]");
            ATKBuff_Static.Value.Text = ContentDisplay("[固定攻击]");
            ATKBuff_Percent.Value.Text = ContentDisplay("[比率攻击]");
            ATKBuff_DEF.Text = ContentDisplay("[防御收益]");
            ATKBuff_HP.Text = ContentDisplay("[生命收益]");
            ATKBuff_Stack_Percent.Value.Text = ContentDisplay("[叠加攻击]");
            ATKBuff_Stack_Count.Value.Text = ContentDisplay("[叠攻层数]");
            Level_Player.Value.Text = ContentDisplay("[我方等级]");
            Level_Enemy.Value.Text = ContentDisplay("[敌方等级]");
            Defence_Debuff.Value.Text = ContentDisplay("[防御变化]");
            Resistance_Percent.Value.Text = ContentDisplay("[敌人抗性]");
            DamageBuff_Percent.Value.Text = ContentDisplay("[伤害提升]");
            DamageBuff_Stack_Percent.Value.Text = ContentDisplay("[叠加伤害]");
            DamageBuff_Stack_Count.Value.Text = ContentDisplay("[叠伤层数]");
            DamageBuff_Reaction.Value.Text = ContentDisplay("[反应加剧]");
            Skill.Value.Text = ContentDisplay("[天赋倍率]");
            Other.Value.Text = ContentDisplay("[额外乘区]");
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
            text[0] = string.Format("<面板>\t[白攻]{0}\t[绿攻]{1}\t[暴率]{2}\t[暴伤]{3}\t[精通]{4}\t[元素]{5}", ATK_Basic.Value.Text, ATK_Added.Value.Text, Crit_Rate.Value.Text, Crit_Damage.Value.Text, ElemMastery.Value.Text, DamageBuff_Elem.Value.Text);
            text[1] = string.Format("<加攻>\t[固定攻击]{0}\t[比率攻击]{1}\t[防御收益]{2}\t[生命收益]{3}\t[叠加攻击]{4}\t[叠攻层数]{5}", ATKBuff_Static.Value.Text, ATKBuff_Percent.Value.Text, ATKBuff_DEF.Text, ATKBuff_HP.Text, ATKBuff_Stack_Percent.Value.Text, ATKBuff_Stack_Count.Value.Text);
            text[2] = string.Format("<等级>\t[我方等级]{0}\t[敌方等级]{1}\t[防御变化]{2}\t[敌人抗性]{3}", Level_Player.Value.Text, Level_Enemy.Value.Text, Defence_Debuff.Value.Text, Resistance_Percent.Value.Text);
            text[3] = string.Format("<加伤>\t[伤害提升]{0}\t[叠加伤害]{1}\t[叠伤层数]{2}\t[反应加剧]{3}", DamageBuff_Percent.Value.Text, DamageBuff_Stack_Percent.Value.Text, DamageBuff_Stack_Count.Value.Text, DamageBuff_Reaction.Value.Text);
            text[4] = string.Format("<其他>\t[天赋倍率]{0}\t[额外乘区]{1}\t[反应类型]{2}", Skill.Value.Text, Other.Value.Text, Reaction_Choose.SelectedItem.ToString());
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
                Thread HealThread = new Thread(new ThreadStart(Healing));
                HealThread.Start();
            }
            catch (Exception)
            { }
            if (topmosted)
            {
                TopMost = true;
            }
        }
        private void Healing()
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
                Thread TargetedThread = new Thread(new ThreadStart(TargetedCalc));
                TargetedThread.Start();
            }
            catch (Exception)
            { }
            if (topmosted)
            {
                TopMost = true;
            }
        }
        private void TargetedCalc()
        {
            CalculatorPro p = new CalculatorPro();
            p.Input((int)(ATK_Basic.Current + ATK_Added.Current //攻击力
                        + ATKBuff_Static.Current + DEF2ATK + HP2ATK
                        + (double.Parse(ATKBuff_Percent.Value.Text) / 100 * ATK_Basic.Current)//攻击力加成
                        + double.Parse(ATKBuff_Stack_Percent.Value.Text) / 100 * ATK_Basic.Current * ATKBuff_Stack_Count.Current)//攻击力加成(层数)
                    , double.Parse(Crit_Rate.Value.Text)
                    , double.Parse(Crit_Damage.Value.Text)
                    , (int)ElemMastery.Current
                    , double.Parse(DamageBuff_Elem.Value.Text) //元素伤害
                        + double.Parse(DamageBuff_Percent.Value.Text)//伤害提升
                        + double.Parse(DamageBuff_Stack_Percent.Value.Text) * DamageBuff_Stack_Count.Current//伤害提升(层数)
                    , double.Parse(Skill.Value.Text)
                    , double.Parse(Other.Value.Text)
                    , (int)Level_Player.Current
                    , (int)Level_Enemy.Current
                    , double.Parse(Resistance_Percent.Value.Text)
                    , double.Parse(Defence_Debuff.Value.Text)
                    , Reaction_Choose.SelectedIndex
                    , double.Parse(DamageBuff_Reaction.Value.Text)
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
                Thread DPSThread = new Thread(new ThreadStart(DPSCalc));
                DPSThread.SetApartmentState(ApartmentState.STA);
                DPSThread.Start();
            }
            catch (Exception)
            { }
            if (topmosted)
            {
                TopMost = true;
            }
        }
        private void DPSCalc()
        {
            DPSCalc _Calc = new DPSCalc();
            _Calc.Input(
                BUFLV,
                ATKLC * DEFLC * float.Parse(Other.Value.Text) / 100 * (1 + float.Parse(Crit_Rate.Value.Text) * float.Parse(Crit_Damage.Value.Text) / 10000)
                , (float)DamageBuff_Reaction.Current / 1000
                , (int)ElemMastery.Current
                , (int)Level_Player.Current);
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
                Thread CMPThread = new Thread(new ThreadStart(Compare));
                CMPThread.Start();
            }
            catch (Exception)
            { }
            if (topmosted)
            {
                TopMost = true;
            }
        }
        private void Compare()
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
                1 + float.Parse(Crit_Rate.Value.Text) * float.Parse(Crit_Damage.Value.Text) / 10000);
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
                    , double.Parse(Crit_Rate.Value.Text) / 100
                    , double.Parse(Crit_Damage.Value.Text) / 100
                    , (100 + ELMLV + BUFLV) / 100
                    , React * DEFLC * Resistance * float.Parse(Other.Value.Text) / 100);//其他乘区计算
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
                float.Parse(Skill.Value.Text)
                , ATKLC
                , (100 + ELMLV + BUFLV) / 100
                , DEFLC * float.Parse(Other.Value.Text) / 100//其他乘区计算
                , float.Parse(Resistance_Percent.Value.Text)//抗性计算
                , float.Parse(Resistance_Percent.Value.Text)
                , float.Parse(Crit_Rate.Value.Text)
                , float.Parse(Crit_Damage.Value.Text));
            _Calc.UpdateIndex();
            _Calc.ShowDialog();
            if (topmosted)
            {
                TopMost = true;
            }
        }
        #endregion

        #region 查询工具与其他
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
                Thread EnemyThread = new Thread(new ThreadStart(Enemy));
                EnemyThread.Start();
            }
            catch (Exception)
            { }
            if (topmosted)
            {
                TopMost = true;
            }
        }
        private void Enemy()
        {
            EnemyTable enemy = new EnemyTable();
            try
            {
                enemy.EnemyCheck();
                enemy.ShowDialog();
            }
            catch (NullReferenceException)
            {
                _ = MessageBox.Show("文件似乎正在被占用。\n请关闭相应的表格文件后重试。", "提示");
            }
            Resistance_Percent.Value.Text = Math.Round(enemy.Output() * 100, 0).ToString();
            Calculate();
            if (Resistance_Percent.Value.Text == "∞")
            {
                _ = MessageBox.Show("你选的抗性是无限大啊。\n都免疫了还算啥伤害。", "免疫预警");
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
                Thread ChThread = new Thread(new ThreadStart(Characters));
                ChThread.Start();
            }
            catch (Exception)
            { }
            if (topmosted)
            {
                TopMost = true;
            }
        }
        public void Characters()
        {
            Characters_Weapons cw = new Characters_Weapons();
            try
            {
                cw.ShowDialog();
                if (cw.Output() != -1)
                {
                    ATK_Basic.Current = cw.Output();
                }
            }
            catch (NullReferenceException)
            {
                _ = MessageBox.Show("文件似乎正在被占用。\n请关闭相应的表格文件后重试。", "提示");
            }
            catch (ObjectDisposedException)
            {

            }
            Calculate();
        }
        /// <summary>
        /// 圣遗物导入属性
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ArtifactsApply(object sender, EventArgs e)
        {
            ArtifactsLoad Ar = new ArtifactsLoad();
            string[] Attributes;
            try
            {
                Ar.ShowDialog();
                Attributes= Ar.Output();
                for (int i = 0; i < Attributes.Length; i++)
                {
                    if (Attributes[i].Length < 1) Attributes[i] = "0";
                }
                if (Ar.ValueChange)
                {
                    ATK_Basic.Value.Text = Attributes[0];
                    ATK_Added.Value.Text = Attributes[1];
                    Crit_Rate.Value.Text = Attributes[2];
                    Crit_Damage.Value.Text = Attributes[3];
                    DamageBuff_Elem.Value.Text = Attributes[4];
                    ElemMastery.Value.Text = Attributes[5];
                }
            }
            catch (Exception)
            { }

        }
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
        #endregion

        #region ////////////计算过程////////////
        readonly Upheaval upheaval = new Upheaval();
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
                rp = 2.78;          // 增幅反应或者无反应
                ReactType = 1400;
            }
            // 数值计算
            // 关于反应伤害的计算：
            // 剧变反应伤害 = [等级~剧变反应基数] * [1 + Σ反应加成] * [抗性系数](* [1 + 深渊反应buff])
            // 增幅反应伤害 = 未触发反应的伤害 * [1 + Σ反应加成] (* [1 + 深渊反应buff])
            // React：反应加成
            React = 1
                + ((float)rp / (1 + ReactType / (float)ElemMastery.Current)
                + (float)DamageBuff_Reaction.Current / 1000);
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
                        * float.Parse(Skill.Value.Text) / 100  //技能倍率
                        * float.Parse(Other.Value.Text) / 100; //其他乘区
                    //等级压制计算,参考：https://bbs.nga.cn/read.php?tid=24358389
                    if (Level_Player.Current - Level_Enemy.Current > 70 && Level_Enemy.Current <= 10)
                        Normal *= 1.5;
                    else if (Level_Enemy.Current - Level_Player.Current > 70 && Level_Player.Current <= 10)
                        Normal *= 0.5;

                    Crit = Normal * (1 + float.Parse(Crit_Damage.Value.Text) / 100);
                    Avg = Normal * (1 + float.Parse(Crit_Rate.Value.Text) * float.Parse(Crit_Damage.Value.Text) / 10000);

                    //暴击时的伤害修正
                    //满暴击时,普通伤害等于暴击伤害
                    if (float.Parse(Crit_Rate.Value.Text) == 100)
                    {
                        Normal = Crit;
                    }
                    //不暴击时,暴击伤害等于普通伤害
                    else if (float.Parse(Crit_Rate.Value.Text) == 0)
                    {
                        Crit = Normal;
                    }
                }
                else    //剧变反应伤害相关计算
                {
                    check = true;
                    Normal = React * upheaval.Upheaval_Damage((int)Level_Player.Current, false) * Resistance;
                    Avg = Normal;
                }
                //免疫相关显示
                if (Resistance_Percent.Value.Text.Contains("∞"))
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
            catch
            {
                //_ = MessageBox.Show("111");// 调试用 调试完成后尽快将其注释掉
            }
            if (P1.SelectedIndex == 4)
            {
                if (ChartDrawing != null)
                {
                    DetailedCalculate();
                }
                else
                {
                    ChartDrawing = new Thread(DetailedCalculate);
                    ChartDrawing.Start();
                }
            }
            else if (ChartDrawing != null)
            {
                ChartDrawing.Abort();
                ComChart.Enabled = false;
            }

        }
        #endregion //////////计算部分结束///////////

        #region 数据转化为表格
        double[] ContentsTemp = new double[8];
        private void DetailedCalculate(object sender, EventArgs e)
        {
            if (P1.SelectedIndex == 4)
            {
                Calculate();
                ComChart.Enabled = true;
            }

        }
        private async void DetailedCalculate()
        {
            double CritValue;
            if (DMGType0.Checked)
            {
                CritValue = 1d;
            }
            else if (DMGType1.Checked)
            {
                CritValue = 1 + Convert.ToDouble(Crit_Damage.Current) / 1000;
            }
            else
            {
                CritValue = 1 + float.Parse(Crit_Rate.Value.Text) * float.Parse(Crit_Damage.Value.Text) / 10000;
            }
            if (Reaction_Choose.SelectedIndex <= 5 && Reaction_Choose.SelectedIndex >= 1)
            {
                Contents = new double[8] { 0, 0, 0, 0, 0, Resistance, React, 0 };
                AttributeList.Items[0].SubItems[1].Text = upheaval.Upheaval_Damage((int)Level_Player.Current, false).ToString();
            }
            else
            {
                Contents = new double[8]
                {
                    (ATKLC - ATK_Basic.Current) / ATK_Basic.Current + 1
                    ,Convert.ToDouble(Skill.Current) / 1000
                    ,((ELMLV + BUFLV) / 100) + 1
                    ,CritValue
                    ,DEFLC
                    ,Resistance
                    ,React
                    ,Convert.ToDouble(Other.Value.Text) / 1000
                };
                AttributeList.Items[0].SubItems[1].Text = ATK_Basic.CurrentStr;

            }
            for (int i = 1; i <= 8; i++)
            {
                ListProvider(i);
                ContentsTemp[i - 1] = 100 * Contents[i - 1] / Contents.Sum();
                Tmp[i - 1] = 100 * (Contents[i - 1] - 1) / (Contents.Sum() - 8);
            }
            await ChartRefresh();
        }
        private async void ChRefresh()
        {
            var TrailedTmp = Tmp;
            for (int i = 0; i < Tmp.Length; i++)
            {
                TrailedTmp[i] = Tmp[i] <= 0 ? 0 : Tmp[i];
            }
            try
            {
                ComChart.Series[0].Points.DataBindXY(new string[] { "攻击加成", "天赋倍率", "伤害加深", "暴击伤害", "防御计算", "抗性计算", "元素反应", "额外乘区" }, Sw ? ContentsTemp : TrailedTmp);
            }
            catch { }
            for (int i = 1; i <= 8; i++)
            {
                AttributeList.Items[i].SubItems[2].Text = await OutStr2(i, !Sw);
            }
        }
        Task<int> ChartRefresh()
        {
            return Task.Run(() => 
            { 
                ChRefresh();
                return 0; 
            });
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
        /// <summary>
        /// 根据等级获取反应计算系数
        /// </summary>
        /// <param name="level">角色等级</param>
        /// <param name="Type">是否使用旧反应系数,true=旧反应系数,false=新反应系数</param>
        /// <returns>计算获得的反应系数值</returns>
        public double Upheaval_Damage(int level, bool Type)
        {
            try
            {
                if (Type)
                {
                    return OldUpheavalbase[level];      // -7E-05 * Math.Pow(level, 4) + 0.0136 * Math.Pow(level, 3) - 0.5231 * Math.Pow(level, 2) + 14.259 * level - 14.578;
                }
                else
                {
                    return UpheavalBase[level];         // -2E-06 * Math.Pow(level, 5) + 0.0004 * Math.Pow(level, 4) - 0.0246 * Math.Pow(level, 3) + 0.7445 * Math.Pow(level, 2) - 1.6865 * level + 34.394;
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