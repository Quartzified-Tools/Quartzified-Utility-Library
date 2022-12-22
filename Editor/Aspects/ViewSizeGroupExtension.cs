using UnityEditor;
using System.Reflection;
using System;

namespace Quartzified.Editor.ViewSize
{
    public class ViewSizeGroupExtension
    {
        public enum ViewSizeType { AspectRatio, FixedResolution }

        object groupObj;

        public ViewSizeGroupExtension(GameViewSizeGroupType type)
        {
            Assembly assembly = typeof(UnityEditor.Editor).Assembly;

            Type sizes = assembly.GetType("UnityEditor.GameViewSizes");
            Type singleton = typeof(ScriptableSingleton<>).MakeGenericType(sizes);

            MethodInfo group = sizes.GetMethod("GetGroup");

            object instance = singleton.GetProperty("instance").GetValue(null, null);

            groupObj = group.Invoke(instance, new object[] { (int)type });
        }

        public int GetCount()
        {
            MethodInfo totalCount = groupObj.GetType().GetMethod("GetTotalCount");
            if (totalCount != null)
            {
                object count = totalCount.Invoke(groupObj, null);
                if (count is int)
                {
                    return (int)count;
                }
            }
            return 0;
        }

        public ViewSizeExtension GetViewSize(int index)
        {
            MethodInfo viewSize = groupObj.GetType().GetMethod("GetGameViewSize");
            if (viewSize != null)
            {
                object view = viewSize.Invoke(groupObj, new object[] { index });
                if (view != null)
                {
                    return new ViewSizeExtension(view);
                }
            }
            return null;
        }

        public ViewSizeExtension GetViewSize(string name)
        {
            int count = GetCount();
            for (int i = 0; i < count; i++)
            {
                ViewSizeExtension view = GetViewSize(i);
                if (name.Equals(view.GetName()))
                {
                    return view;
                }
            }
            return null;
        }

        void AddFixedViewSize(string name, int w, int h)
        {
            Assembly assembly = typeof(UnityEditor.Editor).Assembly;

            Type viewSize = assembly.GetType("UnityEditor.GameViewSize");
            Type type = assembly.GetType("UnityEditor.GameViewSizeType");

            ConstructorInfo constructor = viewSize.GetConstructor(new Type[] { type, typeof(int), typeof(int), typeof(string) });

            object newSize = constructor.Invoke(new object[] { (int)ViewSizeType.FixedResolution, w, h, name });

            groupObj.GetType().GetMethod("AddCustomSize").Invoke(groupObj, new object[] { newSize });
        }

        public void CastFixedSize(string name, int w, int h)
        {
            ViewSizeExtension vs = GetViewSize(name);
            if (vs == null)
            {
                AddFixedViewSize(name, w, h);
            }
            else
            {
                vs.SetFixedSize(w, h);
            }
        }

        public void RemoveViewSize(int index)
        {
            MethodInfo remove = groupObj.GetType().GetMethod("RemoveCustomSize");
            if (remove != null)
            {
                remove.Invoke(groupObj, new object[] { index });
            }
        }

        public bool IsCustomSize(int index)
        {
            MethodInfo isCustomMethod = groupObj.GetType().GetMethod("IsCustomSize");
            if (isCustomMethod != null)
            {
                object val = isCustomMethod.Invoke(groupObj, new object[] { index });
                if (val is bool)
                {
                    return (bool)val;
                }
            }
            return false;
        }

        public void Clear()
        {
            int count = GetCount();
            for (int i = count - 1; i >= 0; i--)
            {
                if (IsCustomSize(i))
                {
                    RemoveViewSize(i);
                }
            }
        }
    }
}