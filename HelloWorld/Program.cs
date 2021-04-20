using System;
using System.Linq;

namespace SubstringInString
{
    class Program
    {
        static void Main()
        {

            string hayStack = "abcdefdgabcdefgabc";
            string middle = "abc";

            for (int i = 0; i < hayStack.Length - middle.Length + 1; i++)
            {
                if (hayStack.Substring(i, middle.Length).Equals(middle))
                {
                    Console.Write(i + " ");
                }
            }
        }

    }
}