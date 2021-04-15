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
    public partial class Albedo_Calc : Form
    {
        double ATK;                  //需导入的整数
        double DMGBuff, other, Crited, Average; //需导入的浮点数
        double SkillA_Normal, BurstA_Normal, SkillB_Normal, BurstB_Normal; //计算结果
        double[] SkillA_Multiplier = { 1.304, 1.4018, 1.4996, 1.63, 1.7278, 1.8256, 1.956, 2.0864, 2.2168, 2.3472, 2.4776, 2.608, 2.771 };
        double[] SkillB_Multiplier = { 1.34, 1.4362, 1.5364, 1.67, 1.7702, 1.8704, 2.004, 2.1376, 2.2712, 2.4048, 2.5384, 2.672, 2.839 };
        double[] BurstA_Multiplier = { 3.672, 3.9474, 4.2228, 4.59, 4.8654, 5.1408, 5.508, 5.8752, 6.2424, 6.6096, 6.9768, 7.344, 7.803 };
        double[] BurstB_Multiplier = { 0.72, 0.774, 0.828, 0.9, 0.954, 1.008, 1.08, 1.152, 1.224, 1.296, 1.368, 1.44, 1.53 };
        bool started = false;
        public Albedo_Calc()
        {
            InitializeComponent();
            Skill_Level.SelectedIndex = 12;
            Burst_Level.SelectedIndex = 12;
            BurstCount.SelectedIndex = 4;
            BurstCount.Enabled = Constellation_Check.Checked;
            BurstCount_Label.Enabled = Constellation_Check.Checked;
            started = true;
            UpdateIndex();
        }
        public void UpdateIndex()//更新计算结果
        {
            AlbedoCalc();
            SA_Normal.Text = Convert.ToString(SkillA_Normal);
            SB_Normal.Text = Convert.ToString(SkillB_Normal);
            BA_Normal.Text = Convert.ToString(BurstA_Normal);
            BB_Normal.Text = Convert.ToString(BurstB_Normal);
            SA_Crit.Text = Convert.ToString(SkillA_Normal * Crited);
            SB_Crit.Text = Convert.ToString(SkillB_Normal * Crited);
            BA_Crit.Text = Convert.ToString(BurstA_Normal * Crited);
            BB_Crit.Text = Convert.ToString(BurstB_Normal * Crited);
            SA_Avg.Text = Convert.ToString(SkillA_Normal * Average);
            SB_Avg.Text = Convert.ToString(SkillB_Normal * Average);
            BA_Avg.Text = Convert.ToString(BurstA_Normal * Average);
            BB_Avg.Text = Convert.ToString(BurstB_Normal * Average);
        }
        private double RESCalc()//抗性计算
        {
            var Resistance = 0d;
            if (float.Parse(GeoRES.Text) < 0)
            {
                Resistance = 1 - float.Parse(GeoRES.Text) / 200;
            }
            else if (0 <= float.Parse(GeoRES.Text) && float.Parse(GeoRES.Text) <= 75)
            {
                Resistance = 1 - float.Parse(GeoRES.Text) / 100;
            }
            else if (75 < float.Parse(GeoRES.Text))
            {
                Resistance = 1 / (1 + 4 * (float.Parse(GeoRES.Text) / 100));
            }
            //UpdateIndex();
            return Resistance;
        }

        private void Skill_Level_SelectedItemChanged(object sender, EventArgs e)
        {
            SkillA.Text = Convert.ToString(SkillA_Multiplier[12 - Skill_Level.SelectedIndex] * 100) + "%";
            SkillB.Text = Convert.ToString(SkillB_Multiplier[12 - Skill_Level.SelectedIndex] * 100) + "%";
            if (started)
            {
                UpdateIndex();
            }
        }
        private void Burst_Level_SelectedItemChanged(object sender, EventArgs e)
        {
            BurstA.Text = Convert.ToString(BurstA_Multiplier[12 - Burst_Level.SelectedIndex] * 100) + "%";
            BurstB.Text = Convert.ToString(BurstB_Multiplier[12 - Burst_Level.SelectedIndex] * 100) + "%";
            UpdateIndex();
        }

        //白字防御力的更改
        private void PlayerDEFA_TextChanged(object sender, EventArgs e)
        {
            try
            {
                PlayerDEFBasic1.Value = Convert.ToInt32(PlayerDEFBasic.Text);
            }
            catch (Exception)
            {

            }
            UpdateIndex();
        }
        private void PlayerDEFA_Scroll(object sender, EventArgs e)
        {
            PlayerDEFBasic.Text = PlayerDEFBasic1.Value.ToString();
            UpdateIndex();
        }
        //绿字防御力的更改
        private void PlayerDEFB_TextChanged(object sender, EventArgs e)
        {
            try
            {
                PlayerDEF1.Value = Convert.ToInt32(PlayerDEF.Text);
            }
            catch (Exception)
            {

            }
            UpdateIndex();
        }
        private void PlayerDEFB_Scroll(object sender, EventArgs e)
        {
            PlayerDEF.Text = PlayerDEF1.Value.ToString();
            UpdateIndex();
        }

        private void AlbedoCalc()//计算公式
        {
            SkillA_Normal = ATK * SkillA_Multiplier[12 - Skill_Level.SelectedIndex] * RESCalc() * other;
            SkillB_Normal = (PlayerDEF1.Value + PlayerDEFBasic1.Value) * (DMGBuff + Convert.ToDouble(GeoBuff.Text) / 100 + (EnemyHP_Check.Checked ? 0.25 : 0)) * SkillB_Multiplier[12 - Skill_Level.SelectedIndex] * RESCalc() * other;
            BurstA_Normal = (ATK + (Constellation_Check.Checked ? 0.3 * (PlayerDEF1.Value + PlayerDEFBasic1.Value) * Convert.ToInt16(BurstCount.SelectedItem) : 0)) * BurstA_Multiplier[12 - Burst_Level.SelectedIndex] * RESCalc() * other;
            BurstB_Normal = (ATK + (Constellation_Check.Checked ? 0.3 * (PlayerDEF1.Value + PlayerDEFBasic1.Value) * Convert.ToInt16(BurstCount.SelectedItem) : 0)) * BurstB_Multiplier[12 - Burst_Level.SelectedIndex] * RESCalc() * other;
        }
        public void Input(double atk, double dmgbuff, double otherCon, double crit, double avg)//导入数据
        {
            ATK = atk;
            DMGBuff = dmgbuff;
            other = otherCon;
            Crited = crit;
            Average = avg;
        }
        private void Constellation_Check_CheckedChanged(object sender, EventArgs e)//确认命座2是否解锁的复选框
        {
            BurstCount.Enabled = Constellation_Check.Checked;
            BurstCount_Label.Enabled = Constellation_Check.Checked;
            UpdateIndex();
        }
        private void ContentChanged(object sender, EventArgs e)
        {
            UpdateIndex();
        }
        public void ContentChanged_Pub()
        {
            UpdateIndex();
        }
        private void ExitButton_Click(object sender, EventArgs e)//退出按钮
        {
            Close();
        }
    }
}
