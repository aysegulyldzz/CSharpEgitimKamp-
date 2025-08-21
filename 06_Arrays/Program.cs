using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region temel dizi örnekleri

            // değişken türü [] diziAdı = new değişken türü[eleman sayısı];
            int[] sayilar = new int[5]; // 5 elemanlı bir tamsayı dizisi oluşturur.
            sayilar[0] = 1;
            sayilar[1] = 2;
            sayilar[2] = 3;
            sayilar[3] = 4;
            sayilar[4] = 5;

            // dizinin elemanlarını yazdırma
            Console.WriteLine("\nDizi elemanları:");
            Console.WriteLine(sayilar[0]);
            Console.WriteLine(sayilar[1]);
            Console.WriteLine(sayilar[2]);
            Console.WriteLine(sayilar[3]);
            Console.WriteLine(sayilar[4]);

            // dizinin uzunluğunu yazdırma
            Console.WriteLine("\nDizi uzunluğu: " + sayilar.Length);

            string[] colors = new string[3]; // 3 elemanlı bir string dizisi oluşturur.
            colors[0] = "Kırmızı";
            colors[1] = "Yeşil";
            colors[2] = "Mavi";

            Console.WriteLine("\nİkinci indexteki renk: " + colors[2]);
            // colors[3] = "Sarı"; // Bu satır hata verecektir çünkü dizinin boyutu 3'tür.

            string[] animals = { "Kedi", "Köpek", "Kuş" }; // Dizi tanımlarken elemanlarını da atayabilirsiniz.
            Console.WriteLine("\nHayvanlar dizisindeki ilk eleman: " + animals[0]);

            #endregion

            #region dizi elemanlarını listeleme

            string[] fruits = { "Elma", "Armut", "Muz", "Çilek" };
            Console.WriteLine("\nMeyve dizisi elemanları:");
            for (int i = 0; i < fruits.Length; i++)
            {
                Console.WriteLine(fruits[i]);
            }

            char [] letters = { 'A', 'B', 'C', 'D', 'E' };
            Console.WriteLine("\nHarf dizisi elemanları:");
            for (int i = 0; i < letters.Length; i++)
            {
                Console.WriteLine(letters[i]);
            }

            int[] random = { 123, 456, 789, 101112, 131415 };
            for (int i =0; i < random.Length; i++)
            {
                if (random[i] % 2 == 0)
                {
                    Console.WriteLine($"\n{random[i]} sayısı çift bir sayıdır.");
                }
                else
                {
                    Console.WriteLine($"\n{random[i]} sayısı tek bir sayıdır.");
                }
            }

            // max değer bulma örneği

            int[] numbers = { 10, 20, 30, 40, 50 };
            int max = numbers[0]; // İlk elemanı başlangıç değeri olarak alıyoruz.

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] > max)
                {
                    max = numbers[i]; // Daha büyük bir değer bulunursa max'ı güncelliyoruz.
                }
            }

            Console.WriteLine("\nDizinin en büyük elemanı: " + max);

            #endregion

            #region dizi metotları

            // length metodu ile dizinin uzunluğunu bulma
            int[] dizi = { 5, 10, 15, 20, 25 };
            Console.WriteLine("\nDizinin uzunluğu: " + dizi.Length);

            // sort metodu ile diziyi sıralama
            int [] dizi1 = { 165, 510, 415, 920, 125 };
            Array.Sort(dizi1);
            Console.WriteLine("\nSıralanmış dizi: ");
            for (int i = 0; i < dizi1.Length; i++)
            {
                Console.WriteLine(dizi1[i]);
            }

            // reverse metodu ile diziyi ters çevirme
            int [] dizi2 = { 1, 2, 3, 4, 5 };
            Array.Reverse(dizi2);
            Console.WriteLine("\nTers çevrilmiş dizi: ");
            for (int i = 0; i < dizi2.Length; i++)
            {
                Console.WriteLine(dizi2[i]);
            }

            // indexOf metodu ile dizideki bir elemanın indeksini bulma
            string[] dizi3 = { "Elma", "Armut", "Muz", "Çilek" };
            int index = Array.IndexOf(dizi3, "Muz");
            Console.WriteLine("\n'Muz' elemanının indeksi: " + index);
            int index2 = Array.IndexOf(dizi3, "Kivi");
            Console.WriteLine("\n'Kivi' elamanının indeksi: " + index2); // -1 dönecektir çünkü 'Kivi' dizide yok.

            // max ve min metotları ile dizinin en büyük ve en küçük elemanlarını bulma
            int[] dizi4 = { 10, 20, 30, 40, 50 };
            int maxValue = dizi4.Max(); // En büyük elemanı bulma
            int minValue = dizi4.Min(); // En küçük elemanı bulma
            Console.WriteLine("\nDizinin en büyük elemanı: " + maxValue);
            Console.WriteLine("Dizinin en küçük elemanı: " + minValue);

            // contains metodu ile dizide bir elemanın olup olmadığını kontrol etme
            string[] dizi5 = { "Kırmızı", "Yeşil", "Mavi" };
            bool containsRed = dizi5.Contains("Kırmızı");
            bool containsYellow = dizi5.Contains("Sarı");
            Console.WriteLine("\nDizi 'Kırmızı' elemanını içeriyor mu? " + containsRed);
            Console.WriteLine("Dizi 'Sarı' elemanını içeriyor mu? " + containsYellow);

            // copy metodu ile diziyi kopyalama
            int[] dizi6 = { 1, 2, 3, 4, 5 };
            int[] diziKopya = new int[dizi6.Length];
            Array.Copy(dizi6, diziKopya, dizi6.Length);
            Console.WriteLine("\nKopyalanmış dizi elemanları:");
            for (int i = 0; i < diziKopya.Length; i++)
            {
                Console.WriteLine(diziKopya[i]);
            }

            // clear metodu ile dizinin elemanlarını temizleme
            int[] dizi7 = { 1, 2, 3, 4, 5 };
            Array.Clear(dizi7, 0, dizi7.Length); // Dizinin tüm elemanlarını temizler.
            Console.WriteLine("\nTemizlenmiş dizi elemanları:");
            for (int i = 0; i < dizi7.Length; i++)
            {
                Console.WriteLine(dizi7[i]); // Tüm elemanlar 0 olarak yazdırılacaktır.
            }

            // join metodu ile dizinin elemanlarını birleştirme
            string[] dizi9 = { "Elma", "Armut", "Muz" };
            string dizi9String = string.Join(" - ", dizi9); // Diziyi " - " ile birleştirerek yazdırma
            Console.WriteLine("\nDizi elemanları (birleştirilmiş): " + dizi9String);

            // foreach döngüsü ile dizinin elemanlarını yazdırma
            char[] dizi11 = { 'A', 'B', 'C', 'D', 'E' };
            Console.WriteLine("\nDizi elemanları (foreach ile):");
            foreach (char harf in dizi11)
            {
                Console.WriteLine(harf);
            }

            // Array.ForEach metodu ile dizinin elemanlarını yazdırma
            int[] dizi12 = { 1, 2, 3, 4, 5 };
            Console.WriteLine("\nDizi elemanları (Array.ForEach ile):");
            Array.ForEach(dizi12, eleman => Console.WriteLine(eleman));

            // Array.Find metodu ile dizideki bir elemanı bulma
            int[] dizi13 = { 10, 20, 30, 40, 50 };
            int bulunanEleman = Array.Find(dizi13, eleman => eleman > 25); // 25'ten büyük ilk elemanı bulma
            Console.WriteLine("\nDizide 25'ten büyük ilk eleman: " + bulunanEleman);

            // Array.FindAll metodu ile dizideki tüm elemanları bulma
            int[] dizi14 = { 10, 20, 30, 40, 50 };
            int[] bulunanElemanlar = Array.FindAll(dizi14, eleman => eleman > 25); // 25'ten büyük tüm elemanları bulma
            Console.WriteLine("\nDizide 25'ten büyük tüm elemanlar:");
            foreach (int eleman in bulunanElemanlar)
            {
                Console.WriteLine(eleman);
            }

            // Array.Exists metodu ile dizide bir elemanın varlığını kontrol etme
            int[] dizi15 = { 10, 20, 30, 40, 50 };
            bool varMi = Array.Exists(dizi15, eleman => eleman == 30); // 30 elemanının varlığını kontrol etme
            Console.WriteLine("\nDizide 30 elemanı var mı? " + (varMi ? "Evet" : "Hayır"));

            #endregion

            #region kullanıcıdan eleman alma
            string [] cities = new string [3];
            for (int i = 0; i < cities.Length; i++)
            {
                Console.Write($"\nLütfen {i + 1}. şehir için metin giriniz: ");
                cities [i] = Console.ReadLine();
            }

            Console.WriteLine("\nGirilen şehirler:");
            for (int i = 0; i < cities.Length; i++)
            {
                Console.WriteLine(cities[i]);
            }

            #endregion

            #region dizi elemanlarını toplama
            int [] dizi16 = { 10, 54, 86, 92, 108, 115, 142 };
            int sum = 0;

            for (int i = 0; i < dizi16.Length; i++) 
            { 
                sum += dizi16[i]; 
            }

            Console.WriteLine("\nDizideki elemanların toplamı: " + sum);

            #endregion

            #region diziye eleman ekleme

            int [] dizi17 = { 1, 2, 3, 4, 5 };

            Console.Write("\nDiziye eklemek istediğiniz elemanı giriniz: ");
            int newElement;
            while (!int.TryParse(Console.ReadLine(), out newElement))
            {
                Console.WriteLine("Lütfen geçerli bir tamsayı giriniz.");
            }
            int[] newArray = new int[dizi17.Length + 1];
            for (int i = 0; i < dizi17.Length; i++)
            {
                newArray[i] = dizi17[i]; // Eski dizinin elemanlarını yeni diziye kopyala
            }
            newArray[newArray.Length - 1] = newElement; // Yeni elemanı son elemana ekle
            Console.WriteLine("\nYeni dizi elemanları:");
            for (int i = 0; i < newArray.Length; i++)
            {
                Console.WriteLine(newArray[i]);
            }

            #endregion

            Console.Read();
        }
    }
}
