﻿internal class Program
{
    private static void Main(string[] args)
    {
        //iki sayının toplamını veren uıygulamayı yazınız.

        //int sayi1 = 10;
        //int sayi2 = 20;

        //int sayi1  = 10, sayi2 = 20;

        //int sonuc =  sayi1 + sayi2;
        //Console.WriteLine(sayi1 + sayi2);

        //Console.WriteLine(sayi1 + sayi2);

        #region Çözüm 2
        Console.WriteLine("Lütfen sayi1 değerini giriniz.");
        int sayi1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Lütfen sayi2 değerini giriniz.");
        int sayi2 = int.Parse(Console.ReadLine());

        Console.WriteLine(sayi1 + sayi2);

        #endregion
    }
}