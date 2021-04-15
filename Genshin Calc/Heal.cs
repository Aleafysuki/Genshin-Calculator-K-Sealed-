using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Genshin_Calc
{
    public partial class Heal : Form
    {
        ////////变量存储////////
        //整型：基础计算值（Basic,攻击/防御/血量等）、元素精通（EM,影响结晶盾的厚度）、固定值(HealPlus&ShieldPlus)、角色等级(Level)
        int Basic, EM, HealPlus, ShieldPlus, Level = 1;
        //浮点型：治疗与护盾倍率(HealSkill, ShieldSkill)、治疗加成与护盾强效(HealBuff, ShieldBuff)、角色的受治疗加成(BeHealed)
        float HealSkill = 1, ShieldSkill = 1, HealBuff = 1, ShieldBuff = 1, BeHealed = 1;
        //计算结果：单次奶量(HealResult)、盾量（对应属性(ShieldResult1)和其他属性(ShieldResult2)）
        float HealResult, ShieldResult1, ShieldResult2;
        //以下是具体的处理与运算//
        public Heal()
        {
            InitializeComponent();
            Shield_Type.SelectedIndex = 1;
            HealerCalc();
        }
        public float ShieldByLevel()//结晶盾基础值计算
        {
            Crystallized_Shield LevelShield = new Crystallized_Shield();
            return LevelShield.Crystallize(Level);
        }
        public void HealerCalc()//主计算代码
        {
            //治疗计算
            HealResult = (Basic * HealSkill + HealPlus) * HealBuff * BeHealed;
            if (Shield_Type.SelectedIndex == 0)//岩盾计算
            {
                if (Shield_Result_Type2.Checked)//技能盾计算
                {
                    ShieldResult2 = (float)1.5 * (Basic * ShieldSkill + ShieldPlus) * ShieldBuff;
                    ShieldResult1 = ShieldResult2;
                    CalcDisplay();
                }
                else
                {
                    ShieldError();
                }
            }
            else//其他元素盾的计算
            {
                if (Shield_Result_Type1.Checked)//结晶盾计算
                {
                    ShieldResult2 = ShieldByLevel() * (1 + (float)4.448 * EM / (1400 + EM));
                }
                else if (Shield_Result_Type2.Checked)//技能盾计算
                {
                    ShieldResult2 = (Basic * ShieldSkill + ShieldPlus) * ShieldBuff;
                }
                ShieldResult1 = (float)2.5 * ShieldResult2;
                CalcDisplay();
            }

        }
        private void ShieldError()
        {
            Shield_Result_1.Text = "----";
            Shield_Result_2.Text = "----";
        }
        private void CalcDisplay()
        {
            Heal_Result_1.Text = Convert.ToString(HealResult);
            if (Level < 1 || Level > 90)
            {
                ShieldError();
            }
            else
            {
                Shield_Result_1.Text = Convert.ToString(ShieldResult1);
                Shield_Result_2.Text = Convert.ToString(ShieldResult2);
            }
        }
        private Font FontBoldChange(Font TextFont)//切换字体的粗体状态
        {
            return TextFont.Bold ?
                new Font(TextFont.FontFamily, TextFont.Size, FontStyle.Regular) :
                new Font(TextFont.FontFamily, TextFont.Size, FontStyle.Bold);
        }
        public void ShieldTypeChange(RadioButton Buttonname)//按动按钮后着重显示已被选择的内容
        {
            Buttonname.Font = FontBoldChange(Buttonname.Font);
            if (Buttonname.Checked)
            {
                Buttonname.ForeColor = SystemColors.ActiveCaptionText;
            }
            else
            {
                Buttonname.ForeColor = SystemColors.ControlDark;
            }
        }
        /// <summary>
        /// 需要进行计算的场合
        /// </summary>
        private void Shield_Result_Type1_CheckedChanged(object sender, EventArgs e)
        {
            ShieldTypeChange(Shield_Result_Type1);
            HealerCalc();
        }
        private void Shield_Result_Type2_CheckedChanged(object sender, EventArgs e)
        {
            ShieldTypeChange(Shield_Result_Type2);
            HealerCalc();
        }
        private void Calculate_Basic_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Basic = Convert.ToInt32(Calculate_Basic.Text);
            }
            catch (Exception) { }
            HealerCalc();
        }
        private void Elemental_Mastery_TextChanged(object sender, EventArgs e)
        {
            try
            {
                EM = Convert.ToInt32(Elemental_Mastery.Text);
            }
            catch (Exception) { }
            HealerCalc();
        }
        private void Level_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Level = Convert.ToInt32(Player_Level.Text);
            }
            catch (Exception) { }
            HealerCalc();
        }
        private void Heal_Skill_TextChanged(object sender, EventArgs e)
        {
            try
            {
                HealSkill = float.Parse(Heal_Skill.Text) / 100;
            }
            catch (Exception) { }
            HealerCalc();
        }
        private void Shield_Skill_TextChanged(object sender, EventArgs e)
        {
            try
            {
                ShieldSkill = float.Parse(Shield_Skill.Text) / 100;
            }
            catch (Exception) { }
            HealerCalc();
        }
        private void Heal_P_TextChanged(object sender, EventArgs e)
        {
            try
            {
                HealPlus = Convert.ToInt32(Heal_P.Text);
            }
            catch (Exception) { }
            HealerCalc();
        }
        private void Shield_P_TextChanged(object sender, EventArgs e)
        {
            try
            {
                ShieldPlus = Convert.ToInt32(Shield_P.Text);
            }
            catch (Exception) { }
            HealerCalc();
        }
        private void Shield_Plus_TextChanged(object sender, EventArgs e)
        {
            try
            {
                ShieldBuff = 1 + float.Parse(Shield_Plus.Text) / 100;
            }
            catch (Exception) { }
            HealerCalc();
        }
        private void Heal_Plus_TextChanged(object sender, EventArgs e)
        {
            try
            {
                HealBuff = 1 + float.Parse(Heal_Plus.Text) / 100;
            }
            catch (Exception) { }
            HealerCalc();
        }
        private void ByHealed_Plus_TextChanged(object sender, EventArgs e)
        {
            try
            {
                BeHealed = 1 + float.Parse(ByHealed_Plus.Text) / 100;
            }
            catch (Exception) { }
            HealerCalc();
        }
        private void Shield_Type_SelectedIndexChanged(object sender, EventArgs e)
        {
            HealerCalc();
        }
    }
    public class Crystallized_Shield//结晶反应护盾数值
    {
        public int Crystallize(int PlayerLevel)
        {
            switch (PlayerLevel)
            {
                case 1: return 91;
                case 2: return 99;
                case 3: return 106;
                case 4: return 114;
                case 5: return 121;
                case 6: return 129;
                case 7: return 136;
                case 8: return 144;
                case 9: return 151;
                case 10: return 159;
                case 11: return 170;
                case 12: return 181;
                case 13: return 192;
                case 14: return 204;
                case 15: return 216;
                case 16: return 228;
                case 17: return 248;
                case 18: return 268;
                case 19: return 287;
                case 20: return 304;
                case 21: return 320;
                case 22: return 337;
                case 23: return 352;
                case 24: return 368;
                case 25: return 384;
                case 26: return 394;
                case 27: return 405;
                case 28: return 416;
                case 29: return 427;
                case 30: return 438;
                case 31: return 448;
                case 32: return 459;
                case 33: return 470;
                case 34: return 481;
                case 35: return 490;
                case 36: return 499;
                case 37: return 513;
                case 38: return 529;
                case 39: return 544;
                case 40: return 557;
                case 41: return 574;
                case 42: return 591;
                case 43: return 607;
                case 44: return 622;
                case 45: return 638;
                case 46: return 649;
                case 47: return 667;
                case 48: return 684;
                case 49: return 702;
                case 50: return 715;
                case 51: return 733;
                case 52: return 750;
                case 53: return 767;
                case 54: return 784;
                case 55: return 800;
                case 56: return 814;
                case 57: return 834;
                case 58: return 855;
                case 59: return 876;
                case 60: return 896;
                case 61: return 915;
                case 62: return 936;
                case 63: return 956;
                case 64: return 982;
                case 65: return 1003;
                case 66: return 1017;
                case 67: return 1036;
                case 68: return 1057;
                case 69: return 1075;
                case 70: return 1096;
                case 71: return 1114;
                case 72: return 1135;
                case 73: return 1149;
                case 74: return 1170;
                case 75: return 1191;
                case 76: return 1205;
                case 77: return 1224;
                case 78: return 1243;
                case 79: return 1260;
                case 80: return 1277;
                case 81: return 1293;
                case 82: return 1308;
                case 83: return 1317;
                case 84: return 1327;
                case 85: return 1336;
                case 86: return 1349;
                case 87: return 1366;
                case 88: return 1384;
                case 89: return 1403;
                case 90: return 1424;
                default: return 0;
            }
        }

    }
}
