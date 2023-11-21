using System;
using System.Collections.Generic;

class Process
{
    public int ProcessID { get; set; }
    public int BurstTime { get; set; }
}

class ProcessSimulation
{
    static void Main()
    {
        Queue<Process> processQueue = new Queue<Process>(); // İşlem kuyruğu oluşturulur

        // Örnek işlem verileri oluşturulur ve kuyruğa eklenir
        processQueue.Enqueue(new Process { ProcessID = 1, BurstTime = 10 });
        processQueue.Enqueue(new Process { ProcessID = 2, BurstTime = 5 });
        processQueue.Enqueue(new Process { ProcessID = 3, BurstTime = 8 });
        processQueue.Enqueue(new Process { ProcessID = 4, BurstTime = 2 });

        Console.WriteLine("İşlem Sırası:");

        int totalWaitingTime = 0;
        int n = processQueue.Count;

        while (processQueue.Count != 0)
        {
            Process currentProcess = processQueue.Dequeue(); // Kuyruktan bir işlem çıkarılır

            Console.WriteLine("İşlem " + currentProcess.ProcessID + " çalışıyor...");

            totalWaitingTime += totalWaitingTime; // Bekleme süresi toplamı güncellenir

            // İşlem tamamlandıktan sonra diğer işlemler için kuyruğa geri eklenir
            foreach (Process process in processQueue)
            {
                totalWaitingTime += process.BurstTime;
            }
        }

        double averageWaitingTime = (double)totalWaitingTime / n; // Ortalama bekleme süresi hesaplanır
        Console.WriteLine("Ortalama Bekleme Süresi: " + averageWaitingTime);
    }
}
