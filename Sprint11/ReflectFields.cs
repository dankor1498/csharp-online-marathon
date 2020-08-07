using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;

namespace Sprint11
{
    class ReflectFields
    {
        public static string Name;
        public static int MeasureX;
        public static int MeasureY;
        public static int MeasureZ;

        public static void OutputFields()
        {
            foreach (var field in (typeof(ReflectFields)).GetFields())
            {
                Console.WriteLine($"{field.Name} ({field.FieldType.TypeNameOrAlias()}) = {field.GetValue(null)}");
            }
        }
    }

    static class TypeExtension
    {
        private static Dictionary<Type, string> typeAlias = new Dictionary<Type, string>
        {
            { typeof(bool), "bool" },
            { typeof(byte), "byte" },
            { typeof(char), "char" },
            { typeof(decimal), "decimal" },
            { typeof(double), "double" },
            { typeof(float), "float" },
            { typeof(int), "int" },
            { typeof(long), "long" },
            { typeof(object), "object" },
            { typeof(sbyte), "sbyte" },
            { typeof(short), "short" },
            { typeof(string), "string" },
            { typeof(uint), "uint" },
            { typeof(ulong), "ulong" },
        };

        public static string TypeNameOrAlias(this Type type)
        {
            if (typeAlias.TryGetValue(type, out string alias))
                return alias;
            return type.Name;
        }
    }
}
