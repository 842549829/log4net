using System;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net.Config;

namespace LogService
{
    class Program
    {
        static void Main(string[] args)
        {
            //初始化日志文件 
            string state = ConfigurationManager.AppSettings["IsWriteLog"];
            //判断是否开启日志记录
            if (state == "1")
            {
                var path = AppDomain.CurrentDomain.SetupInformation.ApplicationBase + ConfigurationManager.AppSettings["log4net"];
                var fi = new FileInfo(path);
                XmlConfigurator.Configure(fi);
            }

            try
            {
                var x = 0;
                var q = 1 / x;
            }
            catch (Exception e)
            {
                LogHelper.WriteError("xx", e);
                LogHelper.WriteDebug("xx", e);
            }
            LogHelper.WriteInfo("info");
            LogHelper.WriteFatal("fatal");
            LogHelper.WriteWarn("warn");

            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
