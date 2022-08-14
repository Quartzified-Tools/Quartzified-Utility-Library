using UnityEditor;
using UnityEngine;
using Quartzified.Collections;

namespace Quartzified.EditorAttributes
{
    [CustomPropertyDrawer(typeof(TitleAttribute))]
    public class TitleDrawer : DecoratorDrawer
    {
        public override void OnGUI(Rect position)
        {
            if (attribute is not TitleAttribute target)
                return;

            position = EditorGUI.IndentedRect(position);
            position.yMin += EditorGUIUtility.singleLineHeight - (target.fontSize * 1.5f);

            if (target.header.IsNullOrEmpty())
            {
                position.height = target.fontSize / 2;
                EditorGUI.DrawRect(position, target.color);
                return;
            }

            GUIStyle style = new GUIStyle(EditorStyles.label);
            style.richText = true;

            GUIContent label = new GUIContent(target.header.Bold().Size(target.fontSize).SetColor(target.color));
            UnityEngine.Debug.Log(label.ToString());

            EditorGUI.LabelField(position, label, style);
        }

        public override float GetHeight()
        {
            TitleAttribute target = attribute as TitleAttribute;
            return EditorGUIUtility.singleLineHeight + (target.fontSize / 1.5f);
        }
    }
}