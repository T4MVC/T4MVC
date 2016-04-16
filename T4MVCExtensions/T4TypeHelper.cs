using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace T4MVCExtensions
{
    public static class T4TypeHelper
    {
        public static bool IsT4MVC(this Type t)
        {
            if (t.FullName.StartsWith("T4MVC"))
                return true;

            var attribute = t.GetCustomAttributes(typeof(GeneratedCodeAttribute), false)
                .OfType<GeneratedCodeAttribute>().FirstOrDefault();

            if (attribute != null)
            {
                if (attribute.Tool == "T4MVC")
                    return true;
            }

            if (t.IsNested)
            {
                var parent = t.DeclaringType;
                if (parent != null)
                    return parent.IsT4MVC();
            }

            return false;
        }
    }
}
