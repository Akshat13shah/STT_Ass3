using System;

namespace STT_CSE_lab10
{
    internal class Sample
    {
        private static int count = 0;
        private int data;

        public Sample(int d)
        {
            data = d;
            count++;
            Console.WriteLine($"Constructor Called | Active Objects: {count}");
        }

        public void Display()
        {
            Console.WriteLine($"Data = {data}");
        }

        ~Sample()
        {
            count--;
            Console.WriteLine($"*** Destructor Called | Active Objects: {count}");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            CreateAndDestroy();

            Console.WriteLine("\nMain() continuing after CreateAndDestroy...");
            Console.WriteLine("Forcing garbage collection again...");

            GC.Collect();
            GC.WaitForPendingFinalizers();

            
            Console.ReadKey();
        }

        static void CreateAndDestroy()
        {
            Sample s1 = new Sample(10);
            Sample s2 = new Sample(20);
            Sample s3 = new Sample(30);

            s1.Display();
            s2.Display();
            s3.Display();

            Console.WriteLine("End of CreateAndDestroy(). Setting to null...");

            s1 = null;
            s2 = null;
            s3 = null;

            GC.Collect();
            GC.WaitForPendingFinalizers();

            Console.WriteLine("Leaving CreateAndDestroy()...");
        }
    }
}
