using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace frmTrackThread
{
    internal class MyThreadClass
    {


        public static void Thread1()
        {
            int y = 0;

            do
            {
                Thread thread = Thread.CurrentThread;
                Console.WriteLine("Name of Thread: " + thread.Name + " = " + y);
                System.Threading.Thread.Sleep(500);
                y++;
            } while (y != 2);
        }

        public static void Thread2()
        {
            int y = 0;

            do
            {
                Thread thread = Thread.CurrentThread;
                Console.WriteLine("Name of Thread: " + thread.Name + " = " + y);
                System.Threading.Thread.Sleep(1500); 
                y++;
            } while (y != 6);
        }
    }
}