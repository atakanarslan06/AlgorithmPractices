using System;

class LinearSearch
{
    static void Main()
    {
        int[] array = { 2, 4, 7, 1, 9, 6 };

        // Aranacak eleman
        int target = 7;

        Console.WriteLine("Dizi:");
        PrintArray(array);

        // Arama işlemi
        int result = LinearSearchAlgorithm(array, target);

        // Sonucun ekrana yazdırılması
        if (result != -1)
            Console.WriteLine($"\n{target} bulundu indeks: {result}");
        else
            Console.WriteLine($"\n{target} bulunamadı.");
    }

    // Lineer arama algoritması
    static int LinearSearchAlgorithm(int[] arr, int target)
    {
        // Dizi boyunca her elemanı kontrol et
        for (int i = 0; i < arr.Length; i++)
        {
            // Hedef eleman bulunursa indeksi döndür
            if (arr[i] == target)
                return i;
        }

        // Eleman bulunamazsa -1 döndür
        return -1;
    }

    // Diziyi ekrana yazdıran yardımcı fonksiyon
    static void PrintArray(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
            Console.Write(arr[i] + " ");

        Console.WriteLine();
    }
}