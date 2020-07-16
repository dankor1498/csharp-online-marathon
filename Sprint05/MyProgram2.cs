using System;
using System.Collections.Generic;
using System.Text;

namespace Sprint05
{
    class MyProgram2
    {
        public static void SearchKeys(Dictionary<string, string> persons)
        {
            foreach (var p in persons)
                Console.WriteLine(p.Key);
        }

        public static void SearchValues(Dictionary<string, string> persons)
        {
            foreach (var p in persons)
                Console.WriteLine(p.Value);
        }

        public static void SearchAdmin(Dictionary<string, string> persons) 
        {
            foreach (var p in persons)
            {
                if(p.Value == "Admin")
                    Console.WriteLine($"{p.Key} {p.Value}");
            }                
        }            
    }
}
