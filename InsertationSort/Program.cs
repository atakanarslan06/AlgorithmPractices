using System;

public class InsertionSort
{
    public static void Main(string[] args)
    {
        // Sıralanacak dizi
        int[] array = { 12, 11, 13, 5, 6 };

        // Sıralanmamış diziyi ekrana yazdır
        Console.WriteLine("Sıralanmamış Dizi:");
        PrintArray(array);

        // Insertion Sort algoritmasını uygula
        InsertionSortAlgorithm(array);

        // Sıralanmış diziyi ekrana yazdır
        Console.WriteLine("\nSıralanmış Dizi:");
        PrintArray(array);
    }

    // Insertion Sort algoritması
    public static void InsertionSortAlgorithm(int[] arr)
    {
        int n = arr.Length;
        for (int i = 1; i < n; ++i)
        {
            int key = arr[i]; // Karşılaştırılacak elemanı key değişkeninde sakla
            int j = i - 1;

            // Bir önceki elemandan daha küçük olan tüm elemanları kaydır
            while (j >= 0 && arr[j] > key)
            {
                arr[j + 1] = arr[j]; // Elemanı bir sonraki pozisyona kaydır
                j = j - 1;
            }
            arr[j + 1] = key; // Doğru pozisyona elemanı yerleştir
        }
    }

    // Diziyi ekrana yazdırmak için kullanılan yardımcı fonksiyon
    public static void PrintArray(int[] arr)
    {
        int n = arr.Length;
        for (int i = 0; i < n; ++i)
        {
            Console.Write(arr[i] + " "); // Elemanları ekrana yazdır
        }
        Console.WriteLine();
    }
}
