using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertStringToSentencecase
{
    class Program
    {
        static string ConvertStringToSentencecase(string str)
        {
            char[] arr = str.ToCharArray();
            arr[0] = char.ToUpper(arr[0]);
            str = arr.ToString();
            return new string(arr);

        }
        static void Main(string[] args)
        {
            string s = "hello world";
            Console.WriteLine(ConvertStringToSentencecase(s));
            Console.ReadLine();
        }
    }
}
