internal class Program
{
    private static void Main(string[] args)
    {
        //Doğum tarihi girilen kişinin yaşını hesaplayan uygulamayı yazınız.
        #region Çözüm 1
        //Console.WriteLine("Lütfen doğum tarihini yazınız.");
        //DateTime dogumTarihi = Convert.ToDateTime(Console.ReadLine());
        //TimeSpan sonuc = DateTime.Now - dogumTarihi;
        //Console.WriteLine(sonuc.Days / 365);
        #endregion

        #region Çözüm 2
        //Console.WriteLine("Lütfen doğum tarihini giriniz.");
        //DateTime.Parse(Console.ReadLine());
        //DateTime dogumTarihi = DateTime.Parse(Console.ReadLine());
        //DateTime bugun = DateTime.Now;

        //int yas = bugun.Year - dogumTarihi.Year;

        //if (dogumTarihi > bugun.AddYears(-yas))
        //    yas--;

        //Console.WriteLine(yas);

        #endregion

        #region Çözüm 3
        Console.WriteLine("Lütfen doğum tarihi giriniz.");
        DateTime dogumTarihi = DateTime.Parse(Console.ReadLine());

        int gun = (DateTime.Now - dogumTarihi).Days;

        int yas = gun / 365;
        int kalan = gun % 365;

        Console.WriteLine($"Yaş : {yas} | {yas +1} yaşınızxa kalan gün sayısı : {365 + (yas * 1/ 4) - kalan}");

        #endregion
    }
}