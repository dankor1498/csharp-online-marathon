using System;
using System.Reflection;

namespace Sprint11
{
    class ReflectProperties
    {
        public class TestProperties
        {
            public string FirstName { get; set; }
            internal string LastName { get; set; }
            protected int Age { get; set; }
            private string PhoneNumber { get; set; }
        }

        public static void WriteProperties()
        {
            var properties = typeof(TestProperties).GetProperties(BindingFlags.Public |
                                                                  BindingFlags.Instance | BindingFlags.NonPublic);
            foreach (var prop in properties)
            {
                Console.WriteLine($"Property name: {prop.Name}");
                Console.WriteLine($"Property type: {prop.PropertyType}");
                Console.WriteLine($"Read-Write:    {prop.CanRead | prop.CanWrite}");
                Console.WriteLine($"Accessibility: {GetVisibility(prop.SetMethod)}\n");
            }
        }

        public static string GetVisibility(MethodInfo accessor)
        {
            if (accessor.IsPublic) return "Public";
            else if (accessor.IsPrivate) return "Private";
            else if (accessor.IsFamily) return "Protected";
            else if (accessor.IsAssembly) return "Internal";
            else return "Protected Internal";
        }
    }
}
