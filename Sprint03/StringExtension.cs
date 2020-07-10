using System;
using System.Collections.Generic;
using System.Text;

namespace Sprint03
{
    public static class StringExtension
    {
        public static int WordCount(this string str) =>            
            str == "" ? 0 : str.Split(new string[] { ",", ".", "!", "?", ";", ":", " " }, 
                StringSplitOptions.RemoveEmptyEntries).Length;
    }
}
