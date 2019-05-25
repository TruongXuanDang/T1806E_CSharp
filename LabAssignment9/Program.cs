using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LabAssignment9
{
    class Program
    {
        static void Main(string[] args)
        {
            RunOnThread("Remain time");
            Thread t = new Thread(RunOnThread);
            Console.ReadKey();
       

        }

        public static void RunOnThread(Object a)
        {
            String s = (String)a;
            for (int i = 10; i >= 0; i--)
            {
                Console.WriteLine(s+"--"+i);
                Thread.Sleep(1000);
            }
            Console.WriteLine("Congratulation!!!");
            
        }
    }
}
