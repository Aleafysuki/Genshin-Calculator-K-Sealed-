using System;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace Genshin_Calc
{
    public partial class Form1 : Form
    {
        bool /*Saved = false,*/ check = false;
        bool FileEx_xlsx = false, FileEx_conf = false;
        bool SettingsChanged = false;
        string FileLocation = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\Genshin Calculator\";
        string FileLocation2 = "";
        int DEF2ATK, HP2ATK;
        double Normal = 0, Crit = 0, Avg = 0;
        double Resistance = 1;
        double React = 1, rp = 1;
        double def1, def2, defu;//防御计算区所需变量
        string[] Attributes;
        string[] Values;
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
        }
        public void SettingsChange(bool s)
        {
            SettingsChanged = s;
        }
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
            //if (SettingsChanged)
            //{ 
            //    ATK1.Value = (int)settings.Output(0, "DFT");
            //    ATK.Text = ATK1.Value.ToString();
            //    ATKPlus1.Value = (int)settings.Output(1, "DFT");
            //    ATKPlus.Text = ATKPlus1.Value.ToString();
            //    CritDMG1.Value = (int)settings.Output(2, "DFT");
            //    CritDMG.Text = Convert.ToString(Convert.ToDouble(CritDMG1.Value) / 10);
            //    EP1.Value = (int)settings.Output(3, "DFT");
            //    EP.Text = Convert.ToString(Convert.ToDouble(EP1.Value) / 10);
            //    Skill1.Value = (int)settings.Output(4, "DFT");
            //    Skill.Text = Convert.ToString(Convert.ToDouble(Skill1.Value) / 10);
            //    EnemyRES1.Value = (int)settings.Output(5, "DFT");
            //    EnemyRES.Text = Convert.ToString(Convert.ToDouble(EnemyRES1.Value) / 10);
            //    EM1.Value = (int)settings.Output(7, "DFT");
            //    EM.Text = EM1.Value.ToString();
            //    ReactBuff1.Value = (int)settings.Output(8, "DFT");
            //    ReactBuff.Text = Convert.ToString(Convert.ToDouble(ReactBuff1.Value) / 10);
            //    Other1.Value = (int)settings.Output(9, "DFT");
            //    Other.Text = Convert.ToString(Convert.ToDouble(Other1.Value) / 10);
            //}
        }
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
        //public void FontIn()
        //{
        //    try
        //    {
        //        PrivateFontCollection Mfonts = new PrivateFontCollection();
        //        Mfonts.AddFontFile(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\Genshin_Calculator\FZXIANGSU12.TTF");
        //        Font Nums = new Font(Mfonts.Families[0], 16);
        //    }
        //    catch (Exception)
        //    {
        //        DialogResult FontCheck;
        //        FontCheck = MessageBox.Show("缺少相应字体文件，可能导致显示效果变化。", "提示", MessageBoxButtons.YesNoCancel);
        //        if (FontCheck == DialogResult.Yes)
        //        {
        //            //下载文件到指定文件夹
        //        }
        //        else if (FontCheck == DialogResult.No)
        //        { }
        //        else if (FontCheck == DialogResult.Cancel)
        //        { }
        //    }
        //}
        //SaveFileDialog ctrl_s = null;
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

        //白字攻击力：角色+武器//
        private void ATK1_Scroll(object sender, EventArgs e)
        {
            ATK.Text = ATK1.Value.ToString();
            Calculate();
        }
        private void ATK_TextChanged(object sender, EventArgs e)
        {
            try
            {
                ATK1.Value = Convert.ToInt32(ATK.Text);
            }
            catch (Exception)
            {

            }
            Calculate();
        }
        //绿字攻击力：圣遗物等加成//
        private void ATKPlus1_Scroll(object sender, EventArgs e)
        {
            ATKPlus.Text = ATKPlus1.Value.ToString();
            Calculate();
        }
        private void ATKPlus_TextChanged(object sender, EventArgs e)
        {
            try
            {
                ATKPlus1.Value = Convert.ToInt32(ATKPlus.Text);
            }
            catch (Exception)
            {

            }
            Calculate();
        }
        //暴击率输入//
        private void CritRate1_Scroll(object sender, EventArgs e)
        {
            CritRate.Text = Convert.ToString(Convert.ToDouble(CritRate1.Value) / 10);
            Calculate();
        }
        private void CritRate_TextChanged(object sender, EventArgs e)
        {
            try
            {
                CritRate1.Value = Convert.ToInt32(Convert.ToDouble(CritRate.Text) * 10);
            }
            catch (Exception)
            {

            }
            Calculate();
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
                CritDMG1.Value = Convert.ToInt32(Convert.ToDouble(CritDMG.Text) * 10);
            }
            catch (Exception)
            {
                
            }
            Calculate();
        }
        //元素精通//
        private void EM1_Scroll(object sender, EventArgs e)
        {
            EM.Text = EM1.Value.ToString();
            Calculate();
        }
        private void EM_TextChanged(object sender, EventArgs e)
        {
            try
            {
                EM1.Value = Convert.ToInt32(EM.Text);
            }
            catch (Exception)
            {
                EP1.Value = 0;
            }
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
            try
            {
                EP1.Value = Convert.ToInt32(Convert.ToDouble(EP.Text) * 10);
            }
            catch (Exception)
            {
                EP1.Value = 0;
            }
            Calculate();
        }
        //伤害加深：百分比//
        private void DMGBuff1_Scroll(object sender, EventArgs e)
        {
            DMGBuff.Text = Convert.ToString(Convert.ToDouble(DMGBuff1.Value) / 10);
            Calculate();
        }
        private void DMGBuff_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DMGBuff1.Value = Convert.ToInt32(Convert.ToDouble(DMGBuff.Text) * 10);
            }
            catch (Exception)
            {
                DMGBuff1.Value = 0;
            }
            Calculate();
        }
        //伤害加深：按层数的百分比//
        private void DMGBuff1_S_Scroll(object sender, EventArgs e)
        {
            DMGBuff_S.Text = Convert.ToString(Convert.ToDouble(DMGBuff1_S.Value) / 10);
            Calculate();
        }
        private void DMGBuff_S_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DMGBuff1_S.Value = Convert.ToInt32(Convert.ToDouble(DMGBuff_S.Text) * 10);
            }
            catch (Exception)
            { }
            Calculate();
        }
        //伤害加深：层数//
        private void DMGBuff1_Sf_Scroll(object sender, EventArgs e)
        {
            DMGBuff_Sf.Text = DMGBuff1_Sf.Value.ToString();
            Calculate();
        }
        private void DMGBuff_Sf_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DMGBuff1_Sf.Value = Convert.ToInt32(DMGBuff_Sf.Text);
            }
            catch (Exception)
            {

            }
            Calculate();
        }
        //攻击加成：固定值//
        private void ATKBuff1_Scroll_1(object sender, EventArgs e)
        {
            ATKBuff.Text = Convert.ToString(ATKBuff1.Value);
            Calculate();
        }
        private void ATKBuff_TextChanged_1(object sender, EventArgs e)
        {
            try
            {
                ATKBuff1.Value = Convert.ToInt32(ATKBuff.Text);
            }
            catch (Exception)
            {

            }
            Calculate();
        }
        //攻击加成：百分比//
        private void ATKBuff1_P_Scroll(object sender, EventArgs e)
        {
            ATKBuff_P.Text = Convert.ToString(Convert.ToDouble(ATKBuff1_P.Value) / 10);
            Calculate();
        }
        private void ATKBuff_P_TextChanged(object sender, EventArgs e)
        {
            try
            {
                ATKBuff1_P.Value = Convert.ToInt32(Convert.ToDouble(ATKBuff_P.Text) * 10);
            }
            catch (Exception)
            {

            }
            Calculate();
        }
        //攻击加成：百分比（算层数）//
        private void ATKBuff1_S_Scroll_1(object sender, EventArgs e)
        {
            ATKBuff_S.Text = Convert.ToString(Convert.ToDouble(ATKBuff1_S.Value) / 10);
            Calculate();
        }
        private void ATKBuff_S_TextChanged_1(object sender, EventArgs e)
        {
            try
            {
                ATKBuff1_S.Value = Convert.ToInt32(Convert.ToDouble(ATKBuff_S.Text) * 10);
            }
            catch (Exception)
            { }
            Calculate();
        }
        //攻击加成：层数//
        private void ATKBuff1_Sf_Scroll_1(object sender, EventArgs e)
        {
            ATKBuff_Sf.Text = ATKBuff1_Sf.Value.ToString();
            Calculate();
        }
        private void ATKBuff_Sf_TextChanged(object sender, EventArgs e)
        {
            try
            {
                ATKBuff1_Sf.Value = Convert.ToInt32(ATKBuff_Sf.Text);
            }
            catch (Exception)
            {

            }
            Calculate();
        }
        //等级和抗性输入：我方//
        private void PlayerLevel1_Scroll(object sender, EventArgs e)
        {
            PlayerLevel.Text = Convert.ToString(PlayerLevel1.Value);
            Calculate();
        }
        private void PlayerLevel_TextChanged(object sender, EventArgs e)
        {
            try
            {
                PlayerLevel1.Value = Convert.ToInt32(PlayerLevel.Text);
            }
            catch (Exception)
            {

            }
            Calculate();
        }
        //等级和抗性输入：敌方//
        private void EnemyLevel1_Scroll(object sender, EventArgs e)
        {
            EnemyLevel.Text = Convert.ToString(EnemyLevel1.Value);
            Calculate();
        }
        private void EnemyLevel_TextChanged(object sender, EventArgs e)
        {
            try
            {
                EnemyLevel1.Value = Convert.ToInt32(EnemyLevel.Text);
            }
            catch (Exception)
            {

            }
            Calculate();
        }
        //防御增减效果//
        private void Defense1_Scroll(object sender, EventArgs e)
        {
            Defense.Text = Convert.ToString(Convert.ToDouble(Defense1.Value) / 10 - 100);
            Calculate();
        }
        private void Defense_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Defense1.Value = Convert.ToInt32(Convert.ToDouble(Defense.Text) * 10 + 1000);
            }
            catch (Exception)
            {

            }
            Calculate();
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
            try
            {
                EnemyRES1.Value = Convert.ToInt32(Convert.ToDouble(EnemyRES.Text) * 10);
                RESCalc();
            }
            catch (Exception)
            { }
        }
        //技能倍率//
        private void Skill1_Scroll(object sender, EventArgs e)
        {
            Skill.Text = Convert.ToString(Convert.ToDouble(Skill1.Value) / 10);
            Calculate();
        }
        private void Skill_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Skill1.Value = Convert.ToInt32(Convert.ToDouble(Skill.Text) * 10);
            }
            catch (Exception)
            { }
            Calculate();
        }
        //其他额外的乘算加伤//
        private void Other1_Scroll(object sender, EventArgs e)
        {
            Other.Text = Convert.ToString(Convert.ToDouble(Other1.Value) / 10);
            Calculate();
        }
        private void Other_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Other1.Value = Convert.ToInt32(Convert.ToDouble(Other.Text) * 10);
            }
            catch (Exception)
            { }
            Calculate();
        }
        //反应伤害增强//
        private void ReactBuff1_Scroll(object sender, EventArgs e)
        {
            ReactBuff.Text = Convert.ToString(Convert.ToDouble(ReactBuff1.Value) / 10);
            Calculate();
        }
        private void ReactBuff_TextChanged(object sender, EventArgs e)
        {
            try
            {
                ReactBuff1.Value = Convert.ToInt32(Convert.ToDouble(ReactBuff.Text) * 10);
            }
            catch (Exception)
            { }
            Calculate();
        }
        //确定反应倍率//
        private void Reaction_Choose_SelectedIndexChanged(object sender, EventArgs e)
        {
            Calculate();
            Calculate();
        }
        //窗口透明化//
        private void TransButton_MouseDown(object sender, MouseEventArgs e)
        {
            Opacity = 0.09;
        }
        private void TransButton_MouseUp(object sender, MouseEventArgs e)
        {
            Opacity = 1;
        }
        //文件操作（施工中）//
        //读取
        private void OpenFiles_Drag(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.All;                                                              //重要代码：表明是所有类型的数据，比如文件路径
            else
                e.Effect = DragDropEffects.None;
            ReadFromFile(File.ReadAllText(((Array)e.Data.GetData(DataFormats.FileDrop)).GetValue(0).ToString()));
            Calculate();
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
            SaveFile.Filter = "计算器角色文件|*.yschar";
            SaveFile.ShowDialog();
            try
            {
                string[] text = new string[8];
                text[0] = string.Format("<面板>\t[白攻]{0}\t[绿攻]{1}\t[暴率]{2}\t[暴伤]{3}\t[精通]{4}\t[元素]{5}", ATK.Text, ATKPlus.Text, CritRate.Text, CritDMG.Text, EM.Text, EP.Text);
                text[1] = string.Format("<加攻>\t[固定攻击]{0}\t[比率攻击]{1}\t[防御收益]{2}\t[生命收益]{3}\t[叠加攻击]{4}\t[叠攻层数]{5}", ATKBuff.Text, ATKBuff_P.Text, ATKBuff_DEF.Text, ATKBuff_HP.Text, ATKBuff_S.Text, ATKBuff_Sf.Text);
                text[2] = string.Format("<等级>\t[我方等级]{0}\t[敌方等级]{1}\t[防御变化]{2}\t[敌人抗性]{3}", PlayerLevel.Text, EnemyLevel.Text, Defense.Text, EnemyRES.Text);
                text[3] = string.Format("<加伤>\t[伤害提升]{0}\t[叠加伤害]{1}\t[叠伤层数]{2}\t[反应加剧]{3}", DMGBuff.Text, DMGBuff_S.Text, DMGBuff_Sf.Text, ReactBuff.Text);
                text[4] = string.Format("<其他>\t[天赋倍率]{0}\t[额外乘区]{1}\t[反应类型]{2}", Skill.Text, Other.Text, Reaction_Choose.SelectedItem.ToString());
                text[5] = string.Format("<输出>\t[未暴击]{0}\t[已暴击]{1}\t[平均值]{2}", Normal, Crit, Avg);
                text[6] = string.Format("<注解>\t[备注]文件创建于{0}", DateTime.Now);
                File.WriteAllLines(SaveFile.FileName, text);
            }
            catch (Exception)
            {
            }
        }

        //“帮助”项//
        private void 计算公式来源ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://bbs.nga.cn/read.php?tid=25564438");
        }
        private void 关于ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult wip;
            wip = MessageBox.Show("此试验版本由K_vAE发布于2020/4/15，目前可实现最基本的计算功能\n本人是菜逼，难免有不准之处，一切以游戏本身为主");

        }

        //其他计算器//
        private void 治疗量计算器ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool topmosted = false;
            if (TopMost)
            {
                TopMost = false;
                topmosted = true;
            }
            Heal Healing = new Heal();
            Healing.ShowDialog();
            if (topmosted)
            {
                TopMost = true;
            }
        }
        private void 锚定伤害计算器ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool topmosted = false;
            if (TopMost)
            {
                TopMost = false;
                topmosted = true;
            }
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
                    , EnemyRES1.Value / 10
                    , double.Parse(Defense.Text)
                    , Reaction_Choose.SelectedIndex
                    , double.Parse(ReactBuff.Text)
                    );
            p.ShowDialog();
            if (topmosted)
            {
                TopMost = true;
            }
        }
        private void Windows计算器ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("calc");
        }
        private void DPS简易计算ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool topmosted = false;
            if (TopMost)
            {
                TopMost = false;
                topmosted = true;
            }
            DPSCalc _Calc = new DPSCalc();
            _Calc.Input(
                Convert.ToDouble(Skill.Text) / 100,
                BUFLV,
                ATKLC * DEFLC * float.Parse(Other.Text) / 100 * (1 + float.Parse(CritRate.Text) * float.Parse(CritDMG.Text) / 10000)
                , (float)ReactBuff1.Value / 1000
                , EM1.Value
                , PlayerLevel1.Value);
            _Calc.ShowDialog();

            if (topmosted)
            {
                TopMost = true;
            }
        }

        //特殊角色定制计算器//
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
            bool topmosted = false;
            if (TopMost)
            {
                TopMost = false;
                topmosted = true;
            }
            RESCalc();
            Calculate();
            Albedo_Calc DEF_A = new Albedo_Calc();
            var buffexceptelem = (100 + float.Parse(DMGBuff.Text) + float.Parse(DMGBuff_S.Text) * DMGBuff1_Sf.Value) / 100;//伤害提升//伤害提升(层数)
            var def = (PlayerLevel1.Value + 100) / (PlayerLevel1.Value + 100 + (1 + float.Parse(Defense.Text) / 100) * (EnemyLevel1.Value + 100));//防御计算
            var crit = 1 + float.Parse(CritDMG.Text) / 100;
            var avg = 1 + float.Parse(CritRate.Text) * float.Parse(CritDMG.Text) / 10000;
            DEF_A.Input(ATKLC, buffexceptelem, def * (1 + float.Parse(Other.Text)) / 100, crit, avg);
            DEF_A.ContentChanged_Pub();
            DEF_A.ShowDialog();
            if (topmosted)
            {
                TopMost = true;
            }
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

        //窗口置顶开关//
        private void 窗口置顶ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TopMost = TopMost ? false : true;
        }
        //查询工具//
        private void 敌人抗性快速查询ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            bool topmosted = false;
            if (TopMost)
            {
                TopMost = false;
                topmosted = true;
            }
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
            if (topmosted)
            {
                TopMost = true;
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
            Characters_Weapons cw = new Characters_Weapons();
            try
            {
                cw.ShowDialog();
                ATK1.Value = cw.Output();
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

            if (topmosted)
            {
                TopMost = true;
            }
        }
        private void ToolStrips_Click(object sender, EventArgs e)
        {
            toolStrips.Visible = toolStrips.Visible ? false : true;
        }


        ////////////计算过程////////////
        Upheaval upheaval = new Upheaval();
        double DEFLC;//总防御
        double ATKLC;//总攻击
        double ELMLV;//元素加伤
        double BUFLV;//(元素加伤之外)总加伤

        public void ReactionCalculator(int index)
        {
            switch (index)
            {
                case 0: rp = 0; React = 1; break;//无反应
                case 1: rp = 6.66; React *= 0.25; break;//超导
                case 2: rp = 6.66; React *= 0.3; break;//扩散
                case 3: rp = 6.66; React *= 0.6; break;//感电
                case 4: rp = 6.66; React *= 0.75; break;//碎冰
                case 5: rp = 6.66; React *= 1; break;//超载
                case 6: rp = 2.78; React *= 1.5; break;//1.5倍增幅
                case 7: rp = 2.78; React *= 2; break;//2.0倍增幅
                default: Reaction_Choose.Text = "不触发反应"; break;
            }
        }
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
                React = 1 + ((float)rp / (1 + 1400 / (float)EM1.Value) + (float)ReactBuff1.Value / 1000);
                //反应伤害相关计算
                ReactionCalculator(Reaction_Choose.SelectedIndex);
                if (Reaction_Choose.SelectedIndex >= 6 || Reaction_Choose.SelectedIndex == 0)
                {
                    //基础、增幅伤害相关计算
                    check = false;
                    Normal = ATKLC                                  //总攻击力
                        * (1 + (ELMLV + BUFLV) / 100)               //伤害加成
                        * React                                     //元素精通
                        * DEFLC                                     //防御属性
                        * Resistance                                //抗性计算
                        * float.Parse(Skill.Text) / 100             //技能倍率
                        * float.Parse(Other.Text) / 100;            //其他乘区
                    //等级压制计算,参考：https://bbs.nga.cn/read.php?tid=24358389
                    if (PlayerLevel1.Value - EnemyLevel1.Value > 70 && EnemyLevel1.Value <= 10)
                        Normal *= 1.5;
                    else if (EnemyLevel1.Value - PlayerLevel1.Value > 70 && PlayerLevel1.Value <= 10)
                        Normal *= 0.5;

                    Crit = Normal * (1 + float.Parse(CritDMG.Text) / 100);
                    Avg = Normal * (1 + float.Parse(CritRate.Text) * float.Parse(CritDMG.Text) / 10000);

                    //暴击时的伤害修正
                    if (float.Parse(CritRate.Text) == 100)//满暴击时,普通伤害等于暴击伤害
                    {
                        Normal = Crit;
                    }
                    else if (float.Parse(CritRate.Text) == 0)//不暴击时,暴击伤害等于普通伤害
                    {
                        Crit = Normal;
                    }
                }
                else    //剧变反应伤害相关计算
                {
                    check = true;
                    Normal = React * upheaval.Upheaval_Damage(PlayerLevel1.Value) * Resistance;
                    Avg = Normal;
                }
                //免疫相关显示
                if (EnemyRES.Text.Contains("∞"))
                {
                    Normal = 0;
                    Avg = 0;
                    Crit = 0;
                }
                //伤害数值转为文本
                Normal_DMG.Text = Convert.ToString(Normal);
                Crit_DMG.Text = check == true ? "N/A" : Convert.ToString(Crit);
                Avg_DMG.Text = Convert.ToString(Avg);
            }
            catch { }
        }
        //////////计算部分结束///////////
    }
    //剧变反应伤害数值
    //参考：https://bbs.mihoyo.com/ys/article/2215872
    public class Upheaval
    {
        public int Upheaval_Damage(int level)
        {
            switch (level)
            {
                case 1:  return 33; 
                case 2:  return 37; 
                case 3:  return 38; 
                case 4:  return 42; 
                case 5:  return 44; 
                case 6:  return 49; 
                case 7:  return 52; 
                case 8:  return 57; 
                case 9:  return 62; 
                case 10: return 68;
                case 11: return 73;
                case 12: return 81;
                case 13: return 89;
                case 14: return 97;
                case 15: return 107; 
                case 16: return 118; 
                case 17: return 128; 
                case 18: return 139; 
                case 19: return 150; 
                case 20: return 161; 
                case 21: return 172; 
                case 22: return 183; 
                case 23: return 194; 
                case 24: return 206; 
                case 25: return 217; 
                case 26: return 226; 
                case 27: return 236; 
                case 28: return 246; 
                case 29: return 259; 
                case 30: return 272; 
                case 31: return 284; 
                case 32: return 298; 
                case 33: return 310; 
                case 34: return 323; 
                case 35: return 338; 
                case 36: return 352; 
                case 37: return 368; 
                case 38: return 383; 
                case 39: return 399; 
                case 40: return 414; 
                case 41: return 430; 
                case 42: return 448; 
                case 43: return 467; 
                case 44: return 487; 
                case 45: return 511; 
                case 46: return 537; 
                case 47: return 562; 
                case 48: return 590; 
                case 49: return 618; 
                case 50: return 647; 
                case 51: return 673; 
                case 52: return 700; 
                case 53: return 729; 
                case 54: return 757; 
                case 55: return 797; 
                case 56: return 832; 
                case 57: return 868; 
                case 58: return 904; 
                case 59: return 942; 
                case 60: return 980; 
                case 61: return 1019; 
                case 62: return 1064; 
                case 63: return 1112; 
                case 64: return 1160; 
                case 65: return 1216; 
                case 66: return 1260; 
                case 67: return 1306; 
                case 68: return 1350; 
                case 69: return 1394; 
                case 70: return 1440; 
                case 71: return 1484; 
                case 72: return 1530; 
                case 73: return 1568; 
                case 74: return 1607; 
                case 75: return 1661; 
                case 76: return 1708; 
                case 77: return 1754; 
                case 78: return 1800; 
                case 79: return 1847; 
                case 80: return 1892; 
                case 81: return 1937; 
                case 82: return 1981; 
                case 83: return 2027; 
                case 84: return 2072; 
                case 85: return 2132; 
                case 86: return 2179; 
                case 87: return 2229; 
                case 88: return 2282; 
                case 89: return 2343; 
                case 90: return 2406;
                default: return 0;
            }
        }
    }
    //文字说明
    public class Tips
    {

    }
}
