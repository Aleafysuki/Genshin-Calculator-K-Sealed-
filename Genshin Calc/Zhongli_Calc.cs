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
    public partial class Zhongli_Calc : Form
    {
        public Zhongli_Calc()
        {
            InitializeComponent();
            Init();
        }
        private void Init()
        {
            SkillSelection.SelectedIndex = 0;
            EnemyRES.Text = Convert.ToString(Res);
            Physbuff = double.Parse(Phys_Buff.Text) / 100;
            Geobuff = double.Parse(Geo_Buff.Text) / 100;
            Otherbuff = double.Parse(Other_Buff.Text) / 100;
            
            Calc();
            UpdateIndex();
            Other_Buff.Text = Convert.ToString(Otherbuff * 100);
        }
        double DMG_N, DMG_C, DMG_A, CritRate, CritDmg, HPBuff = 1, Skill_Percent, Attack,DamageBuff, Other, Res;
        double Physbuff, Geobuff, Otherbuff;
        private void Skill1_Scroll(object sender, EventArgs e)
        {
            Skill.Text = Convert.ToString(Convert.ToDouble(Skill1.Value) / 10);
            UpdateIndex();
        }
        private void Skill_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Skill1.Value = Convert.ToInt32(Convert.ToDouble(Skill.Text) * 10);
            }
            catch (Exception)
            { }
            UpdateIndex();
        }

        private void Phys_Buff_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Physbuff = double.Parse(Phys_Buff.Text)/100;
            }
            catch (Exception)
            { }
            UpdateIndex();
            Other_Buff.Text = Convert.ToString(Otherbuff*100);
        }
        private void Geo_Buff_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Geobuff = double.Parse(Geo_Buff.Text)/100;
            }
            catch (Exception)
            { }
            UpdateIndex();
            Other_Buff.Text = Convert.ToString(Otherbuff*100);
        }

        private void Other_buff_Text_Click(object sender, EventArgs e)
        {
            Otherbuff = DamageBuff - Physbuff - Geobuff;
            Phys_Buff.Text = Convert.ToString(Physbuff*100);
            Geo_Buff.Text = Convert.ToString(Geobuff*100);
            Other_Buff.Text = Convert.ToString(Otherbuff*100);
            UpdateIndex();
        }

        private void Other_Buff_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Otherbuff = double.Parse(Other_Buff.Text) / 100;
            }
            catch (Exception)
            { }
            DamageBuff = Physbuff + Geobuff + Otherbuff;
            UpdateIndex();
        }
        private void EnemyRES1_Scroll(object sender, EventArgs e)
        {
            EnemyRES.Text = Convert.ToString(Convert.ToDouble(EnemyRES1.Value) / 10 - 100);
            UpdateIndex();
        }
        private void EnemyRES_TextChanged(object sender, EventArgs e)
        {
            try
            {
                EnemyRES1.Value = Convert.ToInt32(Convert.ToDouble(EnemyRES.Text) * 10 + 1000);
                UpdateIndex();
            }
            catch (Exception)
            { }
        }

        private void ATK1_Scroll(object sender, EventArgs e)
        {
            ATK.Text = Convert.ToString(ATK1.Value);
            UpdateIndex();
        }
        private void ATK_TextChanged(object sender, EventArgs e)
        {
            try
            {
                ATK1.Value = int.Parse(ATK.Text);
            }
            catch (Exception)
            { }
            UpdateIndex();
        }

        private void HP_TextChanged(object sender, EventArgs e)
        {
            try
            {
                HP1.Value = int.Parse(HP.Text);
            }
            catch (Exception)
            { }
            UpdateIndex();
        }
        private void HP1_Scroll(object sender, EventArgs e)
        {
            HP.Text = Convert.ToString(HP1.Value);
            UpdateIndex();
        }

        private void SkillSelection_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (SkillSelection.SelectedIndex)
            {
                case 0:
                    Text_DMGPlus.Text = "伤害提高量：生命上限的1.39%";
                    HPBuff = 0.0139;
                    break;
                case 1:
                    Text_DMGPlus.Text = "伤害提高量：生命上限的1.9%";
                    HPBuff = 0.019;
                    break;
                case 2:
                    Text_DMGPlus.Text = "伤害提高量：生命上限的33%";
                    HPBuff = 0.33;
                    break;
                default:
                    Text_DMGPlus.Text = "伤害提高量：生命上限的1.39%";
                    HPBuff = 0.0139;
                    break;
            }
            UpdateIndex();
        }

        public void Input(double _Skill, double _ATK,double _Buff, double _Other,double _Res,double _ResT,double CR,double CD)
        {
            Skill_Percent = _Skill/100;
            Attack = _ATK;
            Other = _Other;
            Res = _Res;
            EnemyRES.Text = Convert.ToString(_ResT);
            CritRate = CR/100;
            CritDmg = 1+CD/100;
            DamageBuff = _Buff;
            UpdateIndex();
        }
        private void RESCalc()
        {
            try
            {
                if (float.Parse(EnemyRES.Text) < 0)
                {
                    Res = 1 - float.Parse(EnemyRES.Text) / 200;
                }
                else if (0 <= float.Parse(EnemyRES.Text) && float.Parse(EnemyRES.Text) <= 75)
                {
                    Res = 1 - float.Parse(EnemyRES.Text) / 100;
                }
                else if (75 < float.Parse(EnemyRES.Text))
                {
                    Res = 1 / (1 + 4 * (float.Parse(EnemyRES.Text) / 100));
                }
            }
            catch (Exception)
            { }
        }
        public void UpdateIndex()
        {
            Attack = ATK1.Value;
            Skill_Percent = (float)Skill1.Value / 1000;
            RESCalc();
            Calc();
            Normal_DMG.Text = string.Format("{0:N5}",Convert.ToString(DMG_N));
            Crit_DMG.Text = string.Format("{0:N5}", Convert.ToString(DMG_C));
            Avg_DMG.Text = string.Format("{0:N5}", Convert.ToString(DMG_A));
        }
        private void Calc()
        {

            DMG_N =SkillSelection.SelectedIndex==0? 
                (Attack * Skill_Percent + HPBuff * HP1.Value) * Res * (Physbuff + Otherbuff+1) * Other://普攻：岩伤失效
                (Attack * Skill_Percent + HPBuff * HP1.Value) * Res * (Geobuff + Otherbuff+1) * Other;//E或Q：物伤失效
            DMG_C = DMG_N * CritDmg;
            DMG_A = DMG_N * (1 - CritRate) + DMG_C * CritRate;
        }
    }
}
