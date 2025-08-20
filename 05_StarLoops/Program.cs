using System;

namespace _05_StarLoops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region alt alta 10 yıldız

            int starCount = 10;

            for (int i = 0; i < starCount; i++)
            {
                Console.WriteLine("*");
            }

            Console.WriteLine("");

            #endregion

            #region yan yana 10 yıldız

            int starCount2 = 10;

            for (int i = 0; i < starCount2; i++)
            {
                Console.Write("*");
            }

            Console.WriteLine("");
            Console.WriteLine("");

            #endregion

            #region 10*10'luk kare

            int starCount3 = 10;

            for (int i = 0; i < starCount3; i++)
            {
                for (int j = 0; j < starCount3; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            Console.WriteLine("");

            #endregion

            #region sola yatık üçgen

            int starCount4 = 5;

            for (int i = 0; i < starCount4; i++)
            {
                for (int j = 0; j < i + 1; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            Console.WriteLine("");

            #endregion

            #region sola yatık ters üçgen

            int starCount5 = 5;

            for (int i = 0; i < starCount5; i++)
            {
                for (int j = 0; j < starCount5 - i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            Console.WriteLine("");

            #endregion

            #region ters ve düz dik üçgen

            int starCount6 = 5;

            for (int i = 0; i < starCount6; i++)
            {
                for (int j = 0; j < i + 1; j++)
                { 
                    Console.Write("*"); 
                }
                Console.WriteLine();
            }

            for (int i = 1; i < starCount6; i++)
            {
                for (int j = 0; j < starCount6 - i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            Console.WriteLine("");

            #endregion

            #region baklava dilimi

            int starCount7 = 5; // Baklava diliminin yarı yüksekliği (satır sayısı)

            // Üst kısım (baklavanın üst üçgeni)
            for (int i = 0; i < starCount7; i++)
            {
                // Satır başına gerekli boşlukları yazdır
                for (int j = 0; j < starCount7 - i - 1; j++)
                    Console.Write(" ");
                // Yıldızları yazdır (her satırda tek sayı olacak şekilde)
                for (int k = 0; k < 2 * i + 1; k++)
                    Console.Write("*");
                // Satır sonu
                Console.WriteLine();
            }

            // Alt kısım (baklavanın alt üçgeni)
            for (int i = starCount7 - 2; i >= 0; i--)
            {
                // Satır başına gerekli boşlukları yazdır
                for (int j = 0; j < starCount7 - i - 1; j++)
                    Console.Write(" ");
                // Yıldızları yazdır (her satırda tek sayı olacak şekilde)
                for (int k = 0; k < 2 * i + 1; k++)
                    Console.Write("*");
                // Satır sonu
                Console.WriteLine();
            }

            Console.WriteLine("");

            #endregion

            #region piramit

            int starCount8 = 5;

            for (int i = 0; i < starCount8; i++)
            {
                for (int j = 0; j < starCount8 - i - 1; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= 2 * i + 1; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            Console.WriteLine("");

            #endregion

            #region ters piramit

            int starCount9 = 5;

            // 5 satır için i = 0'dan i < starCount9'a kadar döngü kurulur
            for (int i = 0; i < starCount9; i++)
            {
                // Satır başına boşluklar
                for (int j = 0; j < i; j++)
                {
                    Console.Write(" ");
                }
                // Yıldızlar
                for (int k = 0; k < 2 * (starCount9 - i) - 1; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            #endregion

            Console.Read();
        }
    }
}
