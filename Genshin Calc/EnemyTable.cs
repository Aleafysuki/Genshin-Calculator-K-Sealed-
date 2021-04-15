using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClosedXML.Excel;
using System.IO;


namespace Genshin_Calc
{
    public partial class EnemyTable : Form
    {
        object[] Enemyname = new object[64];
        float[] EnemyRES = new float[9];

        readonly string TablePath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\Genshin Calculator\详细数据.xlsx";
        XLWorkbook book;
        IXLRange EnemyRange;
        public EnemyTable()
        {
            InitializeComponent();
            try
            {
                book = new XLWorkbook(TablePath);

            }
            catch (Exception)
            {
            }
            if (!File.Exists(TablePath))
            {
                AddToTable();
            }
        }
        private string CellLoc(char x, int y)
        {
            return Convert.ToString(x) + Convert.ToString(y);
        }

        public void EnemyCheck()
        {
            EnemyRange = book.Worksheet("敌人属性").RangeUsed();
            for (int i = 1; i < EnemyRange.RowCount(); i++)
            {
                Enemyname[i - 1] = EnemyRange.Cell(CellLoc('A', i + 1)).Value;
            }
            try
            {
                Enemy_Select.Items.AddRange(Enemyname);
            }
            catch (ArgumentNullException)
            {
            }
            RESSelectorBox.Items.AddRange(new object[] {
            "风\t"     + 0 +"%",
            "岩\t"     + 0 +"%",
            "雷\t"     + 0 +"%",
            "冰\t"     + 0 +"%",
            "水\t"     + 0 +"%",
            "火\t"     + 0 +"%",
            "草\t"     + 0 +"%",
            "物理\t"   + 0 +"%"  ,
            "对应属性\t"+ 0 +"%"});
            RESSelectorBox.SelectedIndex = 0;
        }
        private float ResCalc(char dx, int order)
        {
            try
            {
                EnemyRES[order] = float.Parse(EnemyRange.Cell(CellLoc(dx, Enemy_Select.SelectedIndex + 2)).Value.ToString());
            }
            catch (FormatException)
            {
                EnemyRES[order] =float.PositiveInfinity;
                DialogResult err;
                err = MessageBox.Show("表格中的某处数据出了问题。\n出问题的数据一般是无穷大，已自动设定。\n记得改一下数据表。", "提示");
            }
            return EnemyRES[order];
        }
        private void ResLookup()//根据敌人属性查询对应抗性
        {
            RESSelectorBox.Items.Clear();
            float Ares = ResCalc('B', 0);//抗性：风
            float Gres = ResCalc('C', 1);//抗性：岩
            float Eres = ResCalc('D', 2);//抗性：雷
            float Cres = ResCalc('E', 3);//抗性：冰
            float Hres = ResCalc('F', 4);//抗性：水
            float Fres = ResCalc('G', 5);//抗性：火
            float Dres = ResCalc('H', 6);//抗性：草
            float Pres = ResCalc('I', 7);//抗性：物理
            float Rres = EnemyRange.Cell(CellLoc('J', Enemy_Select.SelectedIndex + 2)).Value.ToString() == "" ? 0 : ResCalc('J', 8);//抗性：对应属性
            RESSelectorBox.Items.AddRange(new object[] {
                "风\t"     + Ares * 100+"%",
                "岩\t"     + Gres * 100+"%",
                "雷\t"     + Eres * 100+"%",
                "冰\t"     + Cres * 100+"%",
                "水\t"     + Hres * 100+"%",
                "火\t"     + Fres * 100+"%",
                "草\t"     + Dres * 100+"%",
                "物理\t"   + Pres * 100+"%",
                "对应属性\t"+ Rres * 100+"%"});
        }
        private void AddToTable()
        {
            book.AddWorksheet("敌人属性");
            //book.AddWorksheet("角色属性");
            //book.AddWorksheet("武器属性");
            book.SaveAs(TablePath);
        }
        public double Output()
        {
            return EnemyRES[RESSelectorBox.SelectedIndex];
        }
        private void Enemy_Select_SelectedIndexChanged(object sender, EventArgs e)
        {
            ResLookup();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            RESSelectorBox.SelectedIndex = 0;
            EnemyRES[RESSelectorBox.SelectedIndex] = 0.1F;
        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            if (RESSelectorBox.SelectedIndex < 0)
            {
                RESSelectorBox.SelectedIndex = 0;
            }
            Close();
        }

    }
}
