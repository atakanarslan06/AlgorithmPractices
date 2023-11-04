using System;

public class BinarySearch
{
    // İkili arama algoritması için static fonksiyon tanımlanıyor.
    // Dizi ve hedef değer parametre olarak alınıyor.
    public static int BinarySearchAlgorithm(int[] arr, int target)
    {
        // Arama aralığını belirlemek için iki işaretçi: left ve right
        int left = 0;
        int right = arr.Length - 1;

        // Arama aralığı içinde hedef değeri bulana kadar devam eden bir döngü
        while (left <= right)
        {
            // Aralıktaki orta indeksi hesapla
            int mid = left + (right - left) / 2;

            // Orta indeksteki eleman hedef değerle eşitse, indeksi döndür
            if (arr[mid] == target)
            {
                return mid;
            }

            // Eğer orta indeksteki eleman hedef değerden büyükse, arama aralığını sola daralt
            if (arr[mid] > target)
            {
                right = mid - 1;
            }
            // Eğer orta indeksteki eleman hedef değerden küçükse, arama aralığını sağa daralt
            else
            {
                left = mid + 1;
            }
        }

        // Hedef değer dizide bulunamazsa -1 döndür
        return -1;
    }

    // Programın giriş noktası olan Main fonksiyonu
    public static void Main(string[] args)
    {
        // Dizi oluşturuluyor
        int[] arr = {2, 5, 7, 12, 16, 23, 38, 42, 56, 71};
        
        // Aranacak hedef değeri belirle
        int target = 23;

        // İkili arama algoritması ile hedef değeri ara
        int result = BinarySearchAlgorithm(arr, target);

        // Sonucu ekrana yazdır
        if (result != -1)
        {
            Console.WriteLine("Hedef değer " + target + " dizinin " + result + ". indeksinde bulundu.");
        }
        else
        {
            Console.WriteLine("Hedef değer " + target + " dizide bulunamadı.");
        }
    }
}