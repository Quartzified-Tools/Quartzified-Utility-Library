using System;
using UnityEngine;
using Quartzified.UI;

namespace Quartzified.EditorAttributes
{
    [AttributeUsage(AttributeTargets.Field, AllowMultiple = true)]
    public class TitleAttribute : PropertyAttribute
    {
        public readonly string header;
        public readonly int fontSize = 18;
        public readonly Color color = Color.white;

        public TitleAttribute(string header)
        {
            this.header = header;
        }

        public TitleAttribute(string header, string color)
        {
            this.header = header;

            if (ColorUtility.TryParseHtmlString(color, out this.color))
            {
                return;
            }

            this.color = Color.red;
        }

        public TitleAttribute(string header, int fontSize)
        {
            this.header = header;
            this.fontSize = fontSize;
        }
    }

}

