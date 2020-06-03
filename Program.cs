using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestSonarCloud
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = Int16.Parse(Console.ReadLine());
            int b = Int16.Parse(Console.ReadLine());
            int result = Math(ref a,ref b);
            Console.Write(result.ToString());
            Console.ReadLine();

        }

        static int Math(ref int a, ref int b)
        {
            int result = a + b;
            return result;
        }
    }
}
