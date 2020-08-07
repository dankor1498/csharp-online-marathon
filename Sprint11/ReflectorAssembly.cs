using System;
using System.Reflection;

namespace Sprint11
{
    class ReflectorAssembly
    {
        public interface ILookingForBox
        {
            void LookForBox(string input);
        }

        public interface IPackingBox
        {
            void PackBox(string input);
        }

        public class LargeBox
        {
            public static void UnPackingBox(string size) =>
                Console.WriteLine($"I am unpacking {size} box.");

            public static void InBox(string size) =>
                Console.WriteLine($"I am in {size} box.");
        }

        public class Box
        {
           public static void UnPackingBox(string size) => 
               Console.WriteLine($"I am unpacking {size} box.");

           public static void InBox(string size) => 
               Console.WriteLine($"I am in {size} box.");
        }

        public class SmallBox
        {
            public static void UnPackingBox(string size) =>
                Console.WriteLine($"I am unpacking {size} box.");

            public static void InBox(string size) =>
                Console.WriteLine($"I am in {size} box.");
        }

        public static void WriteAssemblies()
        {
            var types = Assembly.GetExecutingAssembly().GetTypes();
            foreach (var type in types)
            {
                if (type.IsClass && type.Name != "Task" && type.Name != "Reflector")
                {
                    Console.WriteLine($"Class: {type.Name}");
                    string size = GetSize(type.Name);
                    foreach (var method in type.GetMethods(BindingFlags.Static | BindingFlags.Public |
                                                           BindingFlags.Instance | BindingFlags.DeclaredOnly))
                    {
                        if(method.Name != "GetSize")
                            Console.WriteLine($"Method: {method.Name}");

                        var parameters = method.GetParameters();

                        if (parameters.Length == 1 && parameters[0].ParameterType == typeof(String))
                            method.Invoke(null, new object[] {size});
                    }
                }
            }

            foreach (var type in types)
            {
                if (type.IsInterface)
                {
                    Console.WriteLine($"Interface: {type.Name}");
                    foreach (var method in type.GetMethods())
                        Console.WriteLine($"Method: {method.Name}");
                }
            }
        }

        public static string GetSize(string typeName)
        {
            return typeName switch
            {
                "LargeBox" => "large",
                "SmallBox" => "small",
                "Box" => "middle",
                _ => ""
            };
        }
    }
}
