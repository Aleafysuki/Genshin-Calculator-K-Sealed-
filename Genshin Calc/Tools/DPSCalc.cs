using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Genshin_Calc
{
    public partial class DPSCalc : Form
    {
        double DMG, DMG_E, DMG_P, DPS, DPS_E, DPS_P;//计算结果
        double TimeCount, OtherBuff;
        double basic;
        double[] Buff = new double[8];//{物理，风，冰，雷，火，水，岩（，草）加伤}
        double[] Res = new double[8];
        int Level, EM;
        double ReactionBuff;
        public DPSCalc()
        {
            InitializeComponent();
        }
        private void DPSCalc_Load(object sender, EventArgs e)
        {
        }
        public void Input(double 其他增伤, double 其他, double 反应增伤, int 元素精通, int 等级)
        {
            basic = 其他;
            OtherBuff = 其他增伤;
            ReactionBuff = 反应增伤;
            EM = 元素精通;
            Level = 等级;
        }

        private double Buffcheck(int bufftype)
        {
            Buff[0] = Convert.ToDouble(Phys_Buff.Text) / 100;
            Buff[1] = Convert.ToDouble(Anemo_Buff.Text) / 100;
            Buff[2] = Convert.ToDouble(Cryo_Buff.Text) / 100;
            Buff[3] = Convert.ToDouble(Electro_Buff.Text) / 100;
            Buff[4] = Convert.ToDouble(Pyro_Buff.Text) / 100;
            Buff[5] = Convert.ToDouble(Hydro_Buff.Text) / 100;
            Buff[6] = Convert.ToDouble(Geo_Buff.Text) / 100;
            //Buff[7]=Convert.ToDouble(Dendro_Buff.Text)/100;  
            Res[0] = Convert.ToDouble(Phys_RES.Text);
            Res[1] = Convert.ToDouble(Anemo_RES.Text);
            Res[2] = Convert.ToDouble(Cryo_RES.Text);
            Res[3] = Convert.ToDouble(Electro_RES.Text);
            Res[4] = Convert.ToDouble(Pyro_RES.Text);
            Res[5] = Convert.ToDouble(Hydro_RES.Text);
            Res[6] = Convert.ToDouble(Geo_RES.Text);
            //Res[7]=Convert.ToDouble(Dendro_RES.Text);
            if (bufftype >= 0 && bufftype <= 6)
            {
                return basic * ((1 + Buff[bufftype] + OtherBuff / 100) * RESCalc(Res[bufftype])) / 100;
            }
            else return 0;
        }
        [STAThread]
        private void Calculate()
        {
            double[] f = new double[65];
            var ff = 0D;
            var phys = 0D;
            var elem = 0D;
            Upheaval upheaval = new Upheaval();
            for (int i = 1; i < CountOfRows(); i++)
            {
                var a = Tablex(i, 1).Value;  // +-------+-------+-------+-------+-------+
                var b = Tablex(i, 2).Value;  // |单段倍率|伤害段数|属性加成|反应类型|伤害占比|
                var c = Tablex(i, 3).Value;  // +-------+-------+-------+-------+-------+
                var d = Tablex(i, 4).Value;  // |   a   |   b   |   c   |   d   |   e   |
                var e = Tablex(i, 5).Value;  // +-------+-------+-------+-------+-------+
                var ab = Convert.ToDouble(a) * Convert.ToDouble(b);
                var React1 = (1 + (16 * EM / (2000 + EM) + ReactionBuff)) * upheaval.Upheaval_Damage(Level, false) * Convert.ToDouble(b);   //剧变反应
                var React2 = 1 + (2.78 * EM / (1400 + EM) + ReactionBuff);                                                                  //增幅反应
                switch (d.ToString())
                {
                    case "不反应":
                        switch (c.ToString())
                        {
                            case "物理": e = Buffcheck(0) * ab; break;
                            case "风": e = Buffcheck(1) * ab; break;
                            case "冰": e = Buffcheck(2) * ab; break;
                            case "雷": e = Buffcheck(3) * ab; break;
                            case "火": e = Buffcheck(4) * ab; break;
                            case "水": e = Buffcheck(5) * ab; break;
                            case "岩": e = Buffcheck(6) * ab; break;
                            default: e = 0; break;
                        }
                        break;//不反应
                    case "超导": e = React1 * 0.25 * RESCalc(Res[2]); break;//超导
                    case "扩散": e = React1 * 0.30 * RESCalc(Res[1]); break;//扩散
                    case "感电": e = React1 * 0.60 * RESCalc(Res[3]); break;//感电
                    case "碎冰": e = React1 * 0.75 * RESCalc(Res[0]); break;//碎冰
                    case "超载": e = React1 * 1.00 * RESCalc(Res[4]); break;//超载
                    case "火蒸发": e = React2 * 1.5 * Buffcheck(4) * ab; break;//1.5倍增幅
                    case "水蒸发": e = React2 * 2.0 * Buffcheck(5) * ab; break;//2.0倍增幅
                    case "火融化": e = React2 * 2.0 * Buffcheck(4) * ab; break;//2.0倍增幅
                    case "冰融化": e = React2 * 1.5 * Buffcheck(2) * ab; break;//1.5倍增幅
                    default: React1 = 0; React2 = 0; break;
                }
                if (d.ToString() == "不反应" && c.ToString() == "物理")
                {
                    phys += Convert.ToDouble(e);
                }
                else
                    elem += Convert.ToDouble(e);
                f[i] = Convert.ToDouble(e);
            }
            for (int i = 1; i < f.Length; i++)
            {
                ff += f[i];
                if (f[i] == 0) break;
            }
            for (int i = 1; i < CountOfRows(); i++)
            {
                Tablex(i, 5).Value = f[i] / ff;
            }
            DMG_P = phys;
            DMG_E = elem;
            DMG = DMG_P + DMG_E;
            TimeCount = Convert.ToDouble(Time_Input.Text);
            DPS = DMG / TimeCount;
            DPS_P = DMG_P / TimeCount;
            DPS_E = DMG_E / TimeCount;
            DMG_Displayer();
            DPS_Displayer();
        }
        private int CountOfRows()
        {
            return CalcTable.RowCount;
        }
        private void DMG_Displayer()
        {
            DMG_Disp.Text = string.Format("{0:F2}", DMG) + "\r\n" + string.Format("{0:F2}", DMG_P) + "\r\n" + string.Format("{0:F2}", DMG_E);
        }
        private void DPS_Displayer()
        {
            DPS_Disp.Text = string.Format("{0:F2}", DPS) + "\r\n" + string.Format("{0:F2}", DPS_P) + "\r\n" + string.Format("{0:F2}", DPS_E);
        }
        private DataGridViewCell Tablex(int i, int j)//简化单元格的定位,r为第几行,i为第几格(0起)
        {
            return CalcTable.Rows[i - 1].Cells[j - 1];
        }
        private void CalcTable_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Calculate();
            }
            catch (Exception)
            { }
        }
        private void ReCalculator(object sender, EventArgs e)
        {
            try
            {
                Calculate();
            }
            catch (Exception)
            { }
        }
        private double RESCalc(double rs)
        {
            var Resistance = 0D;
            if (rs < 0)
            {
                Resistance = 1 - rs / 200;
            }
            else if (0 <= rs && rs <= 75)
            {
                Resistance = 1 - rs / 100;
            }
            else if (75 < rs)
            {
                Resistance = 1 / (1 + 4 * (rs / 100));
            }
            return Resistance;
        }
    }
}
