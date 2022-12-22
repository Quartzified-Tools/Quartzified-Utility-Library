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

            if (target.header.IsNullOrEmpty())
                return;

            position = EditorGUI.IndentedRect(position);

            GUIStyle style = new GUIStyle(EditorStyles.label);
            style.richText = true;

            GUIContent label = new GUIContent(target.header.Bold().Size(target.fontSize).SetColor(target.color));

            EditorGUI.LabelField(position, label, style);
        }

        public override float GetHeight()
        {
            TitleAttribute target = attribute as TitleAttribute;

            if (target.header.IsNullOrEmpty())
                return 0;

            return EditorGUIUtility.singleLineHeight + target.fontSize;
        }
    }
}