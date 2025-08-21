using System;
using System.Collections.Generic;

namespace _07_ForeachLoops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region foreach ile dizi elemanlarını yazdırma
            string[] colors = { "Kırmızı", "Yeşil", "Mavi", "Sarı" };
            Console.WriteLine("Renkler dizisi elemanları:");
            foreach (string color in colors)
            {
                Console.WriteLine(color);
            }

            Console.WriteLine("");

            int [] numbers = { 1, 2, 3, 4, 5 };
            foreach (int number in numbers)
            {
                if (number % 2 == 0)
                {
                    Console.WriteLine($"{number} çift bir sayıdır.");
                }
                else
                {
                    Console.WriteLine($"{number} tek bir sayıdır.");
                }
            }

            Console.WriteLine("");

            int [] randomNumbers = { 10, 20, 30, 40, 50 };
            int sum = 0;

            foreach (int number in randomNumbers)
            {
                sum += number;
            }

            Console.WriteLine($"Rastgele sayılar dizisinin toplamı: {sum}");

            Console.WriteLine("");

            string word = "Merhaba";
            Console.WriteLine("Kelimenin harfleri:");
            foreach (char letter in word)
            {
                Console.WriteLine(letter);
            }

            Console.WriteLine("");

            // Foreach döngüsü ile bir liste elemanlarını yazdırma

            List<string> fruits = new List<string> { "Elma", "Armut", "Muz", "Çilek" };
            Console.WriteLine("Meyve listesi elemanları:");
            foreach (string fruit in fruits)
            {
                Console.WriteLine(fruit);
            }

            Console.WriteLine("");

            // Foreach döngüsü ile bir sözlük elemanlarını yazdırma

            Dictionary<string, int> ages = new Dictionary<string, int>
            {
                { "Ali", 25 },
                { "Ayşe", 30 },
                { "Mehmet", 22 }
            };

            Console.WriteLine("Yaşlar sözlüğü elemanları:");
            foreach (KeyValuePair<string, int> entry in ages)
            {
                Console.WriteLine($"{entry.Key}: {entry.Value} yaşında");
            }

            Console.WriteLine("");

            // Foreach döngüsü ile bir küme elemanlarını yazdırma

            HashSet<string> uniqueNames = new HashSet<string> { "Ahmet", "Fatma", "Emre", "Zeynep" };
            Console.WriteLine("Benzersiz isimler kümesi elemanları:");
            foreach (string name in uniqueNames)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine("");

            // Foreach döngüsü ile bir kuyruk elemanlarını yazdırma

            Queue<string> queue = new Queue<string>();
            queue.Enqueue("Öğrenci 1");
            queue.Enqueue("Öğrenci 2");
            queue.Enqueue("Öğrenci 3");
            Console.WriteLine("Kuyruk elemanları:");
            foreach (string student in queue)
            {
                Console.WriteLine(student);
            }

            Console.WriteLine("");

            // Foreach döngüsü ile bir yığın elemanlarını yazdırma

            Stack<string> stack = new Stack<string>();
            stack.Push("Kitap 1");
            stack.Push("Kitap 2");
            stack.Push("Kitap 3");
            Console.WriteLine("Yığın elemanları:");
            foreach (string book in stack)
            {
                Console.WriteLine(book);
            }

            Console.WriteLine("");

            #endregion

            #region sınav_uygulaması

            Console.WriteLine("\nC# İle Sınav Uygulaması");
            Console.WriteLine("");
            Console.WriteLine("---------------------------");
            Console.WriteLine("");

            // Öğrenci sayısını al
            Console.Write("Sınıfta bulunan öğrenci sayısını giriniz: ");
            int studentCount = Convert.ToInt32(Console.ReadLine());

            // Öğrenci isimlerini ve notlarını saklamak için listeler oluştur
            string[] studentNames = new string[studentCount];
            double[] studentScores = new double[studentCount];
            double avgScore = 0;

            // Öğrenci isimlerini ve notlarını al
            for (int i = 0; i < studentCount; i++)
            {
                Console.Write($"Öğrenci {i + 1} ismini giriniz: ");
                studentNames[i] = Console.ReadLine();

                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"Öğrenci {studentNames[i]} için {j + 1}. sınav notunu giriniz: ");
                    double score = Convert.ToDouble(Console.ReadLine());
                    studentScores[i] += score; // Notları topluyoruz
                    avgScore = studentScores[i] / 3;
                }
                Console.WriteLine("");
            }

            for (int i = 0; i < studentCount; i++)
            {
                Console.WriteLine("---------------------------");

                // Her öğrencinin ortalama notunu hesapla
                Console.WriteLine($"Öğrenci {studentNames[i]} için ortalama not: {avgScore}");
                
                // Notu 60'ın altında olan öğrencileri uyar
                if (avgScore < 60)
                {
                    Console.WriteLine($"Uyarı: {studentNames[i]} ortalama notu 60'ın altında!");
                }
                else
                {
                    Console.WriteLine($"Info: {studentNames[i]} başarılı!");
                }
                Console.WriteLine("---------------------------");
            }

            #endregion

            Console.Read();
        }
    }
}
