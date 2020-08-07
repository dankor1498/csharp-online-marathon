using System;
using System.Linq;
using System.Reflection;

namespace Sprint11
{
    class ReflectFullClass
    {
        public static void WriteAllInClass(Type type)
        {
            Console.WriteLine($"Hello, {type.Name}!");
            PrintFields(type);
            Console.WriteLine();
            PrintProperties(type);
            Console.WriteLine();
            PrintMethods(type);
            Console.WriteLine();
            PrintInterfaces(type);
        }

        private static void PrintInterfaces(Type type)
        {
            var interfaces = Assembly.GetExecutingAssembly().GetTypes().Where(t => t.IsInterface).ToArray();
            Console.WriteLine($"There are {interfaces.Length} interfaces in {type.Name}:");
            foreach (var intrf in interfaces) Console.Write($"{intrf.Name}, ");
        }

        private static void PrintMethods(Type type)
        {
            var methods = type.GetMethods(BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly)
                .Where(method => !method.IsSpecialName)
                .ToArray();
            Console.WriteLine($"There are {methods.Length} methods in {type.Name}:");
            foreach (var method in methods) Console.Write($"{method.Name}, ");
        }

        private static void PrintProperties(Type type)
        {
            var properties = type.GetProperties();
            Console.WriteLine($"There are {properties.Length} properties in {type.Name}:");
            foreach (var prop in properties) Console.Write($"{prop.Name}, ");
        }

        private static void PrintFields(Type type)
        {
            var fields = type.GetFields();
            Console.WriteLine($"There are {fields.Length} fields in {type.Name}:");
            foreach (var field in fields) Console.Write($"{field.Name}, ");
        }
    }
}
