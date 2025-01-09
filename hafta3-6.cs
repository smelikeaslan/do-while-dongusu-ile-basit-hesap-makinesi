using System;

namespace BasitHesapMakinesi
{
    class Program
    {
        static void Main(string[] args)
        {
            string islem;
            do
            {
                Console.WriteLine("Bir işlem türü seçiniz (+, -, *, /) veya 'çıkış' yazarak çıkış yapınız:");
                islem = Console.ReadLine().ToLower();

                if (islem == "çıkış")
                {
                    break;
                }

                Console.Write("Birinci sayıyı giriniz: ");
                double sayi1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("İkinci sayıyı giriniz: ");
                double sayi2 = Convert.ToDouble(Console.ReadLine());

                double sonuc = 0;
                bool gecerliIslem = true;

                switch (islem)
                {
                    case "+":
                        sonuc = sayi1 + sayi2;
                        break;
                    case "-":
                        sonuc = sayi1 - sayi2;
                        break;
                    case "*":
                        sonuc = sayi1 * sayi2;
                        break;
                    case "/":
                        if (sayi2 != 0)
                        {
                            sonuc = sayi1 / sayi2;
                        }
                        else
                        {
                            Console.WriteLine("Hata: Sıfıra bölme işlemi yapılamaz.");
                            gecerliIslem = false;
                        }
                        break;
                    default:
                        Console.WriteLine("Geçersiz işlem türü. Lütfen geçerli bir işlem türü seçiniz.");
                        gecerliIslem = false;
                        break;
                }

                if (gecerliIslem)
                {
                    Console.WriteLine($"Sonuç: {sonuc}");
                }

            } while (islem != "çıkış");

            Console.WriteLine("Hesap makinesinden çıkılıyor...");
        }
    }
}