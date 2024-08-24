using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncAwait
{
    class Program
    {
        static void Main(string[] args)
        {
            Demo();
            helloworld.hi();
            Console.ReadKey();
        }

        public static async void Demo()
        {
            var watch = new System.Diagnostics.Stopwatch();
            watch.Start();

            //await StartSchoolAssembly();


            //StartSchoolAssembly();
            //TeachClass12();
            //TeachClass11();

            Task.WaitAll(StartSchoolAssembly(), TeachClass11(), TeachClass12());


            watch.Stop();
            Console.WriteLine($"Execution Time: { watch.ElapsedMilliseconds} ms");
        }

        public static async Task StartSchoolAssembly()
        {
            await Task.Run(() =>
            {
                Console.WriteLine("Assembly Started");
                Thread.Sleep(8000);
                Console.WriteLine("Assemply Ended");
            });
        }


        public static async Task TeachClass12()
        {
            await Task.Run(() =>
            {
                Console.WriteLine("Class 12 started");
                Thread.Sleep(3000);
                Console.WriteLine("Class 12 ended");
            });

        }

        public static async Task TeachClass11()
        {
            await Task.Run(() =>
            {
                Console.WriteLine("Class 11 started");
                Thread.Sleep(2000);
                Console.WriteLine("Class 11 ended");
            });

        }
    }
}
