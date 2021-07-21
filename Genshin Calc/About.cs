using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Genshin_Calc
{
    partial class About : Form
    {
        string url = "https://github.com/Aleafysuki/Genshin-Calculator-By-K_vAE";
        string feature_url;
        string[] feature = new string[8];
        public About()
        {
            InitializeComponent();
            Text = string.Format("关于 {0}", AssemblyTitle);
            labelProductName.Text = string.Format("应用名称： {0}", AssemblyProduct);
            labelVersion.Text = string.Format("版本： {0}", AssemblyVersion);
            labelCopyright.Text = AssemblyCopyright;
            labelCompanyName.Text = "项目地址：" + url;
            labelCompanyName.LinkArea = new LinkArea(5, url.Length);
            //textBoxDescription.Text = AssemblyDescription;
            feature[1] = "1.现在可以自定义备注内容了。\n";
            feature[2] = "2.优化了文本框逻辑，当文本框中的值为0时，可将其设置为最低值。\n";
            feature[3] = "3.修复了阿贝多伤害计算的异常。\n";
            feature[4] = "4.增加了\"关于\"窗体，没错就是你现在看到的这个窗口。\n";
            feature[5] = "";
            feature[6] = "";
            feature[7] = "";
            FeatureLink();
        }

        #region 自定义页面
        private void GitHubLink(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(url);
        }
        private void FeatureDesc()
        {
            textBoxDescription.Clear();
            textBoxDescription.Text += "正在向服务器获取此版本更新内容...";
        }
        private async void FeatureLink()
        {
            //var timestamp = new Timer();
            //timestamp.Start();
            try
            {
                FeatureDesc();
                HttpClient GetGitHubContents = new HttpClient();
                feature_url = "https://github.com/Aleafysuki/Genshin-Calculator-By-K_vAE/releases/tag/" + AssemblyVersion;//"0.2.3.0";//
                string WebpageContent = await GetGitHubContents.GetStringAsync(feature_url);
                var EndStr = "\" />\n    < meta property = \"og:image\"";
                textBoxDescription.Text = GetStr(WebpageContent, "此版本的更新内容：", EndStr);
                //timestamp.
            }
            catch (Exception)
            {
                textBoxDescription.Clear();
                foreach (string Text in feature)
                {
                    if (Text != null)
                    {
                        textBoxDescription.Text += Text;
                    }
                }
            }
        }
        public string GetStr(string Content, string start, string end)
        {
            var posStart = Content.IndexOf(start);
            var posEnd = Content.IndexOf(end);
            return Content.Substring(posStart, posEnd - posStart + end.Length);
        }
        #endregion

        #region 程序集特性访问器

        public string AssemblyTitle
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyTitleAttribute), false);
                if (attributes.Length > 0)
                {
                    AssemblyTitleAttribute titleAttribute = (AssemblyTitleAttribute)attributes[0];
                    if (titleAttribute.Title != "")
                    {
                        return titleAttribute.Title;
                    }
                }
                return System.IO.Path.GetFileNameWithoutExtension(Assembly.GetExecutingAssembly().CodeBase);
            }
        }

        public string AssemblyVersion
        {
            get
            {
                return Assembly.GetExecutingAssembly().GetName().Version.ToString();
            }
        }

        public string AssemblyDescription
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyDescriptionAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyDescriptionAttribute)attributes[0]).Description;
            }
        }

        public string AssemblyProduct
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyProductAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyProductAttribute)attributes[0]).Product;
            }
        }

        public string AssemblyCopyright
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCopyrightAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyCopyrightAttribute)attributes[0]).Copyright;
            }
        }

        public string AssemblyCompany
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCompanyAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyCompanyAttribute)attributes[0]).Company;
            }
        }
        #endregion

        private void okButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
