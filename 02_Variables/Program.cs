using System;

namespace _02_Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region double_degiskenler

            double applePrice = 3.99;
            double bananaPrice = 1.49;
            double orangePrice = 2.99;
            double grapePrice = 4.49;
            double watermelonPrice = 5.99;

            Console.WriteLine(" ***** Meyve Fiyat Listesi ***** ");
            Console.WriteLine(" ");
            Console.WriteLine($"Elma Fiyatı: {applePrice} TL");
            Console.WriteLine($"Muz Fiyatı: {bananaPrice} TL");
            Console.WriteLine($"Portakal Fiyatı: {orangePrice} TL");
            Console.WriteLine($"Üzüm Fiyatı: {grapePrice} TL");
            Console.WriteLine($"Karpuz Fiyatı: {watermelonPrice} TL");
            Console.WriteLine(" ");

            double appleAmount = 2.5;
            double bananaAmount = 1.0;
            double orangeAmount = 3.0;
            double grapeAmount = 1.5;
            double watermelonAmount = 4.0;

            Console.WriteLine(" ***** Meyve Miktarları ***** ");
            Console.WriteLine(" ");
            Console.WriteLine($"Elma Miktarı: {appleAmount} kg");
            Console.WriteLine($"Muz Miktarı: {bananaAmount} kg");
            Console.WriteLine($"Portakal Miktarı: {orangeAmount} kg");
            Console.WriteLine($"Üzüm Miktarı: {grapeAmount} kg");
            Console.WriteLine($"Karpuz Miktarı: {watermelonAmount} kg");
            Console.WriteLine(" ");

            Console.WriteLine(" ***** Toplam Fiyat Hesaplama ***** ");
            Console.WriteLine(" ");

            Console.WriteLine($"Alınan Ürün: Elma     -Birim Fiyat: {applePrice} TL -Miktar: {appleAmount} kg -Toplam Tutar: {appleAmount * applePrice} TL");
            Console.WriteLine($"Alınan Ürün: Muz      -Birim Fiyat: {bananaPrice} TL -Miktar: {bananaAmount} kg -Toplam Tutar: {bananaAmount * bananaPrice} TL");
            Console.WriteLine($"Alınan Ürün: Portakal -Birim Fiyat: {orangePrice} TL -Miktar: {orangeAmount} kg -Toplam Tutar: {orangeAmount * orangePrice} TL");
            Console.WriteLine($"Alınan Ürün: Üzüm     -Birim Fiyat: {grapePrice} TL -Miktar: {grapeAmount} kg -Toplam Tutar: {grapeAmount * grapePrice} TL");
            Console.WriteLine($"Alınan Ürün: Karpuz   -Birim Fiyat: {watermelonPrice} TL -Miktar: {watermelonAmount} kg -Toplam Tutar: {watermelonAmount * watermelonPrice} TL");
            Console.WriteLine(" ");

            double totalPrice = (applePrice * appleAmount) + (bananaPrice * bananaAmount) +
                                (orangePrice * orangeAmount) + (grapePrice * grapeAmount) +
                                (watermelonPrice * watermelonAmount);

            Console.WriteLine($"Toplam Fiyat: {totalPrice} TL");
            Console.WriteLine(" ");

            #endregion

            #region char_degiskenler

            char gradeA = 'A';
            Console.WriteLine($"Öğrenci Notu: {gradeA}");

            char gradeB = 'B';
            Console.WriteLine($"Öğrenci Notu: {gradeB}");

            Console.WriteLine(" ");

            #endregion

            #region string_girdisi_alma

            string passengerName;
            Console.Write("Lütfen yolcu adını giriniz:");
            passengerName = Console.ReadLine();

            string passengerSurname;
            Console.Write("Lütfen yolcu soyadını giriniz:");
            passengerSurname = Console.ReadLine();

            string passengerCity;
            Console.Write("Lütfen yolcu şehrini giriniz:");
            passengerCity = Console.ReadLine();

            Console.WriteLine(" ");
            Console.WriteLine("***** Yolcu Bilgileri *****");
            Console.WriteLine(" ");
            Console.WriteLine($"Yolcu Adı: {passengerName}");
            Console.WriteLine($"Yolcu Soyadı: {passengerSurname}");
            Console.WriteLine($"Yolcu Şehri: {passengerCity}");
            Console.WriteLine(" ");

            #endregion

            #region int_alma ve parse_etme

            int shoesPrice = 1000;
            int shirtPrice = 500;
            int pantsPrice = 750;
            int hatPrice = 200;
            int socksPrice = 150;

            Console.WriteLine("***** Giyim Ürünleri Fiyat Listesi *****");
            Console.WriteLine(" ");
            Console.WriteLine($"Ayakkabı Fiyatı: {shoesPrice} TL");
            Console.WriteLine($"Gömlek Fiyatı: {shirtPrice} TL");
            Console.WriteLine($"Pantolon Fiyatı: {pantsPrice} TL");
            Console.WriteLine($"Şapka Fiyatı: {hatPrice} TL");
            Console.WriteLine($"Çorap Fiyatı: {socksPrice} TL");
            Console.WriteLine(" ");

            int shoesAmount;
            Console.Write("Lütfen kaç adet ayakkabı almak istediğinizi giriniz: ");
            shoesAmount = int.Parse(Console.ReadLine());

            int shirtAmount;
            Console.Write("Lütfen kaç adet gömlek almak istediğinizi giriniz: ");
            shirtAmount = int.Parse(Console.ReadLine());

            int pantsAmount;
            Console.Write("Lütfen kaç adet pantolon almak istediğinizi giriniz: ");
            pantsAmount = int.Parse(Console.ReadLine());

            int hatAmount;
            Console.Write("Lütfen kaç adet şapka almak istediğinizi giriniz: ");
            hatAmount = int.Parse(Console.ReadLine());

            int socksAmount;
            Console.Write("Lütfen kaç adet çorap almak istediğinizi giriniz: ");
            socksAmount = int.Parse(Console.ReadLine());
            Console.WriteLine(" ");

            Console.WriteLine("***** Alınan Ürünler ve Toplam Fiyat *****");
            Console.WriteLine(" ");
            Console.WriteLine($"Alınan Ürün: Ayakkabı  - Birim Fiyat: {shoesPrice} TL - Miktar: {shoesAmount} - Toplam Tutar: {shoesAmount * shoesPrice} TL");
            Console.WriteLine($"Alınan Ürün: Gömlek    - Birim Fiyat: {shirtPrice} TL - Miktar: {shirtAmount} - Toplam Tutar: {shirtAmount * shirtPrice} TL");
            Console.WriteLine($"Alınan Ürün: Pantolon  - Birim Fiyat: {pantsPrice} TL - Miktar: {pantsAmount} - Toplam Tutar: {pantsAmount * pantsPrice} TL");
            Console.WriteLine($"Alınan Ürün: Şapka     - Birim Fiyat: {hatPrice} TL - Miktar: {hatAmount} - Toplam Tutar: {hatAmount * hatPrice} TL");
            Console.WriteLine($"Alınan Ürün: Çorap     - Birim Fiyat: {socksPrice} TL - Miktar: {socksAmount} - Toplam Tutar: {socksAmount * socksPrice} TL");
            Console.WriteLine(" ");

            int totalClothingPrice = (shoesPrice * shoesAmount) + (shirtPrice * shirtAmount) +
                                     (pantsPrice * pantsAmount) + (hatPrice * hatAmount) +
                                     (socksPrice * socksAmount);

            Console.WriteLine($"Toplam Giyim Ürünleri Fiyatı: {totalClothingPrice} TL");
            Console.WriteLine(" ");

            #endregion

            #region decimal_alma ve parse_etme

            decimal examGrade1;
            Console.Write("Lütfen 1. sınav notunuzu giriniz: ");
            examGrade1 = decimal.Parse(Console.ReadLine());

            decimal examGrade2;
            Console.Write("Lütfen 2. sınav notunuzu giriniz: ");
            examGrade2 = decimal.Parse(Console.ReadLine());

            decimal examGrade3;
            Console.Write("Lütfen 3. sınav notunuzu giriniz: ");
            examGrade3 = decimal.Parse(Console.ReadLine());

            Console.WriteLine(" ");
            Console.WriteLine("***** Sınav Notları *****");
            Console.WriteLine(" ");
            Console.WriteLine($"1. Sınav Notu: {examGrade1}");
            Console.WriteLine($"2. Sınav Notu: {examGrade2}");
            Console.WriteLine($"3. Sınav Notu: {examGrade3}");
            Console.WriteLine(" ");

            decimal averageGrade = (examGrade1 + examGrade2 + examGrade3) / 3;
            Console.WriteLine($"Ortalama Not: {averageGrade}");
            Console.WriteLine(" ");

            #endregion

            #region char_alma ve parse_etme

            Console.Write("Lütfen cinsiyetinizi giriniz (E/K): ");
            char gender = char.Parse(Console.ReadLine());
            gender = char.ToUpper(gender); // Kullanıcının girdiği harfi büyük harfe çevir
            Console.WriteLine("Seçtiğiniz Cinsiyet: " + gender + ". Onaylıyor musunuz? (Y/N): ");
            char confirmation = char.Parse(Console.ReadLine());
            confirmation = char.ToUpper(confirmation); // Kullanıcının girdiği harfi büyük harfe çevir


            if ( confirmation == 'Y')
            {
                Console.WriteLine("Cinsiyetiniz tarafınızdan onaylandı.");
            }
            else if ( confirmation == 'N')
            {
                Console.WriteLine("Cinsiyetiniz onaylanmadı. Lütfen tekrar deneyiniz.");
            }
            else
            {
                Console.WriteLine("Geçersiz giriş. Lütfen 'Y' veya 'N' giriniz.");
            }

            #endregion

            Console.Read();
        }
    }
}
