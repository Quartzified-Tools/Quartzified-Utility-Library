using UnityEngine;
using UnityEngine.UIElements;


#if UNITY_EDITOR
using System;
using UnityEditor;

namespace lol
{
    [CustomPropertyDrawer(typeof(ButtonAttribute), false)]
    public class ButtonDrawer : PropertyDrawer
    {
        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            Debug.Log("Trying to Render Button");
            string methodName = (attribute as ButtonAttribute).methodName;
            if (string.IsNullOrEmpty(methodName))
            {
                methodName = property.serializedObject.GetIterator().name;
            }

            object target = property.serializedObject.targetObject;
            System.Reflection.MethodInfo method = target.GetType().GetMethod(methodName);

            if (method == null)
            {
                GUI.Label(position, "No method to invoke was found");
                return;
            }

            if (method.GetParameters().Length >= 1)
            {
                GUI.Label(position, "Method must not have parameters!");
                return;
            }

            if (GUI.Button(position, method.Name))
            {
                method.Invoke(target, null);
            }
        }
    }
}


#endif