using LicenseExamination;
using System;
using System.Windows.Forms;


namespace Genshin_Calc
{
    static class Program
    {
        
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            
            LoadResoureDll.RegistDLL();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            Application.Run(new Form1());
            Form1 progress = new Form1();
            progress.Calculate();
        }

    }
}
