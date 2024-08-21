using System;

class Program
{
    static void Main(string[] args)
    {
        bool geçerliGiriş = false;

        while (!geçerliGiriş)
        {
            try
            {
                Console.Write("Lütfen bir sayı giriniz: ");
                int sayi = int.Parse(Console.ReadLine());
                int kare = sayi * sayi;
                Console.WriteLine($"Girdiğiniz sayının karesi: {kare}");
                geçerliGiriş = true; // Geçerli bir giriş yapıldığında döngüyü sonlandırmak için true yapıyoruz
            }
            catch (FormatException)
            {
                Console.WriteLine("Geçersiz giriş! Lütfen bir sayı giriniz.");
            }
            finally
            {
                Console.WriteLine("Try-catch bloğu tamamlandı.");
                // finally bloğu her zaman çalışır, burada temizleme veya loglama işlemleri yapılabilir.
            }
        }
    }
}

