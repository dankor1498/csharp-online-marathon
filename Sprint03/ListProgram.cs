using System;
using System.Collections.Generic;
using System.Text;

namespace Sprint03
{
    class ListProgram
    {
        public static List<int> ListWithPositive(List<int> list) => 
            list.FindAll(item => item > 0 && item <= 10);
    }
}
