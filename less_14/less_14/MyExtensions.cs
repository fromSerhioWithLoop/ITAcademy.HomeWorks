using System;
using System.Collections.Generic;
using System.Text;

namespace less_14
{
    public static class MyExtensions
    {   
    /// <summary>
    /// Cut any string for a 5 simbols lenght
    /// </summary>
        public static string StringCutter(this string str)
        {
            string retStr=null;
            for (int i = 0; i < 5; i++)
            {
                retStr += str[i]; 
            }
            return retStr;
        }
    }
}
