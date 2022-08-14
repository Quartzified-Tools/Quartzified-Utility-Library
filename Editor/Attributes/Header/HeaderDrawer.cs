using UnityEditor;
using UnityEngine;
using Quartzified.Collections;

namespace Quartzified.EditorAttributes
{
    [CustomPropertyDrawer(typeof(HeaderAttribute))]
    public class HeaderDrawer : DecoratorDrawer
    {
        public int fontSize = 14;

        public override void OnGUI(Rect position)
        {
            if (attribute is not HeaderAttribute target)
                return;

            position = EditorGUI.IndentedRect(position);
            position.yMin += EditorGUIUtility.singleLineHeight - (fontSize * 1.5f);

            GUIStyle style = new GUIStyle(EditorStyles.label);
            style.richText = true;

            GUIContent label = new GUIContent(target.header.Bold().Size(fontSize).SetColor(target.color));
            UnityEngine.Debug.Log(label.ToString());

            EditorGUI.LabelField(position, label, style);
        }

        public override float GetHeight()
        {
            return EditorGUIUtility.singleLineHeight + (fontSize / 1.5f);
        }
    }
}