using UnityEngine;

namespace Quartzified
{
    public static class DebugExtension
    {

        #region Log

        public static void LogFormat(this Object @object, string format, params object[] args)
        {
            string message = string.Format(format, args);
            Log(@object, message);
        }

        public static void Log(this Object @object, string message)
        {
            UnityEngine.Debug.Log(message, @object);
        }

        #endregion

        #region LogWarning

        public static void LogWarningFormat(this Object @object, string format, params object[] args)
        {
            string message = string.Format(format, args);
            LogWarning(@object, message);
        }

        public static void LogWarning(this Object @object, string message)
        {
            UnityEngine.Debug.LogWarning(message, @object);
        }

        #endregion

        #region LogError

        public static void LogErrorFormat(this Object @object, string format, params object[] args)
        {
            string message = string.Format(format, args);
            LogError(@object, message);
        }
        public static void LogError(this Object @object, string message)
        {
            UnityEngine.Debug.LogWarning(message, @object);
        }

        #endregion

        public static void LogException(this Object @object, System.Exception exception)
        {
            UnityEngine.Debug.LogException(exception, @object);
        }
    }
}