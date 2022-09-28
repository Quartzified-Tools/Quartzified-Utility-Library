using System;
using UnityEngine;

namespace Quartzified
{
    public static class Debug
    {
        static string LogStart = "<b><color=#ffffff>Debug:</color></b> ";
        static string LogWarningStart = "<b><color=#ffff00>Debug Warning: </color></b> ";
        static string LogErrorStart = "<b><color=#ff0000>Debug Error:</color></b> ";

        #region Log

        public static void LogFormat(string format, params object[] args)
        {
            string message = string.Format(format, args);
            Log(message);
        }
        public static void LogFormat(UnityEngine.Object @object, string format, params object[] args)
        {
            string message = string.Format(format, args);
            Log(@object, message);
        }

        public static void Log(string message)
        {
            UnityEngine.Debug.Log(LogStart + Utility.Beutify(message, LogType.Log).TrimEnd());
        }
        public static void Log(UnityEngine.Object @object, string message)
        {
            UnityEngine.Debug.Log(LogStart + Utility.Beutify(message, LogType.Log).TrimEnd(), @object);
        }

        #endregion

        #region LogWarning

        public static void LogWarningFormat(string format, params object[] args)
        {
            string message = string.Format(format, args);
            LogWarning(message);
        }
        public static void LogWarningFormat(UnityEngine.Object @object, string format, params object[] args)
        {
            string message = string.Format(format, args);
            LogWarning(@object, message);
        }

        public static void LogWarning(string message)
        {
            UnityEngine.Debug.LogWarning(LogWarningStart + Utility.Beutify(message, LogType.Warning).TrimEnd());
        }
        public static void LogWarning(UnityEngine.Object @object, string message)
        {
            UnityEngine.Debug.LogWarning(LogWarningStart + Utility.Beutify(message, LogType.Warning).TrimEnd(), @object);
        }

        #endregion

        #region LogError

        public static void LogErrorFormat(string format, params object[] args)
        {
            string message = string.Format(format, args);
            LogError(message);
        }
        public static void LogErrorFormat(UnityEngine.Object @object, string format, params object[] args)
        {
            string message = string.Format(format, args);
            LogError(@object, message);
        }

        public static void LogError(string message)
        {
            UnityEngine.Debug.LogError(LogErrorStart + Utility.Beutify(message, LogType.Error).TrimEnd());
        }
        public static void LogError(UnityEngine.Object @object, string message)
        {
            UnityEngine.Debug.LogError(LogErrorStart + Utility.Beutify(message, LogType.Error).TrimEnd(), @object);
        }

        #endregion

        #region ServerLog

        /// <summary>
        /// Method for Headless Debugging (with time stamp)
        /// </summary>
        /// <param name="message"></param>
        public static void ServerLog(string message)
        {
            UnityEngine.Debug.Log(Utility.GetLogTime() + message);
        }

        #endregion

        public static void LogException(UnityEngine.Object @object, System.Exception exception)
        {
            UnityEngine.Debug.LogException(exception, @object);
        }

        static class Utility
        {
            public static string Beutify(string message, LogType logType)
            {
                string result = "";
                string[] splitMessage = message.Split(' ');

                for (int i = 0; i < splitMessage.Length; i++)
                {
                    if (logType == LogType.Log || logType == LogType.Warning)
                    {
                        splitMessage[i] = MakeClear(splitMessage[i]);
                        splitMessage[i] = IncludesNumbers(splitMessage[i]);
                    }
                    else if (logType == LogType.Error)
                    {
                        splitMessage[i] = MakeError(splitMessage[i]);
                    }

                    result += splitMessage[i] + " ";
                }

                return result;
            }

            public static string GetLogTime()
            {
                return "[" + DateTime.Now.ToString("HH:mm:ss") + "] ";
            }

            static string MakeClear(string snippet)
            {
                string temp = snippet;
                if (!int.TryParse(temp, out _))
                {
                    return string.Format("<color=#ffffff>{0}</color>", snippet);
                }
                return snippet;
            }

            static string MakeError(string snippet)
            {
                return string.Format("<color=#ff0000>{0}</color>", snippet);
            }

            static string IncludesNumbers(string snippet)
            {
                string temp = snippet;

                if (int.TryParse(temp, out _))
                {

                    snippet = string.Format("<color=#00ff00>{0}</color>", temp);
                }

                return snippet;
            }
        }
    }

}