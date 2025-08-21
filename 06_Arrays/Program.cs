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

            // sort metodu ile diziyi sıralama

            // reverse metodu ile diziyi ters çevirme

            // indexOf metodu ile dizideki bir elemanın indeksini bulma

            // max ve min metotları ile dizinin en büyük ve en küçük elemanlarını bulma

            // contains metodu ile dizide bir elemanın olup olmadığını kontrol etme

            // copy metodu ile diziyi kopyalama

            // clear metodu ile dizinin elemanlarını temizleme

            // fill metodu ile dizinin tüm elemanlarını belirli bir değerle doldurma

            // toString metodu ile diziyi string olarak yazdırma

            // join metodu ile dizinin elemanlarını birleştirme

            // foreach döngüsü ile dizinin elemanlarını yazdırma

            #endregion

            #region kullanıcıdan eleman alma

            #endregion
        }
    }
}
