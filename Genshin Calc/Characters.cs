using System;
using System.Linq;

using System.Web;
using System.Windows.Forms;
using ClosedXML.Excel;

namespace Genshin_Calc
{
    public partial class Characters_Weapons : Form
    {
        readonly string TablePath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\Genshin Calculator\详细数据.xlsx";
        object[] Elements = new object[8];
        object[] Character = new object[16];
        object[] Level = new object[96];
        object[] Weapon = new object[64];
        bool init,canceled;
        string NameOfCharacter;
        XLWorkbook book;
        IXLRange CharacterRange;
        IXLRange CharacterLevel;
        IXLRange WeaponRange;
        IXLRange WeaponLevel;
        /// <summary>
        /// 这是一坨屎山，莫要轻易动
        /// </summary>
        public Characters_Weapons()
        {
            InitializeComponent();

                book = new XLWorkbook(TablePath);

            init = false;
            Weapon_Level.SelectedIndex = 0;
            CharacterRangeSelect();
        }
        private string CellLoc(char x, int y)
        {
            return Convert.ToString(x) + Convert.ToString(y);
        }       
        /// <summary>
        /// 角色相关查询
        /// </summary>
        public void CharacterRangeSelect()
        {
            CharacterRange = book.Worksheet("角色索引").RangeUsed();
            for (int i = 1; i < CharacterRange.ColumnCount(); i++)
            {
                Elements[i - 1] = CharacterRange.Cell(1,i).Value;
            }
            try
            {
                Character_Elem.Items.AddRange(Elements);
            }
            catch (ArgumentNullException)
            {
            }

        }
        private void CharacterSelect()
        {
            var ElemRange = book.Worksheet("角色索引").Column(Character_Elem.SelectedIndex + 1).CellsUsed().Count();
            try
            {
                for (int k = 1; k < ElemRange; k++)
                {
                    Character[k - 1] = CharacterRange.Cell(k+1, Character_Elem.SelectedIndex +1).Value;
                }
                Character_Choose.Items.AddRange(Character);
            }
            catch (ArgumentNullException)
            {
            }
        }
        private void CharacterLevelSelect()
        {
            try
            {
                var nme = Character_Choose.SelectedItem.ToString();
                NameOfCharacter = nme;
                CharacterLevel = book.Worksheet("角色等级").RangeUsed();
                //var LevelTable = book.Worksheet("角色等级").Column(nme).CellsUsed().Count();
                var lvl = Character_Level.Text;
                int r = 2, c = 2;
                if (Character_Check.Checked && (lvl == 20.ToString() || lvl == 40.ToString() || lvl == 50.ToString() || lvl == 60.ToString() || lvl == 70.ToString() || lvl == 80.ToString()))
                {
                    lvl = Character_Level.Text + "+";
                }
                for (int p = 1; p < CharacterLevel.ColumnsUsed().Count(); p++)
                {
                    if (CharacterLevel.Cell(1, p).Value.ToString() == nme)
                    {
                        c = p;
                        break;
                    }
                }
                for (int i = 1; i < 100; i++)
                {
                    if (CharacterLevel.Cell(i, 1).Value.ToString() == lvl)
                    {
                        r = i;
                        Character_Result.Text = Convert.ToInt32(CharacterLevel.Cell(r, c).Value).ToString();
                        break;
                    }
                }
                Character_Elem.Items.AddRange(Level);
            }
            catch (Exception)
            {
            }
        }
        private void Skill_Check_Button_Click(object sender, EventArgs e)
        {
            if (NameOfCharacter.Contains("旅行者"))
            {
                NameOfCharacter = "旅行者";
            }
            var url = "https://"+"wiki.biligame.com/"+"ys/" + HttpUtility.UrlEncode(NameOfCharacter);
            System.Diagnostics.Process.Start(url);
        }
        private void Character_Elem_SelectedIndexChanged(object sender, EventArgs e)
        {
            //CharacterRangeSelect();
            Character_Choose.Items.Clear();
            Array.Clear(Character, 0, Character.Length);
            CharacterSelect();
        }
        private void Character_Level_TextChanged(object sender, EventArgs e)
        {
            CharacterLevelSelect();
        }
        private void Character_Choose_SelectedIndexChanged(object sender, EventArgs e)
        {
            CharacterLevelSelect();
        }
        private void Character_Check_CheckedChanged(object sender, EventArgs e)
        {
            if (Character_Check.Checked)
            {
                Character_Check.Text = "已突破";
            }
            else
            {
                Character_Check.Text = "未突破";
            }
            CharacterLevelSelect();
            
        }
        /// <summary>
        /// 武器相关查询
        /// </summary>
        public string WeaponNameSelect()
        {
            init = true;
            var col = 1;
            try
            {
                WeaponRange = book.Worksheet("武器索引").RangeUsed();
                switch (Weapon_Type.SelectedIndex)
                {
                    case 0: col = 1; break;
                    case 1: col = 5; break;
                    case 2: col = 9; break;
                    case 3: col = 13; break;
                    case 4: col = 17; break;
                    default: col = 1; break;
                }
                for (int i = 1; i <= WeaponRange.Column(col).CellsUsed().Count(); i++)
                {
                    if (WeaponRange.Cell(i, col).Value.ToString() == Weapon_Type.SelectedItem.ToString())
                    {
                        Weapon[i - 1] = WeaponRange.Cell(i, col + 1).Value.ToString();
                    }
                }
                if (Weapon_Choose.Items.Count == 0)
                {
                    Weapon_Choose.Items.AddRange(Weapon);
                }
                return WeaponRange.Cell(Weapon_Choose.SelectedIndex+1, col + 2).Value.ToString();// Weapon_Choose.SelectedItem.ToString();
            }

            catch (NullReferenceException)
            {
                DialogResult err;
                err = MessageBox.Show("未找到表格文件，或表格文件错误。\n请尝试打开“帮助”项中的部署工具进行修复。", "提示");
                Close();
                return "";
            }
            catch (Exception)
            {
                return Weapon[0].ToString();
            }           
        }
        private void WeaponSelect()
        {
            
            var template = WeaponNameSelect();
            WeaponLevel = book.Worksheet("武器模板").RangeUsed();
            try
            {
                for (int i = 1; i <= WeaponLevel.Row(1).CellsUsed().Count(); i++)
                {
                    if (template == WeaponLevel.Cell(1, i).Value.ToString())
                    {
                        for (int k = 1; k <= 26; k++)
                        {
                            if (Weapon_Level.SelectedItem.ToString() == WeaponLevel.Cell(k, 1).Value.ToString())
                            {
                                Weapon_Result.Text = WeaponLevel.Cell(k, i).Value.ToString();
                            }
                        }
                    }
                }
            }
            catch (NullReferenceException)
            { }
        }
        private void Weapon_Type_SelectedIndexChanged(object sender, EventArgs e)
        {
            Weapon_Choose.Items.Clear();
            Array.Clear(Weapon, 0, Weapon.Length);
            WeaponSelect();
        }
        private void Weapon_Level_SelectedItemChanged(object sender, EventArgs e)
        {
            if(init)
            WeaponSelect();
        }
        private void Weapon_Choose_SelectedIndexChanged(object sender, EventArgs e)
        {
            WeaponSelect();
        }
        /// <summary>
        /// 计算出结果
        /// </summary>
        private void Character_Result_TextChanged(object sender, EventArgs e)
        {
            Result.Text = "输出结果" +Convert.ToString(int.Parse(Character_Result.Text)+ int.Parse(Weapon_Result.Text));
        }
        private void Weapon_Result_TextChanged(object sender, EventArgs e)
        {
            Result.Text = "输出结果" + Convert.ToString(int.Parse(Character_Result.Text) + int.Parse(Weapon_Result.Text));
        }
        /// <summary>
        /// 杂项
        /// </summary>
        public int Output()
        {
            if (canceled)
            {
                return -1;
            }
            else
            {
                return int.Parse(Character_Result.Text) + int.Parse(Weapon_Result.Text);
            }
        }
        private void Confirm_Click(object sender, EventArgs e)
        {
            canceled = false;
            Close();
        }
        private void Cancel_Click(object sender, EventArgs e)
        {
            canceled = true;
            Character_Result.Text = "0";
            Weapon_Result.Text = "0";
            Close();
        }
    }
}
