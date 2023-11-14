using System;

class QuickSort
{
    static void Main()
    {
        // Sıralanacak dizi
        int[] array = { 12, 11, 13, 5, 6, 7 };

        Console.WriteLine("Sıralanmamış Dizi:");
        PrintArray(array);

        // Hızlı sıralama algoritmasını uygula
        QuickSortAlgorithm(array, 0, array.Length - 1);

        Console.WriteLine("\nSıralanmış Dizi:");
        PrintArray(array);
    }

    // Hızlı sıralama algoritması
    static void QuickSortAlgorithm(int[] arr, int low, int high)
    {
        // Dizide en az iki eleman olduğu sürece devam et
        if (low < high)
        {
            // Pivot elemanının doğru konumunu bul
            int pivotIndex = Partition(arr, low, high);

            // Pivot öncesinde ve sonrasında sıralama işlemlerini tekrarla
            QuickSortAlgorithm(arr, low, pivotIndex - 1);
            QuickSortAlgorithm(arr, pivotIndex + 1, high);
        }
    }

    // Diziyi ikiye bölen ve pivot elemanının doğru konumunu bulan yardımcı fonksiyon
    static int Partition(int[] arr, int low, int high)
    {
        // Pivot olarak dizinin sonundaki elemanı seç
        int pivot = arr[high];

        // İndeksleri başlangıçta düzenle
        int i = low - 1;

        // Dizi üzerinde gez
        for (int j = low; j < high; j++)
        {
            // Pivot'tan küçük olan elemanları sol tarafa yerleştir
            if (arr[j] < pivot)
            {
                i++;
                Swap(ref arr[i], ref arr[j]);
            }
        }

        // Pivot'u doğru konuma yerleştir
        Swap(ref arr[i + 1], ref arr[high]);

        // Pivot'un yeni konumunu döndür
        return i + 1;
    }

    // İki elemanın yerini değiştiren yardımcı fonksiyon
    static void Swap(ref int a, ref int b)
    {
        int temp = a;
        a = b;
        b = temp;
    }

    // Diziyi ekrana yazdıran yardımcı fonksiyon
    static void PrintArray(int[] arr)
    {
        int n = arr.Length;
        for (int i = 0; i < n; ++i)
            Console.Write(arr[i] + " ");

        Console.WriteLine();
    }
}