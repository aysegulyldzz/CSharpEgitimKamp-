using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;

namespace _04_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region for_loop

            // for(x;y;z) -> x: başlangıç y: bitiş z: artış/azalış

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("For Döngüsü: " + i);
            }
            Console.WriteLine("");

            // finish_value al Yaşasın Cumhuriyet yaz

            Console.Write("Lütfen ekrana yazılmasını istediğiniz metni giriniz: ");
            string text = Console.ReadLine();

            Console.Write("Lütfen tekrar etmesini istediğiniz sayıyı giriniz: ");
            int repeat = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i <= repeat; i++)
            {
                Console.WriteLine(text);
            }
            Console.WriteLine("");

            #endregion

            #region for_decision

            // 5 e bölünen sayıları yazdır 100 e kadar
            Console.WriteLine("1 ile 100 arası 5'e Tam Bölünen Sayılar: ");

            for (int i = 0; i <= 100; i++)
            {
                if (i % 5 == 0)
                {
                    Console.Write(i + ",");
                }
            }
            Console.WriteLine("\n");

            // ilk 10 sayının totalvalue'sini yazdır

            int totalValue = 0;

            for (int i = 1; i <= 10; i++)
            {
                totalValue += i;
            }

            Console.WriteLine("İlk 10 Sayının Toplamı: " + totalValue);
            Console.WriteLine("");

            // 20'ye kadar çift sayıların toplamını yazdır

            int evenTotal = 0;

            for (int i = 0; i <= 20; i++)
            {
                if (i % 2 == 0)
                {
                    evenTotal += i;
                }
            }
            Console.WriteLine("0 ile 20 Arası Çift Sayıların Toplamı: " + evenTotal);
            Console.WriteLine("");

            // 50'ye kadar 7'ye tam bölünen sayı countunu yazdır

            int count7 = 0;
            for (int i = 0; i <= 50; i++)
            {
                if (i % 7 == 0)
                {
                    count7++;
                }
            }

            Console.WriteLine("0 ile 50 Arası 7'ye Tam Bölünen Sayıların Sayısı: " + count7);
            Console.WriteLine("");

            // 24 saatte ikiye katlanan bakteri sayısını yazdır

            int hour = 0;
            int bacterium = 1;

            for (int i = 0; i < 24; i++)
            {
                bacterium *= 2;
                hour++;
                Console.WriteLine($"{hour}. Saatte Bakteri Sayısı: {bacterium}");
            }
            Console.WriteLine("");

            #endregion

            #region while_loop

            // while (koşul) { işlemler} -> koşul sağlandığı sürece döngü devam eder

            int count = 0;

            while (count <= 10)
            {
                Console.WriteLine("Merhaba While Loop");
                count++;
            }

            Console.WriteLine("");

            #endregion

            #region while_decision

            // 1'den 100'e kadar olan sayılardan 5'e tam bölünenleri yazdır

            int number = 1;
            while (number <= 100)
            {
                if (number % 5 == 0)
                {
                    Console.WriteLine("5'e Tam Bölünen Sayı: " + number);
                }
                number++;
            }

            Console.WriteLine("");

            // 1'den 100'e kadar olan sayılardan 3'e tam bölünenlerin toplamını yazdır

            int total = 0;
            int num = 1;

            while (num <= 100)
            {
                if (num % 3 == 0)
                {
                    Console.Write(num + ",");
                    total += num;
                }
                num++;
            }

            Console.WriteLine("\n3'e Tam Bölünen Sayıların Toplamı: " + total);

            Console.WriteLine("");

            // 3 basamaklı sayının basamak toplamını yazdır

            Console.Write("Enter your three-digit number: ");
            int input3 = int.Parse(Console.ReadLine());

            if (input3 < 100 || input3 > 999)
            {
                Console.WriteLine("Please enter a valid three-digit number.");
                return;
            }

            int ones = input3 % 10;
            int tens = (input3 / 10) % 10;
            int hundreds = (input3 / 100) % 10;
            int sum3Digits = ones + tens + hundreds;

            Console.WriteLine($"Sum of digits: {sum3Digits}");
            Console.WriteLine("");

            // 4 basamaklı sayının basamak toplamını yazdırma

            Console.Write("Enter your four-digit number: ");
            int input = int.Parse(Console.ReadLine());
            int sum = input % 10 + (input / 10) % 10 + (input / 100) % 10 + (input / 1000) % 10;
            Console.WriteLine($"Your sum of digits: {sum}");
            if (input > 9999) { Console.WriteLine("Your number is too large, so the sum may be incorrect..."); }
            Console.WriteLine("");

            #endregion

            Console.Read();
        }
    }
}
