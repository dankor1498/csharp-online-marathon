using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sprint05
{
    class MyUtils
    {
        public static bool ListDictionaryCompare(List<string> list, Dictionary<string, string> dict)
        {
            if (list.Count == 0 && dict.Count == 0) return true;
            if(list.Count >= dict.Count)
                foreach (var item in list)
                {
                    if (!dict.ContainsValue(item))
                        return false;
                }
            else
                foreach (var item in dict)
                {
                    if (!list.Contains(item.Value))
                        return false;
                }
            return true;
        }


        public static Dictionary<string, List<string>> ReverseNotebook(Dictionary<string, string> phonesToNames)
        {
            foreach (var item in phonesToNames)
            {
                Console.WriteLine($"{item.Key} {item.Value}");
            }

            Dictionary<string, List<string>> namesToPhones = new Dictionary<string, List<string>>();
            var namesToPhonesGroup = from item in phonesToNames
                      group item.Key by item.Value;
                      
            foreach (var item in namesToPhonesGroup)
            {
                if(item.Key == null)
                    namesToPhones.Add("", item.ToList());
                else
                    namesToPhones.Add(item.Key, item.ToList());
            }

            return namesToPhones;
        }
    }
}
