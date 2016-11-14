using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoDict
{
    class Program
    {
        static void Main(string[] args)
        {
            int z = 32;
            List<int> evenNumber = new List<int>();
            Dictionary<int,bool>  myNum= new Dictionary<int,bool>();
            for (int i = 0; i <= z; i++)
            {
                if (i % 2 == 0)
                {
                    evenNumber.Add(i);
                }
                else
                {

                }
            }
            foreach (var item in evenNumber)
            {
                //Console.WriteLine("Lige = {0}", item);
            }

            //////////////////////////////
            MyNumber x = new MyNumber();
            x.value = 3;

            AddTo(x, 1);

            Console.WriteLine("svar:",x );

            Console.ReadKey();
        }
        static void AddTo(MyNumber x,int y)
        {
            x.value += y;
        }
    }
    public class MyNumber
    {
        public int value;

        public override string ToString()
        {
            return value.ToString();
        }
    }

}
