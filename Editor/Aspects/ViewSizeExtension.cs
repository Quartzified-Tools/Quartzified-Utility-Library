using System.Reflection;

namespace Quartzified.Editor.ViewSize
{
    public class ViewSizeExtension
    {
        object obj;

        public ViewSizeExtension(object _obj) => obj = _obj;

        public string GetName()
        {
            MethodInfo baseText = obj.GetType().GetMethod("get_baseText");

            if (baseText != null)
            {
                object name = baseText.Invoke(obj, null);
                if (name is string)
                {
                    return (string)name;
                }
            }
            return null;
        }

        public void SetFixedSize(int x, int y)
        {
            MethodInfo widthMethod = obj.GetType().GetMethod("set_width");
            if (widthMethod != null)
            {
                widthMethod.Invoke(obj, new object[] { x });
            }

            MethodInfo heightMethod = obj.GetType().GetMethod("set_height");
            if (heightMethod != null)
            {
                heightMethod.Invoke(obj, new object[] { y });
            }
        }
    }
}

