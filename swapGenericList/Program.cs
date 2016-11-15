using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace swapGenericList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> tal = new List<int>(5);
            Debug.WriteLine(tal);
            Console.ReadKey();
        }
    }
    public class GenericUtl
    {
//        public List<T> reversList<T>()
        public void reversList<T>(List<T> oldlist)
        {
            List<T> svar = new List<T>();
            //List<T> input = this.MemberwiseClone();
            //while (this.reversList)
            foreach (T item in oldlist)
            {
                svar.Insert(0,item);
            }
                       
            //return svar;
        }
    }
}
