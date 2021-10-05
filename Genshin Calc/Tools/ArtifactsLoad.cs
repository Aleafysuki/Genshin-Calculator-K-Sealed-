using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using Newtonsoft.Json;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;
using DocumentFormat.OpenXml.Office.CustomDocumentInformationPanel;

namespace Genshin_Calc
{
    /// <summary>
    /// 存储每一个圣遗物的信息
    /// </summary>
    public struct Artifacts
    {
        /// <summary>
        /// 圣遗物的名称
        /// </summary>
        public string ArtifactName;
        /// <summary>
        /// 圣遗物的主属性
        /// </summary>
        public string Maintag;
        public double MaintagValue;
        /// <summary>
        /// 圣遗物的副属性
        /// </summary>
        public string[] Subtag;
        public double[] SubtagValue { get; set; }
        /// <summary>
        /// 圣遗物的等级和星级
        /// </summary>
        public int Level, Stars;
        /// <summary>
        /// 圣遗物的文字信息
        /// </summary>
        public string Info;
        /// <summary>
        ///  圣遗物对应的哈希值
        /// </summary>
        public int Hash;
        /// <summary>
        /// 圣遗物的套装名（未经处理）
        /// </summary>
        public string ArtifactSetName;
    }
    public struct SummariedItem
    {
        public string tag;
        public double tagValue;
    }
    public partial class ArtifactsLoad : Form
    {
        public bool ValueChange = false;
        JObject jsonObject;
        string jsonfile = "";   // JSON文件路径
        readonly string[] rawJsonAttributions = {
            "lifeStatic",       "lifePercentage",   "defendStatic",
            "defendPercentage", "attackStatic",     "attackPercentage",
            "elementalMastery", "critical",         "criticalDamage",
            "recharge",         "windBonus",        "thunderBonus",
            "fireBonus",        "iceBonus",         "waterBonus",
            "rockBonus",        "grassBonus",       "physicsBonus"};
        readonly string[] translatedJsonAttributes = {
            "生命值\t",         "生命值\t",         "防御力\t",
            "防御力\t",         "攻击力\t",         "攻击力\t",
            "元素精通\t",       "暴击率\t",         "暴击伤害\t",
            "充能效率\t",       "风伤加成\t",       "雷伤加成\t",
            "火伤加成\t",       "冰伤加成\t",       "水伤加成\t",
            "岩伤加成\t",       "草伤加成\t",       "物伤加成\t"};

        public ArtifactsLoad()
        {
            InitializeComponent();
            jsonfile = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\Genshin Calculator\" + "Artifacts.json";
            JsonFileLocation.Text = jsonfile;
            if(File.Exists(jsonfile)) LoadFile(JsonFileLocation.Text);
        }
        private void LoadFile(string Loc)
        {
            foreach (Control xItem in Controls)
            {
                if (xItem is TextBox && !xItem.Name.Contains("Json"))
                {
                    xItem.Text = "";
                }
            }
            InitializeJson(Loc);
            radioButton1.Checked = true;
            InputButton.Enabled = false;
            for (int i = 1; i <= 5; i++)
            {
                JsonReader(i);
            }
        }
        private Artifacts[] Artifact = new Artifacts[1000];
        private List<Artifacts> List1_Artifact = new List<Artifacts>(1);
        private List<Artifacts> List2_Artifact = new List<Artifacts>(1);
        private List<Artifacts> List3_Artifact = new List<Artifacts>(1);
        private List<Artifacts> List4_Artifact = new List<Artifacts>(1);
        private List<Artifacts> List5_Artifact = new List<Artifacts>(1);
        private Artifacts[] SelectedArtifacts = new Artifacts[5];
        private List<SummariedItem> summariedItems = new List<SummariedItem>(1);
        /// <summary>
        /// 将json文件读取至内存
        /// </summary>
        /// <param name="list">需将圣遗物填写进的对应位置</param>
        /// <param name="p"></param>
        public void JsonReader(int p)
        {
            var ArtifactType = "";
            ListBox list = List_Flower;

            switch (p)
            {                                                                  // 在之前的版本中，类型名分别为：
                case 1: list = List_Flower; ArtifactType = "flower"; break;    // “flower”
                case 2: list = List_Plume; ArtifactType = "feather"; break;    // “plume”
                case 3: list = List_Sands; ArtifactType = "sand"; break;       // “sands”
                case 4: list = List_Goblet; ArtifactType = "cup"; break;       // “goblet”
                case 5: list = List_Circlet; ArtifactType = "head"; break;     // “circlet”
            }
            list.Items.Clear();
            try
            {
                for (int i = 0; i < 1000; i++)
                {
                    var Ap = Artifact[i];
                    Ap.ArtifactName = Readjson(ArtifactType, "detailName", i);
                    if (Ap.ArtifactName == null) break;
                    Ap.Level = Convert.ToInt32(Readjson(ArtifactType, "level", i));
                    Ap.Maintag = Readjson(ArtifactType, "mainTag", i, 0);
                    Ap.MaintagValue = Convert.ToDouble(Readjson(ArtifactType, "mainTag", i, 1));
                    Ap.Stars = Convert.ToInt32(Readjson(ArtifactType, "star", i));
                    Ap.Subtag = new string[4];
                    Ap.SubtagValue = new double[4];
                    Ap.Info
                        = string.Format("(+{0}) (★{1})   {2}", Ap.Level, Ap.Stars, Ap.ArtifactName)
                        + string.Format("\r\n主属性 —————————")
                        + string.Format("\r\n            {0}", Translate(Ap.Maintag, Ap.MaintagValue, 0))
                        + string.Format("\r\n副属性 —————————");
                    Ap.ArtifactSetName = Readjson(ArtifactType, "setName", i);
                    for (int t = 0; t < 4; t++)
                    {
                        Ap.Subtag[t] = Readjson(ArtifactType, "normalTags", i, t + 2);
                        Ap.SubtagValue[t] = Convert.ToDouble(Readjson(ArtifactType, "normalTags", i, t + 6));
                        Ap.Info += string.Format("\r\n            {0}", Translate(Ap.Subtag[t], Ap.SubtagValue[t], 0));
                    }
                    list.Items.Add(string.Format("(+{0}) " + Ap.ArtifactName, Ap.Level));
                    Ap.Hash = list.Items[i].GetHashCode() + i;
                    Artifact[i] = Ap;

                    switch (p)
                    {
                        case 1: List1_Artifact.Add(Ap); break;
                        case 2: List2_Artifact.Add(Ap); break;
                        case 3: List3_Artifact.Add(Ap); break;
                        case 4: List4_Artifact.Add(Ap); break;
                        case 5: List5_Artifact.Add(Ap); break;
                    }
                }
            }
            catch (Exception)
            {
                return;
            }
        }
        #region JSON文件操作
        /// <summary>
        /// 读取JSON文件
        /// </summary>
        /// <param name="jsonfile"></param>
        /// <param name="Mainkey">主key，此处对应圣遗物的类型</param>
        /// <param name="key">文件中的Key值</param>
        /// <param name="i"></param>
        /// <returns>相应Key对应的值</returns>
        public string Readjson(string Mainkey, string key, int i)
        {
            return jsonObject[Mainkey].ToList()[i][key].ToString();//得到11
        }

        /// <summary>
        /// 读取JSON文件
        /// </summary>
        /// <param name="other">附加参数</param>
        /// <param name="Mainkey">主key，此处对应圣遗物的类型</param>
        /// <param name="key">文件中的Key值</param>
        /// <param name="i"></param>
        /// <returns>相应Key对应的值</returns>
        public string Readjson(string Mainkey, string key, int i, int other)
        {
            var addins = "name";
            var addint = 0;
            if (other > 5 && other <= 9)
            {
                other -= 4;
                addins = "value";
            }
            switch (other)
            {
                case 0: addins = "name"; break;
                case 1: addins = "value"; break;
                case 2: addint = 0; break;
                case 3: addint = 1; break;
                case 4: addint = 2; break;
                case 5: addint = 3; break;
            }
            try
            {
                return other < 2 ?
                    jsonObject[Mainkey].ToList()[i][key][addins].ToString() :
                    jsonObject[Mainkey].ToList()[i][key][addint][addins].ToString();
            }
            catch (Exception)
            {
                return null;
            }
        }
        /// <summary>
        /// 初始化json文件的读取
        /// </summary>
        private void InitializeJson(string Location)
        {
            if (File.Exists(Location))
            {
                StreamReader file = File.OpenText(Location);
                JsonTextReader reader = new JsonTextReader(file);
                jsonObject = (JObject)JToken.ReadFrom(reader);
            }
            else if (Location != "")
            {
                MessageBox.Show("Json文件的路径填写有误，或不存在此Json文件。");
            }
            else
            {
                MessageBox.Show("请填写Json文件所在的路径，支持直接拖入Json文件至文本框内。");
            }

        }
        /// <summary>
        /// 对解析到的圣遗物属性进行信息拼接
        /// </summary>
        /// <param name="en">圣遗物的词条名称(json文件中的原名)</param>
        /// <param name="num">对应词条的数值(json文件中未经转换的值)</param>
        /// <param name="sw">切换输出形态</param>
        /// <returns>拼接完成后的信息</returns>
        public string Translate(string en, double num, int sw)
        {
            var textNum = en.Contains("Static") || en.Contains("Mastery") ? num.ToString() : (num * 100).ToString() + "%";
            var matchnum = SearchArray(en, rawJsonAttributions);
            string translated = translatedJsonAttributes[matchnum];
            switch (sw)
            {
                case 0: return translated + "  " + textNum;
                case 1: return en + ":" + num;
                case 2: return translated;
                case 3: return textNum;
                case 4: return translated + '*' + textNum;
                default: return translated;
            }
        }
        public string Translate(string cn, string val)
        {
            var matchnum = SearchArray(cn, translatedJsonAttributes);
            if (val.Contains("%") && matchnum < 6)
            {
                matchnum++;
            }
            string raw = rawJsonAttributions[matchnum];
            return EntriesCalc(raw, val);
        }
        private string EntriesCalc(string tagName, string tagValue)
        {
            var entries = 0f;

            if (tagValue.EndsWith("%")) // 百分比的值
            {
                var TrimedValue = float.Parse(tagValue.TrimEnd('%'));
                switch (tagName)
                {
                    case "lifePercentage": entries = TrimedValue / 5.0f; break;
                    case "defendPercentage": entries = TrimedValue / 6.2f; break;
                    case "attackPercentage": entries = TrimedValue / 5.0f; break;
                    case "critical": entries = TrimedValue / 3.3f; break;
                    case "criticalDamage": entries = TrimedValue / 6.6f; break;
                    case "recharge": entries = TrimedValue / 5.5f; break;
                }
                if (tagName.StartsWith("attack") && WhoTao_Check.Checked)
                {
                    entries *= 0.4f;
                }
            }
            else // 整数值
            {
                var TrimedValue = float.Parse(tagValue);
                switch (tagName)
                {
                    case "lifeStatic":
                        {
                            if (BasicLife.Text.Length < 1)
                            {
                                entries = -1;
                            }
                            else
                            {
                                entries = 20.0f * TrimedValue / float.Parse(BasicLife.Text);
                            }
                            break;
                        }
                    case "defendStatic":
                        {
                            if (BasicDefence.Text.Length < 1)
                            {
                                entries = -1;
                            }
                            else
                            {
                                entries = 100f * TrimedValue / (float.Parse(BasicDefence.Text) * 6.2f);
                            }
                            break;
                        }
                    case "attackStatic":
                        {
                            if (BasicATK_Manual.Text.Length < 1)
                            {
                                entries = -1;
                            }
                            else
                            {
                                entries = 20.0f * TrimedValue / float.Parse(BasicATK_Manual.Text);
                            }
                            break;
                        }
                    case "elementalMastery": entries = TrimedValue / 20f; break;
                }
            }
            if (entries == -1)
            {
                return "---";
            }
            return entries.ToString();
        }
        private int SearchArray(string en, string[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == null) continue;
                if (array[i].Contains(en))
                {
                    return i;
                }
            }
            return array.Length - 1;
        }
        private string SearchArray_IgnoreATKZero(string en, string[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == null) continue;
                if (array[i].Contains(en))
                {
                    //if (en.Contains("攻击") && array[i] != null)
                    //    return outputText[i + 1] == null ? "" : outputText[i + 1].TrimEnd('%');
                    //else
                        return outputText[i].TrimEnd('%');
                }
            }
            return "";
        }

        #endregion

        #region 计算过程
        private bool MainTagConsidered = true;
        /// <summary>
        /// 将选定的五个圣遗物进行汇总
        /// </summary>
        private void Summary()
        {
            bool[] chk = new bool[ResultList.Items.Count];
            
            for (int k = 0; k < ResultList.Items.Count; k++)
            {
                chk[k] = ResultList.Items[k].Checked;
            }
            ResultList.Items.Clear();
            {
                SummariedItem item = new SummariedItem();
                for (int i = 0; i < 5; i++)
                {
                    if (SelectedArtifacts[i].ArtifactName != null)
                    {
                        if (MainTagConsidered)
                        {
                            item.tag = SelectedArtifacts[i].Maintag;
                            item.tagValue = SelectedArtifacts[i].MaintagValue;
                            AddItem(item);
                        }
                        for (int t = 0; t < SelectedArtifacts[i].Subtag.Length; t++)
                        {
                            item.tag = SelectedArtifacts[i].Subtag[t];
                            item.tagValue = SelectedArtifacts[i].SubtagValue[t];
                            AddItem(item);
                        }
                    }
                }
            }
            int chklength = chk.Length < ResultList.Items.Count ? chk.Length : ResultList.Items.Count;
            for (int k = 0; k < chklength; k++)
            {
                if (chk.Length < 1)
                {
                    ResultList.Items[k].Checked = false;
                }
                else
                {
                    ResultList.Items[k].Checked = chk[k];
                }
            }
            EntriesCalc();
        }
        /// <summary>
        /// 向列表中添加所选圣遗物的属性
        /// </summary>
        /// <param name="it">被选中的圣遗物tag</param>
        private void AddItem(SummariedItem it)
        {
            // 遍历整个列表，若tag和已存在的tag重复，则进行下面的操作。
            //      若tag的对应值和所重复的tag的对应值类型一致，则进行下面的操作。
            //          将这两个对应值相加，输出为新的tag对应值。
            // 否则直接输出tag及其对应值。
            summariedItems.Add(it);
            var splited = Translate(it.tag, it.tagValue, 4).Split('*');
            ListViewItem TempItem = new ListViewItem(new string[] { splited[0], splited[1], "" });
            var flag = false;
            for (int i = 0; i < ResultList.Items.Count; i++)
            {
                var item = ResultList.Items[i];
                TempItem = new ListViewItem(new string[] { splited[0], splited[1], Translate(ResultList.Items[i].SubItems[0].Text, ResultList.Items[i].SubItems[1].Text) });
                if (item.Text == TempItem.Text)
                {
                    if (item.SubItems[1].Text.Contains("%") == TempItem.SubItems[1].Text.Contains("%"))
                    {
                        var NewValue =
                              Convert.ToDouble(item.SubItems[1].Text.TrimEnd('%').TrimEnd(' '))
                            + Convert.ToDouble(TempItem.SubItems[1].Text.TrimEnd('%').TrimEnd(' '));
                        item.SubItems[1].Text = NewValue.ToString();
                        if (TempItem.SubItems[1].Text.Contains("%")) item.SubItems[1].Text += "%";
                        flag = true;
                    }
                    else
                    {
                        flag = false;
                    }
                }
                else
                {
                    flag = false;
                }
                if (flag) break;
            }
            if (!flag)
            {
                ResultList.Items.Add(TempItem);
            }

        }
        /// <summary>
        /// 计算词条数
        /// </summary>
        private void EntriesCalc()
        {
            for (int i = 0; i < ResultList.Items.Count; i++)
            {
                string item2Text = Translate(ResultList.Items[i].SubItems[0].Text, ResultList.Items[i].SubItems[1].Text);
                if (item2Text.Contains("--"))
                {
                    ResultList.Items[i].SubItems[2].Text = "---";
                }
                else
                {
                    ResultList.Items[i].SubItems[2].Text = string.Format("{0:N2}", float.Parse(item2Text));
                }
            }
            var SummarizedEntries = 0f;
            for (int i = 0; i < ResultList.Items.Count; i++)
            {
                if (ResultList.Items[i].Checked)
                {
                    if (!ResultList.Items[i].SubItems[2].Text.Contains("--") && ResultList.Items[i].SubItems[2].Text.Length > 0)
                    {
                        SummarizedEntries += float.Parse(ResultList.Items[i].SubItems[2].Text);
                    }
                }
            }
            TotalEntriesCount.Text = "选中的总词条数：" + SummarizedEntries.ToString();
        }
        string[] outputText = new string[10];
        string[] outtipText = new string[10];
        /// <summary>
        /// 将结果导出到主窗口
        /// </summary>
        private void Pushout()
        {
            float atk = 0;// float.Parse(BasicATK_Manual.Text);
            for (int k = 0; k < ResultList.Items.Count; k++)
            {
                if (new string[] { "防御力\t","充能效率\t","生命值\t"}.Contains(ResultList.Items[k].Text))
                {
                    continue;
                }
                outputText[k] = ResultList.Items[k].SubItems[1].Text;
                if (ResultList.Items[k].Text.Contains("伤加成"))
                {
                    outtipText[k] = "属性伤害加成" + "\t" + ResultList.Items[k].SubItems[1].Text;
                }
                else
                {
                    if (ResultList.Items[k].Text != "攻击力\t")
                    {
                        outtipText[k] = ResultList.Items[k].Text + "\t" + outputText[k];
                    }
                    else
                    {
                        if (ResultList.Items[k].SubItems[1].Text.Contains("%"))
                        {
                            atk += float.Parse(BasicATK_Manual.Text) * float.Parse(ResultList.Items[k].SubItems[1].Text.TrimEnd('%')) / 100;
                        }
                        else
                        {
                            atk += float.Parse(ResultList.Items[k].SubItems[1].Text);
                        }
                        if (k < ResultList.Items.Count-1)
                        {
                            if (ResultList.Items[k + 1].Text.Contains("攻击"))
                            {
                                continue;
                            }

                        }
                        outputText[k] = atk.ToString();
                        outtipText[k] = ResultList.Items[k].Text + "\t" + outputText[k];

                    }
                }
            }
            string outputInfo="即将向主窗口填入以下属性值:\n";
            for (int i = 0; i < outtipText.Length; i++)
            {
                if (outtipText[i] != null)
                {
                    if (outputText[i].Contains("攻击") && outputText[i + 1].Contains("攻击")) continue;
                    else outputInfo += string.Format("\t\t{0}\n", outtipText[i]);
                }
            }
            DialogResult Tip = MessageBox.Show(outputInfo + "注意！由于各圣遗物的套装效果触发情况不一，请在主窗口手动填入【圣遗物套装效果】与【武器属性特效】。", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.None);
            if (Tip == DialogResult.Yes)
            {
                ValueChange = true;
                Close();
            }
            else
            {
                outtipText = new string[10];
                outputText = new string[10];
            }
        }
        public string[] Output()
        {
            var Prt = new string[7];
            Prt[6] = "";
            Prt[0] = BasicATK_Manual.Text;
            Prt[1] = SearchArray_IgnoreATKZero("攻击力\t", outtipText);
            Prt[2] = (float.Parse(SearchArray_IgnoreATKZero("暴击率\t", outtipText))+5).ToString();
            Prt[3] = (float.Parse(SearchArray_IgnoreATKZero("暴击伤害\t", outtipText)) + 50).ToString();
            Prt[4] = SearchArray_IgnoreATKZero("加成", outtipText);
            Prt[5] = SearchArray_IgnoreATKZero("元素精通\t", outtipText);
            return Prt;
        }
        #endregion

        #region 点击事件的处理
        private void OpenFileButton_Click(object sender, EventArgs e)
        {
            if(File.Exists(JsonFileLocation.Text))LoadFile(JsonFileLocation.Text);
        }
        private void SelectFileButton_Click(object sender, EventArgs e)
        {
            SelectJsonFile.ShowDialog();
            try
            {
                JsonFileLocation.Text = SelectJsonFile.FileName;
                LoadFile(SelectJsonFile.FileName);
            }
            catch(Exception Exc)
            {
                MessageBox.Show("文件读取失败。\n" + Exc);
            }
        }
        private void JsonFileLocation_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.All;
            else
                e.Effect = DragDropEffects.None;
            JsonFileLocation.Text = ((Array)e.Data.GetData(DataFormats.FileDrop)).GetValue(0).ToString();
        }
        private void ListClick_1(object sender, EventArgs e)
        {
            SetText(List_Flower, FlowerPreview);
        }
        private void ListClick_2(object sender, EventArgs e)
        {
            SetText(List_Plume, PlumePreview);
        }
        private void ListClick_3(object sender, EventArgs e)
        {
            SetText(List_Sands, SandsPreview);
        }
        private void ListClick_4(object sender, EventArgs e)
        {
            SetText(List_Goblet, GobletPreview);
        }
        private void ListClick_5(object sender, EventArgs e)
        {
            SetText(List_Circlet, CircletPreview);
        }
        private void SetText(ListBox list, TextBox txt)
        {
            switch (list.Name)
            {
                case "List_Flower":
                    {
                        txt.Text = List1_Artifact[list.SelectedIndex].Info;
                        SelectedArtifacts[0] = List1_Artifact[list.SelectedIndex];
                        break;
                    }
                case "List_Plume":
                    {
                        txt.Text = List2_Artifact[list.SelectedIndex].Info;
                        SelectedArtifacts[1] = List2_Artifact[list.SelectedIndex];
                        break;
                    }
                case "List_Sands":
                    {
                        txt.Text = List3_Artifact[list.SelectedIndex].Info;
                        SelectedArtifacts[2] = List3_Artifact[list.SelectedIndex];
                        break;
                    }
                case "List_Goblet":
                    {
                        txt.Text = List4_Artifact[list.SelectedIndex].Info;
                        SelectedArtifacts[3] = List4_Artifact[list.SelectedIndex];
                        break;
                    }
                case "List_Circlet":
                    {
                        txt.Text = List5_Artifact[list.SelectedIndex].Info;
                        SelectedArtifacts[4] = List5_Artifact[list.SelectedIndex];
                        break;
                    }
            }
            Summary();
            ResultList.Columns[2].Width = -2;
        }
        private void BasicATK_Auto_Click(object sender, EventArgs e)
        {
            Characters_Weapons cw = new Characters_Weapons();
            try
            {
                cw.ShowDialog();
                if (cw.Output() != -1)
                {
                    radioButton2.Checked = true;
                    BasicATK_Manual.Text = cw.Output().ToString();
                }
            }
            catch (NullReferenceException)
            {
                _ = MessageBox.Show("文件似乎正在被占用。\n请关闭相应的表格文件后重试。", "提示");
            }
            catch (ObjectDisposedException)
            {

            }
        }

        private void InputMethodSelection(object sender, EventArgs e)
        {
            BasicATK_Auto.Enabled = radioButton1.Checked;
            BasicATK_Manual.Enabled = radioButton2.Checked;
        }

        private void BasicATK_Manual_TextChanged(object sender, EventArgs e)
        {
            InputButton.Enabled = BasicATK_Manual.Text.Length > 0;
            Summary();
        }


        private void IgnoreMainTags_CheckedChanged(object sender, EventArgs e)
        {
            MainTagConsidered = !IgnoreMainTags.Checked;
            Summary();
        }
        /// <summary>
        /// 计算选中的词条数
        /// </summary>
        private void EntriesSum(object sender, ItemCheckedEventArgs e)
        {
            EntriesCalc();
        }
        private void InputButton_Click(object sender, EventArgs e)
        {
            bool IMTchecked = false;
            if (IgnoreMainTags.Checked)
            {
                IgnoreMainTags.Checked = false;
                IMTchecked = true;
            }
            Pushout();
            if (IMTchecked)
            {
                IgnoreMainTags.Checked = true;
            }
        }




        #endregion

        private void JsonFileLocation_Leave(object sender, EventArgs e)
        {
            JsonFileLocation.Text = jsonfile;
        }
    }
}
