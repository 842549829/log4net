using System;
using log4net;

namespace LogService
{
    /// <summary>  
    /// LogHelper的摘要说明。   
    /// </summary>   
    public class LogHelper
    {
        /// <summary>
        /// 静态只读实体对象info信息
        /// </summary>
        public static readonly ILog Loginfo = LogManager.GetLogger("loginfo");

        /// <summary>
        ///  静态只读实体对象error信息
        /// </summary>
        public static readonly ILog Logerror = LogManager.GetLogger("logerror");

        /// <summary>
        ///  静态只读实体对象debug信息
        /// </summary>
        public static readonly ILog LogDebug = LogManager.GetLogger("logdebug");

        /// <summary>
        ///  静态只读实体对象fatal信息
        /// </summary>
        public static readonly ILog LogFatal = LogManager.GetLogger("logfatal");

        /// <summary>
        ///  静态只读实体对象warn信息
        /// </summary>
        public static readonly ILog LogWarn = LogManager.GetLogger("logwarn");

        /// <summary>
        ///  添加info信息
        /// </summary>
        /// <param name="info">自定义日志内容说明</param>
        public static void WriteInfo(object info)
        {
            try
            {
                if (Loginfo.IsInfoEnabled)
                {
                    Loginfo.Info(info);
                }
            }
            catch { }
        }

        /// <summary>
        /// 添加异常信息
        /// </summary>
        /// <param name="info">自定义日志内容说明</param>
        /// <param name="ex">异常信息</param>
        public static void WriteError(string info, Exception ex)
        {
            try
            {
                if (Logerror.IsDebugEnabled)
                {
                    Logerror.Error(info, ex);
                }
            }
            catch { }
        }

        /// <summary>
        /// 添加Debug信息
        /// </summary>
        /// <param name="info">自定义日志内容说明</param>
        /// <param name="ex">异常信息</param>
        public static void WriteDebug(string info, Exception ex)
        {
            try
            {
                if (LogDebug.IsDebugEnabled)
                {
                    LogDebug.Debug(info, ex);
                }
            }
            catch { }
        }

        /// <summary>
        /// 添加fatal信息
        /// </summary>
        /// <param name="fatal">自定义日志内容说明</param>
        public static void WriteFatal(object fatal)
        {
            try
            {
                if (LogFatal.IsFatalEnabled)
                {
                    LogFatal.Fatal(fatal);
                }
            }
            catch { }
        }

        /// <summary>
        /// 添加warn信息
        /// </summary>
        /// <param name="warn">自定义日志内容说明</param>
        public static void WriteWarn(object warn)
        {
            try
            {
                if (LogWarn.IsWarnEnabled)
                {
                    LogWarn.Warn(warn);
                }
            }
            catch { }
        }
    }
}