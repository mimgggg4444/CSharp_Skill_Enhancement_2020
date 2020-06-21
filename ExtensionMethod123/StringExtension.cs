using System;
using System.Collections.Generic;
using System.Text;

namespace ExtensionMethod123
{
    public static class StringExtension
    {
        public static int GetCount(this string message, char[]separators)
        {
            string[] words = message.Split(separators);
            return words.Length;
        }
    }
}
