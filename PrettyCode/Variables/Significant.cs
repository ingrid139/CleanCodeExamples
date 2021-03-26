using System;
using System.Collections.Generic;
using System.Text;

namespace PrettyCode.Variables
{
    public static class Significant
    {
        public static void copyChars(char[] source, char[] destination)
        {
            for (int i = 0; i < source.Length; i++)
            {
                destination[i] = source[i];
            }
        }
    }
}
