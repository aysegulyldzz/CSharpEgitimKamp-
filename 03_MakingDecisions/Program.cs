using System;

namespace _03_MakingDecisions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region if_else

            // password abcd kontrol

            Console.Write("Şifrenizi giriniz: ");
            string password = Console.ReadLine();

            if (password == "abcd")
                Console.WriteLine("Şifre girişi başarılı.");
            else
                Console.WriteLine("Girdiğiniz şifre yanlış, tekrar girniz.");

            // capital country kontrolü ank-türk & kullanımı

            Console.WriteLine("");
            Console.WriteLine("İpucu");
            Console.WriteLine("Kırmızı beyaz renklere sahip ay yıldızlı bayrağın ait olduğu ülkeye dair sorulan soruları yanıtlayınız:");
            Console.WriteLine(" ");

            Console.Write("Hakkında bilgi verilen ülkenin adını giriniz: ");
            string country = Console.ReadLine();

            Console.Write("Yazmış olduğunuz ülkenin başkentini giriniz: ");
            string capital = Console.ReadLine();

            if ((country == "Türkiye" | country == "türkiye") & (capital == "Ankara" | capital == "ankara"))
                Console.WriteLine("Tebrikler, iki soruya da doğru yanıt verdiniz. Türkiye'nin başkenti Ankara'dır.");
            else
                Console.WriteLine("Ülke veya başkent bilgisi yanlış, lütfen tekrar deneyiniz.");

            // int num kontrolü

            Console.WriteLine("");
            Console.Write("3 Basamaklı Sayı Giriniz: ");
            int num = Convert.ToInt32(Console.ReadLine());

            if (num >= 100 && num <= 999)
                Console.WriteLine("Girdiğiniz sayı 3 basamaklıdır.");
            else
                Console.WriteLine("Girdiğiniz sayı 3 basamaklı değildir.");

            // exam 1-2-3 average 50-70-80-90 vasat-orta-iyi-mükemmel

            Console.WriteLine("");
            Console.Write("1. Sınav Notunuzu Giriniz: ");
            int exam1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("2. Sınav Notunuzu Giriniz: ");
            int exam2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("3. Sınav Notunuzu Giriniz: ");
            int exam3 = Convert.ToInt32(Console.ReadLine());

            int average = (exam1 + exam2 + exam3) / 3;
            Console.WriteLine($"Ortalamanız: {average}");
            Console.Write("Not Aralığına Göre Başarı Durumu: ");

            if (average < 50)
                Console.WriteLine("Vasat");
            else if (average >= 50 && average < 70)
                Console.WriteLine("Orta");
            else if (average >= 70 && average < 80)
                Console.WriteLine("İyi");
            else if (average >= 80 && average < 90)
                Console.WriteLine("Çok İyi");
            else
                Console.WriteLine("Mükemmel");

            // useername admin kontrolü != ile

            Console.WriteLine("");
            Console.Write("Kullanıcı Adınızı Giriniz: ");
            string username = Console.ReadLine();

            if (username != "admin")
                Console.WriteLine("Kullanıcı adınız doğru değil, lütfen yeniden giriş yapınız.");
            else
                Console.WriteLine("Kullanıcı adınız admin, giriş başarılı.");

            #endregion

            #region mod_medyan

            // Ctrl + K + D kodları düzenler

            // 2 num al modunu bulsun

            Console.WriteLine("");
            Console.Write("Birinci Sayıyı Giriniz: ");
            int firstNumber = Convert.ToInt32(Console.ReadLine());

            Console.Write("İkinci Sayıyı Giriniz: ");
            int secondNumber = Convert.ToInt32(Console.ReadLine());

            int modResult = firstNumber % secondNumber;
            Console.WriteLine("");
            Console.WriteLine("Mod işlemi, bir sayının diğerine bölümünden kalan sayıyı verir.");
            Console.WriteLine($"Girdiğiniz sayıların mod işlemi sonucu: {modResult}");

            // parse ile num al çift mi kontrol et

            Console.WriteLine("");
            Console.Write("Bir Sayı Giriniz: ");
            int number = int.Parse(Console.ReadLine());

            if (number % 2 == 0)
                Console.WriteLine("Girdiğiniz sayı çift.");
            else
                Console.WriteLine("Girdiğiniz sayı tek.");

            #endregion

            #region char_ile_karar

            // parse char ile team bul g-f-b

            Console.WriteLine("");
            Console.Write("Takımınızın ilk harfini giriniz: ");
            char team = char.Parse(Console.ReadLine());
            team = char.ToLower(team); // Girilen değeri küçük harfe çevir

            if (team == 'f')
                Console.WriteLine("Takımınız Fenerbahçe.");
            else if (team == 'g')
                Console.WriteLine("Takımınız Galatasaray.");
            else if (team == 'b')
                Console.WriteLine("Takımınız Beşiktaş.");
            else
                Console.WriteLine("Geçersiz takım harfi girdiniz.");

            #endregion

            #region mini_proje

            // restoran kur, yemek detayı ekle, menuItem ile detay ver

            Console.WriteLine("");
            Console.WriteLine("Restoran Menüsüne Hoş Geldiniz!");
            Console.WriteLine("Lütfen listedeki seçeneklerden birini seçiniz:");
            Console.WriteLine("");
            Console.WriteLine("1 - Ana Yemekler");
            Console.WriteLine("2 - İçecekler");
            Console.WriteLine("3 - Tatlılar");
            Console.WriteLine("4 - Çıkış");
            Console.WriteLine("");

            Console.Write("Seçiminizi yapınız (1-4): ");
            int choice = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");

            if (choice == 1)
            {
                Console.WriteLine("*** Ana Yemek Seçenekleri ***");
                Console.WriteLine("1. Tavuk Şiş - 50 TL");
                Console.WriteLine("2. Izgara Köfte - 60 TL");
                Console.WriteLine("3. Beşamel Soslu Kumpir - 55 TL");
            }
            else if (choice == 2)
            {
                Console.WriteLine("*** İçecek Seçenekleri ***");
                Console.WriteLine("1. Ayran - 10 TL");
                Console.WriteLine("2. Şalgam - 12 TL");
                Console.WriteLine("3. Gazoz - 8 TL");
            }
            else if (choice == 3)
            {
                Console.WriteLine("*** Tatlı Seçenekleri ***");
                Console.WriteLine("1. Baklava - 20 TL");
                Console.WriteLine("2. Sütlaç - 15 TL");
                Console.WriteLine("3. Profiterol - 18 TL");
            }
            else if (choice == 4)
            {
                Console.WriteLine("Çıkış yapılıyor...");
            }
            else
            {
                Console.WriteLine("Geçersiz seçim, lütfen tekrar deneyiniz.");
            }

            #endregion

            #region switch_case

            // Months yazdırma

            Console.WriteLine("");
            Console.Write("Lütfen bir ay numarası giriniz (1-12): ");
            int monthNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");

            switch (monthNumber)
            {
                case 1:
                    Console.WriteLine("Ocak");
                    break;
                case 2:
                    Console.WriteLine("Şubat");
                    break;
                case 3:
                    Console.WriteLine("Mart");
                    break;
                case 4:
                    Console.WriteLine("Nisan");
                    break;
                case 5:
                    Console.WriteLine("Mayıs");
                    break;
                case 6:
                    Console.WriteLine("Haziran");
                    break;
                case 7:
                    Console.WriteLine("Temmuz");
                    break;
                case 8:
                    Console.WriteLine("Ağustos");
                    break;
                case 9:
                    Console.WriteLine("Eylül");
                    break;
                case 10:
                    Console.WriteLine("Ekim");
                    break;
                case 11:
                    Console.WriteLine("Kasım");
                    break;
                case 12:
                    Console.WriteLine("Aralık");
                    break;
                default:
                    Console.WriteLine("Geçersiz ay numarası girdiniz.");
                    break;
            }

            #endregion

            #region hesap_makinesi

            // num1-num-2-result-islem

            Console.WriteLine("");
            Console.Write("Birinci Sayıyı Giriniz: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("İkinci Sayıyı Giriniz: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("");
            Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz:");
            Console.WriteLine("1 - Toplama");
            Console.WriteLine("2 - Çıkarma");
            Console.WriteLine("3 - Çarpma");
            Console.WriteLine("4 - Bölme");

            Console.WriteLine("");
            Console.Write("Seçiminizi yapınız (1-4): ");
            int operation = Convert.ToInt32(Console.ReadLine());
            double result = 0;

            switch (operation)
            {
                case 1:
                    result = num1 + num2;
                    Console.WriteLine($"Toplama Sonucu: {result}");
                    break;
                case 2:
                    result = num1 - num2;
                    Console.WriteLine($"Çıkarma Sonucu: {result}");
                    break;
                case 3:
                    result = num1 * num2;
                    Console.WriteLine($"Çarpma Sonucu: {result}");
                    break;
                case 4:
                    if (num2 != 0)
                    {
                        result = num1 / num2;
                        Console.WriteLine($"Bölme Sonucu: {result}");
                    }
                    else
                    {
                        Console.WriteLine("Bir sayıyı sıfıra bölemezsiniz.");
                    }
                    break;
                default:
                    Console.WriteLine("Geçersiz işlem seçimi.");
                    break;
            }

            #endregion

            Console.Read();

        }
    }
}
