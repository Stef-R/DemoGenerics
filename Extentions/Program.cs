using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extentions
{
    class Program
    {
        static void Main(string[] args)
        {
            Int32 tal = 234;
            Debug.WriteLine("tal={0} ",tal);
            Debug.WriteLine(tal.Times1000());
            Console.ReadKey();
        }
    }
    public static class MyExtention
    {
        public static Int32 Times1000(this Int32 number)
        {
            return number * 1000;
        }
    }
}
