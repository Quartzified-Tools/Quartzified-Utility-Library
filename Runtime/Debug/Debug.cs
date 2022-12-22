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
        public static void LogFormat(Object @object, string format, params object[] args)
        {
            string message = string.Format(format, args);
            Log(@object, message);
        }

        public static void Log(string message)
        {
#if UNITY_EDITOR
            UnityEngine.Debug.Log(LogStart + Utility.Beutify(message, LogType.Log).TrimEnd());
#else
            UnityEngine.Debug.Log(Utility.GetLogTime() + "Debug: " + message);
#endif
        }
        public static void Log(Object @object, string message)
        {
#if UNITY_EDITOR
            UnityEngine.Debug.Log(LogStart + Utility.Beutify(message, LogType.Log).TrimEnd(), @object);
#else
            UnityEngine.Debug.Log(Utility.GetLogTime() + "Debug: " + message,  @object);
#endif
        }

        #endregion

        #region LogWarning

        public static void LogWarningFormat(string format, params object[] args)
        {
            string message = string.Format(format, args);
            LogWarning(message);
        }
        public static void LogWarningFormat(Object @object, string format, params object[] args)
        {
            string message = string.Format(format, args);
            LogWarning(@object, message);
        }

        public static void LogWarning(string message)
        {
#if UNITY_EDITOR
            UnityEngine.Debug.LogWarning(LogWarningStart + Utility.Beutify(message, LogType.Warning).TrimEnd());
#else
            UnityEngine.Debug.LogWarning(Utility.GetLogTime() + "Debug Warning: " + message);
#endif
        }
        public static void LogWarning(Object @object, string message)
        {
#if UNITY_EDITOR
            UnityEngine.Debug.LogWarning(LogWarningStart + Utility.Beutify(message, LogType.Warning).TrimEnd(), @object);
#else
            UnityEngine.Debug.LogWarning(Utility.GetLogTime() + "Debug Warning: " + message, @object);
#endif
        }

        #endregion

        #region LogError

        public static void LogErrorFormat(string format, params object[] args)
        {
            string message = string.Format(format, args);
            LogError(message);
        }
        public static void LogErrorFormat(Object @object, string format, params object[] args)
        {
            string message = string.Format(format, args);
            LogError(@object, message);
        }

        public static void LogError(string message)
        {
#if UNITY_EDITOR
            UnityEngine.Debug.LogError(LogErrorStart + Utility.Beutify(message, LogType.Error).TrimEnd());
#else
            UnityEngine.Debug.LogError(Utility.GetLogTime() + "Debug Error: " + message);
#endif        
        }
        public static void LogError(Object @object, string message)
        {
#if UNITY_EDITOR
            UnityEngine.Debug.LogError(LogErrorStart + Utility.Beutify(message, LogType.Error).TrimEnd(), @object);
#else
            UnityEngine.Debug.LogError(Utility.GetLogTime() + "Debug Error: " + message, @object);
#endif
        }

        #endregion

        public static void LogException(Object @object, System.Exception exception)
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
                return "[" + System.DateTime.Now.ToString("HH:mm:ss") + "] ";
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