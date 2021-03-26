using System;
using System.Collections.Generic;
using System.Text;

namespace UglyCode.Variables
{
    public static class Significant
    {
        public static void copyChars(char[] a1, char[] a2)
        {
            for (int i = 0; i < a1.Length; i++)
            {
                a2[i] = a1[i];
            }
        }
    }
}
