using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// using AsyncAwait;

namespace AsyncAwait
{
    class Program
    {
        static void Main(string[] args)
        {
            //MainAsync mitTask = new AsyncAwait.MainAsync();
            MainAsync().Wait();
            //MainAsync();  // what happens if we don't wait?
        }
        public static async void MainAsync() 
        {
            Console.WriteLine("Call MailAsync");
            await Task.Delay(2000);
            //Task.Delay(2000);  // what happens if we don't await?
            //return ;
        }
    }

}
