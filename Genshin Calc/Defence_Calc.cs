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
    public partial class Defence_Calc : Form
    {
        public Defence_Calc()
        {
            InitializeComponent();
        }
        double DEF2ATK;
        //白字防御输入
        private void PlayerDEFBasic1_Scroll(object sender, EventArgs e)
        {
            PlayerDEFBasic.Text = PlayerDEFBasic1.Value.ToString();
            DEFCalc();
        }
        private void PlayerDEFBasic_TextChanged(object sender, EventArgs e)
        {
            try
            {
                PlayerDEFBasic1.Value = Convert.ToInt32(PlayerDEFBasic.Text);
            }
            catch (Exception)
            {

            }
            DEFCalc();
        }
        //绿字防御输入
        private void PlayerDEF1_Scroll(object sender, EventArgs e)
        {
            PlayerDEF.Text = PlayerDEF1.Value.ToString();
            DEFCalc();
        }
        private void PlayerDEF_TextChanged(object sender, EventArgs e)
        {
            try
            {
                PlayerDEF1.Value = Convert.ToInt32(PlayerDEF.Text);
            }
            catch (Exception)
            {

            }
            DEFCalc();
        }
        //防御提升百分比
        private void PlayerDEF1_P_Scroll(object sender, EventArgs e)
        {
            PlayerDEF_P.Text = Convert.ToString(Convert.ToDouble(PlayerDEF1_P.Value) / 10);
            DEFCalc();
        }
        private void PlayerDEF_P_TextChanged(object sender, EventArgs e)
        {
            try
            {
                PlayerDEF1_P.Value = Convert.ToInt32(Convert.ToDouble(PlayerDEF_P.Text) * 10);
            }
            catch (Exception)
            {

            }
            DEFCalc();
        }
        //防御转换到攻击的效率
        private void PlayerDEFPlus1_Scroll(object sender, EventArgs e)
        {
            PlayerDEFPlus.Text = Convert.ToString(Convert.ToDouble(PlayerDEFPlus1.Value) / 10);
            DEFCalc();
        }
        private void PlayerDEFPlus_TextChanged(object sender, EventArgs e)
        {
            try
            {
                PlayerDEFPlus1.Value = Convert.ToInt32(Convert.ToDouble(PlayerDEFPlus.Text) * 10);
            }
            catch (Exception)
            {

            }
            DEFCalc();
        }

        //防御转换为攻击的算法
        private void DEFCalc()
        {
            DEF2ATK = PlayerDEFBasic1.Value * (1 + float.Parse(PlayerDEF_P.Text) / 100) + PlayerDEF1.Value;
            DEFense.Text = Convert.ToString(DEF2ATK);
            DEF2ATK *= float.Parse(PlayerDEFPlus.Text) / 100;
            ToATK.Text = Convert.ToString(DEF2ATK);
        }
        //将数据填入主窗口
        private void Button_Confirm_Click(object sender, EventArgs e)
        {
            ATKAdd();
            Close();
        }
        public double ATKAdd()
        {
            return DEF2ATK;
        }
        private void Button_Cancel_Click(object sender, EventArgs e)
        {
            DEF2ATK = 0;
            Close();
        }


    }
}
