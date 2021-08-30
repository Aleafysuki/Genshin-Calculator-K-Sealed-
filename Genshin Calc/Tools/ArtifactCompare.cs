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
    public partial class ArtifactCompare : Form
    {

        public ArtifactCompare()
        {
            InitializeComponent();
            Reaction_Choose.SelectedIndex = 0;
        }
        double[] Character = new double[9];//仅人物的面板：{白攻击,绿攻击,暴击率,暴击伤害,精通,伤害加成,反应提升,倍率,反应类型}
        double[] Artifact1 = new double[6];//圣遗物1的面板:{固定攻击,百分比攻击,暴击率,暴击伤害,精通,伤害加成}
        double[] Artifact2 = new double[6];//圣遗物2的面板:{固定攻击,百分比攻击,暴击率,暴击伤害,精通,伤害加成}        
        private void Text_Changed(object sender, EventArgs e)//若有数据输入则更新计算结果
        {
            try
            {
                Character[0] = Convert.ToDouble(ATK0.Text);
                Character[1] = Convert.ToDouble(ATKP0.Text);
                Character[2] = Convert.ToDouble(CritRate0.Text) / 100;
                Character[3] = Convert.ToDouble(CritDMG0.Text) / 100;
                Character[4] = Convert.ToDouble(EM0.Text);
                Character[5] = Convert.ToDouble(ElemBuff0.Text) / 100;
                Character[6] = Convert.ToDouble(ReactBuff.Text) / 100;
                Character[7] = Convert.ToDouble(Skill.Text) / 100;
                Character[8] = Convert.ToDouble(Reaction_Choose.SelectedIndex);
                Artifact1[0] = Convert.ToDouble(ATK1.Text);
                Artifact1[1] = Convert.ToDouble(ATKP1.Text) / 100;
                Artifact1[2] = Convert.ToDouble(CritRate1.Text) / 100;
                Artifact1[3] = Convert.ToDouble(CritDMG1.Text) / 100;
                Artifact1[4] = Convert.ToDouble(EM1.Text);
                Artifact1[5] = Convert.ToDouble(ElemBuff1.Text) / 100;
                Artifact2[0] = Convert.ToDouble(ATK2.Text);
                Artifact2[1] = Convert.ToDouble(ATKP2.Text) / 100;
                Artifact2[2] = Convert.ToDouble(CritRate2.Text) / 100;
                Artifact2[3] = Convert.ToDouble(CritDMG2.Text) / 100;
                Artifact2[4] = Convert.ToDouble(EM2.Text);
                Artifact2[5] = Convert.ToDouble(ElemBuff2.Text) / 100;
            }
            catch (Exception)
            { }
            Display();
        }


        private double[] Calculate(double[] MainCharacter, double[] Artifacts)
        {
            double[] Damage = new double[3];//计算结果:{未暴击的伤害,已暴击的伤害,平均伤害}

            //总攻击   =   白攻击 +   绿攻击 +   固定攻击    +   百分比攻击*白攻击
            var ATK = MainCharacter[0] + MainCharacter[1] + Artifacts[0] + MainCharacter[0] * Artifacts[1];

            //总暴击   =   角色暴击率   +   圣遗物暴击率
            var CritRate = MainCharacter[2] + Artifacts[2];

            //总爆伤   =   角色爆伤    +   圣遗物爆伤
            var CritDMG = MainCharacter[3] + Artifacts[3];

            //总元素精通 =   角色元素精通  +   圣遗物元素精通
            var ElementalMastery = MainCharacter[4] + Artifacts[4];

            //总伤害加成 =   角色伤害加成  +   圣遗物伤害加成
            var DamageBuff = 1 + MainCharacter[5] + Artifacts[5];

            var React = 1 * (1 + (2.78 / (1 + 1400 / ElementalMastery) + MainCharacter[6] / 100));
            switch (Reaction_Choose.SelectedIndex)
            {
                case 0: React = 1; break;
                case 1: React *= 1.5; break;
                case 2: React *= 2.0; break;
                default: React = 1; break;
            }
            try
            {
                Damage[0] = ATK * React * DamageBuff * double.Parse(Skill.Text) / 200;
                Damage[1] = Damage[0] * (1 + CritDMG);
                Damage[2] = Damage[0] * (1 + CritRate * CritDMG);
            }
            catch (Exception) { }
            return Damage;
        }

        private void Display()
        {
            double[] Result1 = Calculate(Character, Artifact1);
            double[] Result2 = Calculate(Character, Artifact2);
            N1_DMG.Text = Result1[0].ToString();
            C1_DMG.Text = Result1[1].ToString();
            A1_DMG.Text = Result1[2].ToString();
            N2_DMG.Text = Result2[0].ToString();
            C2_DMG.Text = Result2[1].ToString();
            A2_DMG.Text = Result2[2].ToString();
        }

    }
}
