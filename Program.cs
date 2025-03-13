using System;
using System.Threading;

class Program
{
    static void Main()
    {
        // Tạo hai thread mới
        Thread thread1 = new Thread(PrintThread1);
        Thread thread2 = new Thread(PrintThread2);

        // Bắt đầu chạy các thread
        thread1.Start();
        thread2.Start();

        // In ra từ Main Thread
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine($"Main Thread: {i}");
            Thread.Sleep(500);
        }

        // Đợi các thread kết thúc
        thread1.Join();
        thread2.Join();

        Console.WriteLine("Tất cả các thread đã hoàn thành.");
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
