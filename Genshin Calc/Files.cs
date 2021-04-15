using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.InteropServices;

namespace Genshin_Calc
{
    class Files
    {
        public string IniPath;//IniPath:ini保存路径
        //string            lpAppName           查找关键字的节点名称
        //string            lpKeyName           获取的项名
        //string            lpDefault           指定的项没有找到时返回的默认值
        //StringBuilder     lpReturnedString    指定一个字串缓冲区，长度至少为nSize
        //int               nSize               上一行提到过的nSize
        //string            lpFileName          INI文件完整路径
        [DllImport("kernel32")]//读取ini
        private static extern int GetPrivateProfileString(string lpAppName, string lpKeyName, string lpDefault, StringBuilder lpReturnedString, int nSize, string lpFileName);

        [DllImport("kernel32")]//写入ini
        private static extern int WritePrivateProfileString(string lpApplicationName, string lpKeyName, string lpString, string lpFileName);
        public static string Read(string section, string key, string def, string filePath)
        {
            StringBuilder sb = new StringBuilder(1024);
            GetPrivateProfileString(section, key, def, sb, 1024, filePath);
            return sb.ToString();
        }
        public static int Write(string section, string key, string value, string filePath)
        {
            CheckPath(filePath);
            return WritePrivateProfileString(section, key, value, filePath);
        }
        public static int DeleteSection(string section, string filePath)
        {
            return Write(section, null, null, filePath);
        }
        public static int DeleteKey(string section, string key, string filePath)
        {
            return Write(section, key, null, filePath);
        }
        private static void CheckPath(string path)
        {
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "sys.ini");//在当前程序路径创建
            File.Create(filePath);//创建INI文件
        }
    }
}
