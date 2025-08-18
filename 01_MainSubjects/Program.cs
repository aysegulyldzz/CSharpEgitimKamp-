using System;

namespace _01_MainSubjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region yazdırma_komutları

            Console.WriteLine(" ***** Yemek Çeşitleri ***** ");
            Console.WriteLine(" ");
            Console.WriteLine("1. Etli Yemekler");
            Console.WriteLine("2. Sebzeli Yemekler");
            Console.WriteLine("3. Hamur İşleri");
            Console.WriteLine("4. Salatalar");
            Console.WriteLine("5. Tatlılar");
            Console.WriteLine("6. İçecekler");
            Console.WriteLine("7. Çorba Çeşitleri");
            Console.WriteLine("8. Kahvaltılıklar");
            Console.WriteLine("9. Aperatifler");
            Console.WriteLine("10. Vegan Yemekler");
            Console.WriteLine("11. Glutensiz Yemekler");
            Console.WriteLine("12. Düşük Karbonhidratlı Yemekler");
            Console.WriteLine("13. Yüksek Proteinli Yemekler");
            Console.WriteLine();

            #endregion

            #region string_degiskenler

            string customerName = "Ahmet";
            string customerSurname = "Yılmaz";
            string customerAddress = "İstanbul, Türkiye";
            string customerPhone = "555-123-4567";
            string customerEmail = "deneme@gmail.com";

            Console.WriteLine("Müşteri Bilgileri:");
            Console.WriteLine();
            Console.WriteLine("**********************************************");
            Console.WriteLine($"Ad-Soyad: {customerName} {customerSurname}");
            Console.WriteLine($"Adres: {customerAddress}");
            Console.WriteLine($"Telefon: {customerPhone}");
            Console.WriteLine($"E-posta: {customerEmail}");
            Console.WriteLine("**********************************************");
            Console.WriteLine();

            string customerName2 = "Ayşe";
            string customerSurname2 = "Demir";
            string customerAddress2 = "Ankara, Türkiye";
            string customerPhone2 = "555-987-6543";
            string customerEmail2 = "test@hotmail.com";

            Console.WriteLine("**********************************************");
            Console.WriteLine($"Ad-Soyad: {customerName2} {customerSurname2}");
            Console.WriteLine($"Adres: {customerAddress2}");
            Console.WriteLine($"Telefon: {customerPhone2}");
            Console.WriteLine($"E-posta: {customerEmail2}");
            Console.WriteLine("**********************************************");
            Console.WriteLine();

            string customerName3 = "Mehmet";
            string customerSurname3 = "Kara";
            string customerAddress3 = "İzmir, Türkiye";
            string customerPhone3 = "555-456-7890";
            string customerEmail3 = "try@gmail.com";

            Console.WriteLine("**********************************************");
            Console.WriteLine($"Ad-Soyad: {customerName3} {customerSurname3}");
            Console.WriteLine($"Adres: {customerAddress3}");
            Console.WriteLine($"Telefon: {customerPhone3}");
            Console.WriteLine($"E-posta: {customerEmail3}");
            Console.WriteLine("**********************************************");
            Console.WriteLine();

            #endregion

            #region int_değişkenler

            int hamburgerPrice = 25;
            int pizzaPrice = 30;
            int pastaPrice = 20;
            int saladPrice = 15;
            int dessertPrice = 10;
            int drinkPrice = 5;
            int soupPrice = 12;

            Console.WriteLine("***** Menü Fiyatları *****");
            Console.WriteLine();
            Console.WriteLine($"Hamburger: {hamburgerPrice} TL");
            Console.WriteLine($"Pizza: {pizzaPrice} TL");
            Console.WriteLine($"Pasta: {pastaPrice} TL");
            Console.WriteLine($"Salata: {saladPrice} TL");
            Console.WriteLine($"Tatlı: {dessertPrice} TL");
            Console.WriteLine($"İçecek: {drinkPrice} TL");
            Console.WriteLine($"Çorba: {soupPrice} TL");
            Console.WriteLine();

            int hamburgerCount = 2;
            int pizzaCount = 1;
            int pastaCount = 0;
            int saladCount = 3;
            int dessertCount = 1;
            int drinkCount = 2;
            int soupCount = 0;

            int totalPrice = (hamburgerPrice * hamburgerCount) + (pizzaPrice * pizzaCount) + (pastaPrice * pastaCount) +
                             (saladPrice * saladCount) + (dessertPrice * dessertCount) + (drinkPrice * drinkCount) +
                             (soupPrice * soupCount);

            Console.WriteLine("***** Sipariş Özeti *****");
            Console.WriteLine();
            Console.WriteLine($"Hamburger: {hamburgerCount} adet x {hamburgerPrice} TL = {hamburgerCount * hamburgerPrice} TL");
            Console.WriteLine($"Pizza: {pizzaCount} adet x {pizzaPrice} TL = {pizzaCount * pizzaPrice} TL");
            Console.WriteLine($"Pasta: {pastaCount} adet x {pastaPrice} TL = {pastaCount * pastaPrice} TL");
            Console.WriteLine($"Salata: {saladCount} adet x {saladPrice} TL = {saladCount * saladPrice} TL");
            Console.WriteLine($"Tatlı: {dessertCount} adet x {dessertPrice} TL = {dessertCount * dessertPrice} TL");
            Console.WriteLine($"İçecek: {drinkCount} adet x {drinkPrice} TL = {drinkCount * drinkPrice} TL");
            Console.WriteLine($"Çorba: {soupCount} adet x {soupPrice} TL = {soupCount * soupPrice} TL");
            Console.WriteLine();
            Console.WriteLine($"Toplam Tutar: {totalPrice} TL");
            Console.WriteLine();

            #endregion

            Console.Read();
        }
    }
}
