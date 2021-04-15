using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Genshin_Calc;

namespace Genshin_Calc
{
    public partial class Form1 : Form
    {
        bool Saved = false, check = false, DEFAdded = false;
        int ATKBuffer ;
        double Normal = 0, Crit = 0, Avg = 0;
        double Resistance = 1;
        double React = 1, rp = 1;
        private void Form1_Load(object sender, EventArgs e)
        {
        }
        public Form1()
        {
            InitializeComponent();
            Calculate();
        }
        //SaveFileDialog ctrl_s = null;
        public void save()
        {
            SaveFileDialog ctrl_s = new SaveFileDialog
            {
                Title = "保存预设",
                Filter = "预设文档(*.calo)|*.calo"
            };
        }
        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Saved == false)
            {
                DialogResult Exit;  //Exit:退出前的保存提示
                Exit = MessageBox.Show("有尚未保存的项目，是否保存它？", "提示", MessageBoxButtons.YesNoCancel);
                if (Exit == DialogResult.Yes)               //保存
                {
                    SaveFileDialog ctrl_s = new SaveFileDialog
                    {
                        Title = "保存预设",
                        Filter = "预设文档(*.calo)|*.calo"
                    };
                }
                else if (Exit == DialogResult.No)           //退出
                    Environment.Exit(0);
                else if (Exit == DialogResult.Cancel)       //返回
                    Saved = false;//
            }
        }
        private void 数值上下限设置ToolStripMenuItem_Click(object sender, EventArgs e)
        {

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
            EnemyRES.Text = Convert.ToString(Convert.ToDouble(EnemyRES1.Value) / 10 - 100);
            RESCalc();
        }
        private void EnemyRES_TextChanged(object sender, EventArgs e)
        {
            try
            {
                EnemyRES1.Value = Convert.ToInt32(Convert.ToDouble(EnemyRES.Text) * 10 + 1000);
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
        //窗口暂时透明化//
        private void TransButton_MouseDown(object sender, MouseEventArgs e)
        {
            Opacity = 0.07;
        }
        private void TransButton_MouseUp(object sender, MouseEventArgs e)
        {
            Opacity = 1;
        }

        private void 关于ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form About = new Form();
            //About.
            About.ShowDialog();
        }

        ////////////计算过程////////////
        Upheaval upheaval = new Upheaval();
        public void Calculate()
        {
            React = 1 + ((float)rp / (1 + 1400 / (float)EM1.Value) + ReactBuff1.Value / 1000);
            //反应伤害相关计算
            switch (Reaction_Choose.SelectedIndex)
            {
                case 0: rp = 0;     React = 1;      break;//无反应
                case 1: rp = 6.66;  React *= 0.25;  break;//超导
                case 2: rp = 6.66;  React *= 0.3;   break;//扩散
                case 3: rp = 6.66;  React *= 0.6;   break;//感电
                case 4: rp = 6.66;  React *= 0.75;  break;//碎冰
                case 5: rp = 6.66;  React *= 1;     break;//超载
                case 6: rp = 2.78;  React *= 1.5;   break;//1.5倍增幅
                case 7: rp = 2.78;  React *= 2;     break;//2.0倍增幅
                default:Reaction_Choose.Text = "不触发反应";break;
            }
            try
            {
                if (Reaction_Choose.SelectedIndex >= 6 || Reaction_Choose.SelectedIndex == 0)
                {
                    //基础、增幅伤害相关计算
                    check = false;
                    Normal = (ATK1.Value + ATKPlus1.Value //攻击力
                    + ATKBuff1.Value + (float.Parse(ATKBuff_P.Text) / 100 * ATK1.Value)//攻击力加成
                    + float.Parse(ATKBuff_S.Text) / 100 * ATK1.Value * ATKBuff1_Sf.Value//攻击力加成(层数)
                    )
                    * (100 + float.Parse(EP.Text) //元素伤害
                    + float.Parse(DMGBuff.Text)//伤害提升
                    + float.Parse(DMGBuff_S.Text) * DMGBuff1_Sf.Value//伤害提升(层数)
                    ) / 100
                    * React//元素精通计算
                    * ((PlayerLevel1.Value + 100)//防御计算
                    / (PlayerLevel1.Value + 100 + (1 + float.Parse(Defense.Text) / 100) * (EnemyLevel1.Value + 100)))
                    * Resistance//抗性计算
                    * float.Parse(Skill.Text) / 100//技能倍率计算
                    * float.Parse(Other.Text) / 100;//其他乘区计算
                    if (Normal < 0)
                    {
                        Normal = 0;
                        Crit = 0;
                        Avg = 0;
                    }//不出现负值
                    //等级压制计算
                    //参考：https://bbs.nga.cn/read.php?tid=24358389
                    if (PlayerLevel1.Value - EnemyLevel1.Value > 70 && EnemyLevel1.Value <= 10)
                    {
                        Normal *= 1.5;
                        Crit = Normal * (1 + float.Parse(CritDMG.Text) / 100);
                        Avg = Normal * float.Parse(CritRate.Text) * (float.Parse(CritDMG.Text) + 100) / 10000
                                + Normal * (1 - float.Parse(CritRate.Text) / 100);
                    }
                    else if (EnemyLevel1.Value - PlayerLevel1.Value > 70 && PlayerLevel1.Value < 10)
                    {
                        Normal *= 0.5;
                        Crit = Normal * (1 + float.Parse(CritDMG.Text) / 100);
                        Avg = Normal * float.Parse(CritRate.Text) * (float.Parse(CritDMG.Text) + 100) / 10000
                                + Normal * (1 - float.Parse(CritRate.Text) / 100);
                    }
                    Crit = Normal * (1 + float.Parse(CritDMG.Text) / 100);
                    Avg = Normal * float.Parse(CritRate.Text) * (float.Parse(CritDMG.Text) + 100) / 10000
                        + Normal * (1 - float.Parse(CritRate.Text) / 100);
                    //暴击时的伤害修正
                    if (float.Parse(CritRate.Text) == 100)//满暴击时,普通伤害等于暴击伤害
                    {
                        Normal = Crit;
                    }
                    else if (float.Parse(CritRate.Text) == 0)//满暴击时,暴击伤害等于普通伤害
                    {
                        Crit = Normal;
                    }
                }
                else
                {//反应伤害相关计算
                    check = true;
                    Normal = React * upheaval.Upheaval_Damage(PlayerLevel1.Value) * Resistance;
                    Avg = Normal;
                }
                //伤害数值转为文本
                Normal_DMG.Text = Convert.ToString(Normal);
                Crit_DMG.Text = check == true ? "N/A" : Convert.ToString(Crit);
                Avg_DMG.Text = Convert.ToString(Avg);
            }
            catch
            {            }
        }
        //////////计算部分结束///////////
        //窗口置顶开关//
        private void 窗口置顶ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (TopMost == true)
            {
                TopMost = false;
            }
            else
                TopMost = true;
            Calculate();
        }
        //工具箱//
        private void DEFCalculate()
        {
            ATKBuffer = DEFAdded == false ? ATKBuff1.Value :  Convert.ToInt32(ATKBuff.Text);
        }
        private void 防御转攻击计算ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DEFAdded = true;
            Tools DEFCheck = new Tools();
            ATKBuff1.Value = ATKBuffer + (int)DEFCheck.Defense();

            Calculate();
            ATKBuff.Text = ATKBuff1.Value.ToString();

        }
    }
    //剧变反应伤害数值
    //参考：https://bbs.mihoyo.com/ys/article/2215872
    public class Upheaval
    {
        int UpheavelDMG = 0;
        public int Upheaval_Damage(int level)
        {
            switch (level)
            {
                case 1: UpheavelDMG = 33; break;
                case 2: UpheavelDMG = 37; break;
                case 3: UpheavelDMG = 38; break;
                case 4: UpheavelDMG = 42; break;
                case 5: UpheavelDMG = 44; break;
                case 6: UpheavelDMG = 49; break;
                case 7: UpheavelDMG = 52; break;
                case 8: UpheavelDMG = 57; break;
                case 9: UpheavelDMG = 62; break;
                case 10: UpheavelDMG = 68; break;
                case 11: UpheavelDMG = 73; break;
                case 12: UpheavelDMG = 81; break;
                case 13: UpheavelDMG = 89; break;
                case 14: UpheavelDMG = 97; break;
                case 15: UpheavelDMG = 107; break;
                case 16: UpheavelDMG = 118; break;
                case 17: UpheavelDMG = 128; break;
                case 18: UpheavelDMG = 139; break;
                case 19: UpheavelDMG = 150; break;
                case 20: UpheavelDMG = 161; break;
                case 21: UpheavelDMG = 172; break;
                case 22: UpheavelDMG = 183; break;
                case 23: UpheavelDMG = 194; break;
                case 24: UpheavelDMG = 206; break;
                case 25: UpheavelDMG = 217; break;
                case 26: UpheavelDMG = 226; break;
                case 27: UpheavelDMG = 236; break;
                case 28: UpheavelDMG = 246; break;
                case 29: UpheavelDMG = 259; break;
                case 30: UpheavelDMG = 272; break;
                case 31: UpheavelDMG = 284; break;
                case 32: UpheavelDMG = 298; break;
                case 33: UpheavelDMG = 310; break;
                case 34: UpheavelDMG = 323; break;
                case 35: UpheavelDMG = 338; break;
                case 36: UpheavelDMG = 352; break;
                case 37: UpheavelDMG = 368; break;
                case 38: UpheavelDMG = 383; break;
                case 39: UpheavelDMG = 399; break;
                case 40: UpheavelDMG = 414; break;
                case 41: UpheavelDMG = 430; break;
                case 42: UpheavelDMG = 448; break;
                case 43: UpheavelDMG = 467; break;
                case 44: UpheavelDMG = 487; break;
                case 45: UpheavelDMG = 511; break;
                case 46: UpheavelDMG = 537; break;
                case 47: UpheavelDMG = 562; break;
                case 48: UpheavelDMG = 590; break;
                case 49: UpheavelDMG = 618; break;
                case 50: UpheavelDMG = 647; break;
                case 51: UpheavelDMG = 673; break;
                case 52: UpheavelDMG = 700; break;
                case 53: UpheavelDMG = 729; break;
                case 54: UpheavelDMG = 757; break;
                case 55: UpheavelDMG = 797; break;
                case 56: UpheavelDMG = 832; break;
                case 57: UpheavelDMG = 868; break;
                case 58: UpheavelDMG = 904; break;
                case 59: UpheavelDMG = 942; break;
                case 60: UpheavelDMG = 980; break;
                case 61: UpheavelDMG = 1019; break;
                case 62: UpheavelDMG = 1064; break;
                case 63: UpheavelDMG = 1112; break;
                case 64: UpheavelDMG = 1160; break;
                case 65: UpheavelDMG = 1216; break;
                case 66: UpheavelDMG = 1260; break;
                case 67: UpheavelDMG = 1306; break;
                case 68: UpheavelDMG = 1350; break;
                case 69: UpheavelDMG = 1394; break;
                case 70: UpheavelDMG = 1440; break;
                case 71: UpheavelDMG = 1484; break;
                case 72: UpheavelDMG = 1530; break;
                case 73: UpheavelDMG = 1568; break;
                case 74: UpheavelDMG = 1607; break;
                case 75: UpheavelDMG = 1661; break;
                case 76: UpheavelDMG = 1708; break;
                case 77: UpheavelDMG = 1754; break;
                case 78: UpheavelDMG = 1800; break;
                case 79: UpheavelDMG = 1847; break;
                case 80: UpheavelDMG = 1892; break;
                case 81: UpheavelDMG = 1937; break;
                case 82: UpheavelDMG = 1981; break;
                case 83: UpheavelDMG = 2027; break;
                case 84: UpheavelDMG = 2072; break;
                case 85: UpheavelDMG = 2132; break;
                case 86: UpheavelDMG = 2179; break;
                case 87: UpheavelDMG = 2229; break;
                case 88: UpheavelDMG = 2282; break;
                case 89: UpheavelDMG = 2343; break;
                case 90: UpheavelDMG = 2406; break;

            }
            return UpheavelDMG;
        }
    }
    //文字说明
    public class Tips
    {

    }
}
