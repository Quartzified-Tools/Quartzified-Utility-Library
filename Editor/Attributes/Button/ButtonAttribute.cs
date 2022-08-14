using System;
using UnityEngine;

namespace lol
{
    [AttributeUsage(AttributeTargets.All, AllowMultiple = true)]
    public class ButtonAttribute : PropertyAttribute
    {
        public string methodName;

        public ButtonAttribute() { }

        public ButtonAttribute(string _methodName) => methodName = _methodName;
    }
}

