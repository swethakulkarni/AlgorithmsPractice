using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algorithms
{
    public class ReverseString
    {

        public string ReverseString_Recursion(string input)
        {
            if (input == "")
            {
                return "";
            }
            else
            {
                return ReverseString_Recursion(input.Substring(1))+ input.ToCharArray().ElementAt(0);
            }

        }
    }
}
