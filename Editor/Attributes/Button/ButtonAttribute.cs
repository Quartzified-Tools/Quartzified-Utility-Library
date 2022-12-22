using System;
using UnityEngine;

namespace Quartzified.EditorAttributes
{
    [AttributeUsage(AttributeTargets.All, AllowMultiple = true)]
    public class ButtonAttribute : PropertyAttribute
    {
        public string methodName;

        public ButtonAttribute() { }

        public ButtonAttribute(string _methodName) => methodName = _methodName;
    }
}

