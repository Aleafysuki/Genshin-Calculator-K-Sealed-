using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Net;
using System.Reflection;
using System.Windows.Forms;
using System.Diagnostics;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;


namespace Genshin_Calc
{
    class ReadFile
    {
        readonly string ConfigPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\Genshin Calculator\";
        public void ReadSettings()
        {
            XmlDocument SettingsReader = new XmlDocument();
            SettingsReader.Load(ConfigPath + "Configuration.Config");
        }
        public bool Download(string url, string localfile)//网上copy来的代码。源地址：https://developer.aliyun.com/article/387040?spm=5176.12901015.0.i12901015.33e3525c2MMIT5
        {
            bool flag = false;
            long startPosition = 0; // 上次下载的文件起始位置
            FileStream writeStream; // 写入本地文件流对象

            // 判断要下载的文件夹是否存在
            if (File.Exists(localfile))
            {

                writeStream = File.OpenWrite(localfile);             // 存在则打开要下载的文件
                startPosition = writeStream.Length;                  // 获取已经下载的长度
                writeStream.Seek(startPosition, SeekOrigin.Current); // 本地文件写入位置定位
            }
            else
            {
                writeStream = new FileStream(localfile, FileMode.Create);// 文件不保存创建一个文件
                startPosition = 0;
            }


            try
            {
                HttpWebRequest myRequest = (HttpWebRequest)HttpWebRequest.Create(url);// 打开网络连接

                if (startPosition > 0)
                {
                    myRequest.AddRange((int)startPosition);// 设置Range值,与上面的writeStream.Seek用意相同,是为了定义远程文件读取位置
                }


                Stream readStream = myRequest.GetResponse().GetResponseStream();// 向服务器请求,获得服务器的回应数据流


                byte[] btArray = new byte[512];// 定义一个字节数据,用来向readStream读取内容和向writeStream写入内容
                int contentSize = readStream.Read(btArray, 0, btArray.Length);// 向远程文件读第一次

                while (contentSize > 0)// 如果读取长度大于零则继续读
                {
                    writeStream.Write(btArray, 0, contentSize);// 写入本地文件
                    contentSize = readStream.Read(btArray, 0, btArray.Length);// 继续向远程文件读取
                }

                //关闭流
                writeStream.Close();
                readStream.Close();

                flag = true;        //返回true下载成功
            }
            catch (Exception)
            {
                writeStream.Close();
                flag = false;       //返回false下载失败
            }

            return flag;
        }


    }
    class ReadArtifacts
    {
        public void CocogoatTool()
        {
            try
            {
                StreamReader reader = File.OpenText("config.json");
                JsonTextReader jsonTextReader = new JsonTextReader(reader);
                JObject jsonObject = (JObject)JToken.ReadFrom(jsonTextReader);
                string server = jsonObject["server"].ToString(); //user ,passwd 类似
                reader.Close();
                //return server;
            }
            catch
            {
                //自己加点
            }
        }
    }
}
namespace LicenseExamination
{
    /// <summary>
    /// 加载第三方库。代码是复制粘贴来的。
    /// 代码来源：https://blog.csdn.net/u012842630/article/details/97416416
    /// </summary>
    public static class LoadResoureDll
    {
        /// <summary> 已加载DLL
        /// </summary>
        private static Dictionary<string, Assembly> LoadedDlls = new Dictionary<string, Assembly>();
        /// <summary> 已处理程序集
        /// </summary>
        private static Dictionary<string, object> Assemblies = new Dictionary<string, object>();
        /// <summary> 在对程序集解释失败时触发
        /// </summary>
        /// <param name="sender">AppDomain</param>
        /// <param name="args">事件参数</param>
        private static Assembly AssemblyResolve(object sender, ResolveEventArgs args)
        {
            try
            {
                //程序集
                Assembly ass;
                //获取加载失败的程序集的全名
                var assName = new AssemblyName(args.Name).FullName;
                //判断Dlls集合中是否有已加载的同名程序集
                if (LoadedDlls.TryGetValue(assName, out ass) && ass != null)
                {
                    LoadedDlls[assName] = null;//如果有则置空并返回
                    return ass;
                }
                else
                {
                    throw new DllNotFoundException(assName);//否则抛出加载失败的异常
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("error:\n位置：AssemblyResolve()！\n描述：" + ex.Message);
                return null;
            }
        }

        /// <summary> 注册资源中的dll
        /// </summary>
        /// <param name="pattern">*表示连续的未知字符,_表示单个未知字符,如*.dll</param>
        public static void RegistDLL(string pattern = "*.dll")
        {
            Directory.GetFiles("", "");
            //获取调用者的程序集
            var ass = new StackTrace(0).GetFrame(1).GetMethod().Module.Assembly;
            //判断程序集是否已经处理
            if (Assemblies.ContainsKey(ass.FullName))
            {
                return;
            }
            //程序集加入已处理集合
            Assemblies.Add(ass.FullName, null);
            //绑定程序集加载失败事件(这里我测试了,就算重复绑也是没关系的)
            AppDomain.CurrentDomain.AssemblyResolve += AssemblyResolve;
            //获取所有资源文件文件名
            var res = ass.GetManifestResourceNames();
            var regex = new Regex("^" + pattern.Replace(".", "\\.").Replace("*", ".*").Replace("_", ".") + "$", RegexOptions.IgnoreCase);
            foreach (var r in res)
            {
                //如果是dll,则加载
                if (regex.IsMatch(r))
                {
                    try
                    {
                        var s = ass.GetManifestResourceStream(r);
                        var bts = new byte[s.Length];
                        s.Read(bts, 0, (int)s.Length);
                        var da = Assembly.Load(bts);
                        //判断是否已经加载
                        if (LoadedDlls.ContainsKey(da.FullName))
                        {
                            continue;
                        }
                        LoadedDlls[da.FullName] = da;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("error:加载dll失败\n位置：RegistDLL()！\n描述：" + ex.Message);
                    }
                }
            }
        }
    }
}
