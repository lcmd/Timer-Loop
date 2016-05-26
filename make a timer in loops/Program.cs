using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading; //added using.System.Threading;

namespace make_a_timer_in_loops
{
    class Program
    {
        static void Main(string[] args)
        {

            for (int hour = 12; hour >= 1; hour--)
            {
                for (int min = 59; min > 1; min--)
                {
                    for (int sec = 59; sec > 0; sec--)
                    {
                        

                        {
                            Console.WriteLine(hour + ":" + min + ":" + sec);
                            Thread.Sleep(1000);

                        }


                    }
                    Console.ReadKey();
                }

            }
        }
    }
}
