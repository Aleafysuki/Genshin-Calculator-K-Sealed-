using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Genshin_Calc
{
    //对预设进行调整
    //预设包括数值和个性化
    public partial class Settings : Form
    {
        //double ATK_Basic, ATK_Plus;
        //double Crit_Rate, Crit_Damage;
        //double DamageBuff;
        //double Skill;
        //double Res, Defence;
        //int Elemental_Mastery;
        string ConfigPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\Genshin Calculator\";
        public Settings()
        {
            InitializeComponent();
            SaveButton.Enabled = false;
        } 
        XmlDocument Config = new XmlDocument();
        XmlElement ATK1;
        XmlElement ATK2;
        XmlElement Crit;
        XmlElement ElemBuff;
        XmlElement Skill;
        XmlElement RESM;
        XmlElement RESX;
        XmlElement EM;
        XmlElement Reaction;
        XmlElement Other;

        XmlElement MAX;
        XmlElement DFT;

        XmlDeclaration ConfigHeading;
        XmlElement valuesettings;
        public void ConfigWrite()
        {
            ConfigHeading = Config.CreateXmlDeclaration("1.0", "UTF-8", "");
            Config.AppendChild(ConfigHeading);
            //根节点：valuesettingssettings
            valuesettings = Config.CreateElement("valuesettings");
            Config.AppendChild(valuesettings);
            //子节点：各种元素
            //1.数值2.个性化设置(搁置)
            ATK1 = Config.CreateElement("ATK1");
            ATK2 = Config.CreateElement("ATK2");
            Crit = Config.CreateElement("Crit");
            ElemBuff = Config.CreateElement("ElemBuff");
            Skill = Config.CreateElement("Skill");
            RESM = Config.CreateElement("RESM");
            RESX = Config.CreateElement("RESX");
            EM = Config.CreateElement("EM");
            Reaction = Config.CreateElement("Reaction");
            Other = Config.CreateElement("Other");
            //
            Max_W(valuesettings, ATK1       );
            Max_W(valuesettings, ATK2       );
            Max_W(valuesettings, Crit       );
            Max_W(valuesettings, ElemBuff   );
            Max_W(valuesettings, Skill      );
            Max_W(valuesettings, RESM       );
            Max_W(valuesettings, RESX       );
            Max_W(valuesettings, EM         );
            Max_W(valuesettings, Reaction   );
            Max_W(valuesettings, Other      );
            if (!Directory.Exists(ConfigPath))
            {
                Directory.CreateDirectory(ConfigPath);
            }
            Config.Save(ConfigPath + "Configuration.Config");
        }
        public void Input(int ATK1, int ATK2, int Crit, int ElemBuff, int Skill, int RESM, int RESX, int EM, int Reaction, int Other)
        {
            ATK1_MAX.Text       =Convert.ToString(ATK1          );
            ATK2_MAX.Text       =Convert.ToString(ATK2          );
            Crit_MAX.Text       =Convert.ToString(Crit    /10   );
            ElemBuff_MAX.Text   =Convert.ToString(ElemBuff/10   );
            Skill_MAX.Text      =Convert.ToString(Skill   /10   );
            RESM_MAX.Text       =Convert.ToString(RESM    /10   );
            RESX_MAX.Text       =Convert.ToString(RESX    /10   );
            EM_MAX.Text         =Convert.ToString(EM            );
            Reaction_MAX.Text   =Convert.ToString(Reaction/10   );
            Other_MAX.Text      =Convert.ToString(Other   /10   );
            ATK1_DFT.Text =      (Output(0,"DFT")   ).ToString();
            ATK2_DFT.Text =      (Output(1,"DFT")   ).ToString();
            Crit_DFT.Text =      (Output(2,"DFT")/10).ToString();
            ElemBuff_DFT.Text =  (Output(3,"DFT")/10).ToString();
            Skill_DFT.Text =     (Output(4,"DFT")/10).ToString();
            RESM_DFT.Text =      (Output(5,"DFT")/10).ToString();
            EM_DFT.Text =        (Output(7,"DFT")   ).ToString();
            Reaction_DFT.Text =  (Output(8,"DFT")/10).ToString();
            Other_DFT.Text =     (Output(9,"DFT")/10).ToString();
            Label_SaveTip.Visible = false;
            SaveButton.Enabled = false;
        }
        public double Output(int i,string attr)
        {
            Config.Load(ConfigPath + "Configuration.Config");
            XmlNode x;
            double pst;
            switch (i)
            {
                case 0 : x=Config.SelectSingleNode("/valuesettings/ATK1/" + attr);     pst=    Convert.ToDouble(x.InnerXml); break;//ATK1
                case 1 : x=Config.SelectSingleNode("/valuesettings/ATK2/" + attr);     pst=    Convert.ToDouble(x.InnerXml); break;//ATK2
                case 2 : x=Config.SelectSingleNode("/valuesettings/Crit/" + attr);     pst= 10*Convert.ToDouble(x.InnerXml); break;//Crit
                case 3 : x=Config.SelectSingleNode("/valuesettings/ElemBuff/" + attr); pst= 10*Convert.ToDouble(x.InnerXml); break;//ElemBuff
                case 4 : x=Config.SelectSingleNode("/valuesettings/Skill/" + attr);    pst= 10*Convert.ToDouble(x.InnerXml); break;//Skill
                case 5 : x=Config.SelectSingleNode("/valuesettings/RESM/" + attr);     pst= 10*Convert.ToDouble(x.InnerXml); break;//RESM
                case 6 : x=Config.SelectSingleNode("/valuesettings/RESX/" + attr);     pst= 10*Convert.ToDouble(x.InnerXml); break;//RESX
                case 7 : x=Config.SelectSingleNode("/valuesettings/EM/" + attr);       pst=    Convert.ToDouble(x.InnerXml); break;//EM
                case 8 : x=Config.SelectSingleNode("/valuesettings/Reaction/" + attr); pst= 10*Convert.ToDouble(x.InnerXml); break;//Reaction
                case 9 : x=Config.SelectSingleNode("/valuesettings/Other/" + attr);    pst= 10*Convert.ToDouble(x.InnerXml); break;//Other
                default:return 0;
            }
            return pst;
        }
        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (!File.Exists(ConfigPath + "Configuration.Config"))
            {
                ConfigWrite();
            }
            else
            {
                File.Delete(ConfigPath + "Configuration.Config");
                Config.RemoveAll();
                ConfigWrite();
            }
            Label_SaveTip.Text = "已成功保存数据改动";
            SaveButton.Enabled = false;
            ExitButton.Text = "关闭";
            Form1 f = new Form1();
            f.SettingsChange(true);
        }

        private void Max_W(XmlElement SETTINGS, XmlElement Element)//最大、最小、默认值
        {
            if (!Element.HasChildNodes)
            {
                SETTINGS.AppendChild(Element);
                MAX = Config.CreateElement("MAX");//MAX-最大值
                DFT = Config.CreateElement("DFT");//DFT-默认值
                //各项属性的最大、最小、默认值
                Element.AppendChild(MAX);
                Element.AppendChild(DFT);
            }
            MAX.InnerText = BoxReading(Element, MAX);
            DFT.InnerText = BoxReading(Element, DFT);
        }
        private string BoxReading(XmlElement Element, XmlElement sub)
        {
            var MX = sub.Name == "MAX";
            switch (Element.Name)
            {
                case "ATK1": return MX ?     ATK1_MAX.Text       : ATK1_DFT.Text;
                case "ATK2": return MX ?     ATK2_MAX.Text       : ATK2_DFT.Text;
                case "Crit": return MX ?     Crit_MAX.Text       : Crit_DFT.Text;
                case "ElemBuff": return MX ? ElemBuff_MAX.Text   : ElemBuff_DFT.Text;
                case "Skill": return MX ?    Skill_MAX.Text      : Skill_DFT.Text;
                case "RESM": return MX ?     RESM_MAX.Text       : RESM_DFT.Text;
                case "RESX": return MX ?     RESX_MAX.Text       : RESM_DFT.Text;
                case "EM": return MX ?       EM_MAX.Text         : EM_DFT.Text;
                case "Reaction": return MX ? Reaction_MAX.Text   : Reaction_DFT.Text;
                case "Other": return MX ?    Other_MAX.Text      : Other_DFT.Text;
                default: return null;
            }
        }

        private void Textchanged(object sender, EventArgs e)
        {

                Label_SaveTip.Visible = true;
                SaveButton.Enabled = true;
            
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            if (Label_SaveTip.Text == "已成功保存数据改动")
            {
                f.SettingsChange(false);
            }
            else
            {
                f.SettingsChange(true);
            }
            Close();
        }
    }
    //数值的调整
    //数值包括以下几个方面 
    //攻击（基础+加成）      ATK_Basic;ATK_Plus
    //暴击率与暴击伤害       Crit_Rate;Crit_Damage
    //属性伤害加成          DamageBuff
    //技能倍率             Skill
    //抗性和防御的调整       Res;Defence
    //元素精通             Elemental_Mastery
    public class ValueSettings
    { 
    }
    //个性化的调整
    //包括以下几个方面
    //颜色（做对话框）
    //字体选择（有下载缺失字体的提示）
    public class CustomSettings
    { 
    }
}


















