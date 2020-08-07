using System;
using System.Collections.Generic;
using System.Reflection;
using System.Reflection.Emit;
using System.Text;

namespace Sprint11
{
    class ReflectMethod
    {
        public class Methods
        {
            public static void Hello(string input) =>
                Console.WriteLine($"Hello:parameter={input}");

            public static void Welcome(string input) =>
                Console.WriteLine($"Welcome:parameter={input}");

            public static void Bye(string input) =>
                Console.WriteLine($"Bye:parameter={input}");
        }

        public static void InvokeMethod(string[] inputsParameters)
        {
            var methods = typeof(Methods).GetMethods(BindingFlags.Static | BindingFlags.Public);

            foreach (var method in methods)
            {
                var parameters = method.GetParameters();
                foreach (var p in inputsParameters)
                {
                    if (parameters.Length == 1 && parameters[0].ParameterType == typeof(String))
                        method.Invoke(null, new object[] { p });
                }
            }
        }
    }
}
