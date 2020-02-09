using System;
using System.Collections.Generic;
using System.Text;

namespace less_14
{
    public static class MyExtensions
    {
        public static string StringCutter(this string str)
        {
            string retStr=null;
            char[] arr = str.ToCharArray();
            for (int i = 0; i < 5; i++)
            {
                retStr += str[i]; 
            }
            return retStr;
        }
    }
}
