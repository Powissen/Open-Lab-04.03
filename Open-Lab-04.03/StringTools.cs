using System;

namespace Open_Lab_04._03_2
{
    public class StringTools
    {
        public string RemoveFirstLast(string original)
        {
            if (original.Length <= 1)
            {
                return original;
            }
            else
            {
                return original.Substring(1, original.Length - 2);
            }
        }
    }
}
