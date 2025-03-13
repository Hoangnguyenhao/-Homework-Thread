using System;
using System.Threading;

class Program
{
    static void Main()
    {
        // Tao hai thread moi
        Thread thread1 = new Thread(PrintThread1);
        Thread thread2 = new Thread(PrintThread2);

        // Bat đau chay cac thread
        thread1.Start();
        thread2.Start();

        // In ra tu Main Thread
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine($"Main Thread: {i}");
            Thread.Sleep(500);
        }

        // Đoi cac thread ket thuc
        thread1.Join();
        thread2.Join();

        Console.WriteLine("Tat ca cac thread đa hoan thanh.");
    }

    static void PrintThread1()
    {
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine($"Thread 1: {i}");
            Thread.Sleep(500);
        }
    }

    static void PrintThread2()
    {
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine($"Thread 2: {i}");
            Thread.Sleep(500);
        }
    }
}
