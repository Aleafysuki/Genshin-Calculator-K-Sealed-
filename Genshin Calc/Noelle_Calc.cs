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
    public partial class Noelle_Calc : Form
    {
        public Noelle_Calc()
        {
            InitializeComponent();
            TopM();
            //Form1 read = new Form1();
            //read.
        }
        public void TopM()
        {
            Form1 MainF = new Form1();
            if (MainF.TopMost)
            {
                MainF.TopMost = false;
                TopMost = true;
            }
            else
            {
                //TopMost = false;
                //MainF.TopMost = true;
            }
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
            DEF2ATK = PlayerDEFBasic1.Value + PlayerDEF1.Value;
            DEFense.Text = Convert.ToString(DEF2ATK);
            DEF2ATK *= float.Parse(PlayerDEFPlus.Text) / 100;

            ToATK.Text = Convert.ToString(Constellation_Check.Checked == true ? (PlayerDEFBasic1.Value + PlayerDEF1.Value) / 2 + DEF2ATK : DEF2ATK);
        }
        //将数据填入主窗口
        private void Button_Confirm_Click(object sender, EventArgs e)
        {
            ATKAdd();
            Close();
            TopM();
        }
        public double ATKAdd()
        {
            return Convert.ToDouble(ToATK.Text);
        }
        private void Button_Cancel_Click(object sender, EventArgs e)
        {
            DEF2ATK = 0;
            Close();
            TopM();
        }
        //保存当前的各项数值
        public float Output(int i)
        {
            float ret = 0;
            switch (i)
            {
                case 1: ret = PlayerDEFBasic1.Value;    break;
                case 2: ret = PlayerDEF1.Value;         break;
                case 4: ret = PlayerDEFPlus1.Value;     break;
            }
            return ret;
        }
        //读取当前的各项数值
        public void Input(double d1, double d2, double d3)
        {
            PlayerDEFBasic1.Value = (int)d1;
            PlayerDEF1.Value = (int)d2;
            PlayerDEFPlus1.Value = (int)d3;
            PlayerDEFBasic.Text = PlayerDEFBasic1.Value.ToString();
            PlayerDEFPlus.Text = Convert.ToString(Convert.ToDouble(PlayerDEFPlus1.Value) / 10);
            DEFCalc();
        }

        private void Constellation_Check_CheckedChanged(object sender, EventArgs e)
        {
            DEFCalc();
        }
    }
}
