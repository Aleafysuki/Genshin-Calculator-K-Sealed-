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
    public partial class Hutao_Calc : Form
    {
        //整形变量：血量、技能等级（1-13）
        int HP, Skill;
        //浮点变量：伤害计算结果
        double ToAtk, SkillDMG, DMG_N, DMG_C, DMG_A;
        //导入的变量
        double ATK, CritRate, CritDMG, DMGBuff,Other;
        /// <summary>
        /// 代码部分
        /// </summary>
        public Hutao_Calc()
        {
            InitializeComponent();
            Weapon_Type1.Checked = true;
            Weapon_Grade.SelectedIndex = 0;
            Skill = 1;
            UpdateIndex();
        }
        private void ErrorTip()
        {
            ToATK.Text = "----";
            Normal_DMG.Text = "----";
            Crit_DMG.Text = "----";
            Avg_DMG.Text = "----";
        }

        private void RadioButtonSettings(RadioButton WeaponType)//更改RadioButton形态
        {
            Heal FontChange = new Heal();
            FontChange.ShieldTypeChange(WeaponType);
        }
        private void Weapon_Type1_CheckedChanged(object sender, EventArgs e)//护摩之杖（1/2血以上）
        {
            RadioButtonSettings(Weapon_Type1);
            UpdateIndex();
        }
        private void Weapon_Type2_CheckedChanged(object sender, EventArgs e)//护摩之杖（1/2血以下）
        {
            RadioButtonSettings(Weapon_Type2);
            UpdateIndex();
        }
        private void Weapon_Type3_CheckedChanged(object sender, EventArgs e)//其他武器
        {
            RadioButtonSettings(Weapon_Type3);
            UpdateIndex();
        }
        private void Constellation_Check_CheckedChanged(object sender, EventArgs e)
        {
            Constellation_Check.ForeColor = Constellation_Check.Checked ? SystemColors.ControlText : SystemColors.ControlDark;
            UpdateIndex();
        }
        private void MaxHP1_Scroll(object sender, EventArgs e)
        {
            MaxHP.Text = Convert.ToString(MaxHP1.Value);
            HP = MaxHP1.Value;
            UpdateIndex();
        }
        private void MaxHP_TextChanged(object sender, EventArgs e)
        {
            try
            {
                MaxHP1.Value = int.Parse(MaxHP.Text);
            }
            catch (Exception)
            {
                ErrorTip();
            }
            HP = MaxHP1.Value;
            UpdateIndex();
        }
        private void SkillLevel1_Scroll(object sender, EventArgs e)
        {
            SkillLevel.Text = Convert.ToString(SkillLevel1.Value);
            if (SkillLevel1.Value > 10)
            {
                Constellation_Check.Checked = true;
            }
            else if (SkillLevel1.Value < 4)
            {
                Constellation_Check.Checked = false;
            }
            Skill = SkillLevel1.Value;
            UpdateIndex();
        }
        private void SkillLevel_TextChanged(object sender, EventArgs e)
        {
            try
            {
                SkillLevel1.Value = int.Parse(SkillLevel.Text);
            }
            catch (Exception)
            {
                ErrorTip();
            }
            Skill = SkillLevel1.Value;
            UpdateIndex();
        }
        private void Weapon_Grade_SelectedItemChanged(object sender, EventArgs e)
        {
            UpdateIndex();
        }
        public void Input(double Attack,double Cr,double Cd, double buff,double othersum)
        {
            //输入：单独的攻击力,双爆和其他所有数据
            Other = othersum;
            ATK = Attack;
            CritRate = Cr;
            CritDMG = Cd;
            DMGBuff = buff;
            UpdateIndex();
        }
        public int Output(DialogResult dialogResult)
        {
            UpdateIndex();
            return dialogResult == DialogResult.Cancel ? 0 : Convert.ToInt32(ToAtk);
        }

        private double SkillCalculate(int skilllevel)
        {
            switch (skilllevel)
            {
                case 01: SkillDMG = 0.64; return 0.0384;
                case 02: SkillDMG = 0.69; return 0.0407;
                case 03: SkillDMG = 0.74; return 0.043;
                case 04: SkillDMG = 0.80; return 0.046;
                case 05: SkillDMG = 0.85; return 0.0483;
                case 06: SkillDMG = 0.90; return 0.0506;
                case 07: SkillDMG = 0.96; return 0.0536;
                case 08: SkillDMG = 1.02; return 0.0566;
                case 09: SkillDMG = 1.09; return 0.0596;
                case 10: SkillDMG = 1.15; return 0.0626;
                case 11: SkillDMG = 1.22; return 0.0656;
                case 12: SkillDMG = 1.28; return 0.0685;
                case 13: SkillDMG = 1.36; return 0.0715;
                default: SkillDMG = 0.64; return 0.0384;
            }
        }
        private double WeaponCalculate(bool Type)
        {
            return Type ? (0.4 * Weapon_Grade.SelectedIndex + 1.8) / 100 : (0.2 * Weapon_Grade.SelectedIndex + 0.8) / 100;
        }
        private void UpdateIndex()//总计算代码
        {
            HP = MaxHP1.Value;
            { 
            if (Weapon_Type1.Checked)
                ToAtk = HP * (SkillCalculate(Skill) + WeaponCalculate(false));
            else if (Weapon_Type2.Checked)
                ToAtk = HP * (SkillCalculate(Skill) + WeaponCalculate(true));
            else
                ToAtk = HP * SkillCalculate(Skill);
        }
            {
                DMG_N = (ATK + ToAtk) * Other * DMGBuff * SkillDMG + (Constellation_Check.Checked ? 0.1 * HP : 0);
                DMG_C = DMG_N * (1 + CritDMG);
                DMG_A = DMG_N * (1 + CritRate * CritDMG);
                Display();
            }
        }
        private void Display()
        {
            ToATK.Text = Convert.ToString(ToAtk);
            Normal_DMG.Text = Convert.ToString(DMG_N);
            Crit_DMG.Text = Convert.ToString(DMG_C);
            Avg_DMG.Text = Convert.ToString(DMG_A);
        }
        private void Button_Confirm_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }
        private void Button_Cancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
