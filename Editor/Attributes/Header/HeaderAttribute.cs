using System;
using UnityEngine;
using Quartzified.UI;

namespace Quartzified.EditorAttributes
{
    [AttributeUsage(AttributeTargets.Field, AllowMultiple = true)]
    public class HeaderAttribute : PropertyAttribute
    {
        public readonly string header;
        public readonly Color color;

        public HeaderAttribute(string header)
        {
            this.header = header;
            this.color = Color.white;
        }

        public HeaderAttribute(string header, string color)
        {
            this.header = header;

            if (ColorUtility.TryParseHtmlString(color, out this.color))
            {
                return;
            }


            this.color = Color.red;
        }
    }

}

