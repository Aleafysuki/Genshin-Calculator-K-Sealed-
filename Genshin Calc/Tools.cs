using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Genshin_Calc
{
    class Tools
    {
        public void CharacterPanel()
        {
        }
        public double Defense()
        {
            Defence_Calc DEFForm = new Defence_Calc();
            DEFForm.ShowDialog();
            return DEFForm.ATKAdd();
        }
        public void HP()
        {
        }
    }
}
