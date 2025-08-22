using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Sonunda parantez () olan yapılara metot denir. Mor küp ile sembolize edilir (kilit de varsa private).
            // Metotlar belirli bir işi yapan kod bloklarıdır, kod tekrarını önlerler.
            // Metotlar PascalCase ile yazılır, çağrılarak kullanılırlar.
            // Sınıflar kendi metotlarımızı oluşturmak için vardır.

            #region void metotlar

            // Geriye değer döndürmeyen metotlardır. İşlem yapar, ekrana yazdırır, dosyaya yazar vb.

            void HelloWorld()
            {
                Console.WriteLine("Hello World");
            }

            HelloWorld(); // Metot çağrısı

            #endregion

            Console.WriteLine();
            Console.WriteLine("******************");
            Console.WriteLine();

            #region string parametreli void

            void Hello(string name)
            {
                Console.WriteLine($"Hello {name}");
            }

            Hello("Engin");
            Hello("Derin");

            #endregion

            Console.WriteLine();
            Console.WriteLine("******************");
            Console.WriteLine();

            #region int parametreli void

            void Square(int number)
            {
                Console.WriteLine($"{number} değerinin karesi: {number * number}");
            }

            Square(3);
            Square(4);

            #endregion

            Console.WriteLine();
            Console.WriteLine("******************");
            Console.WriteLine();

            #region değer döndüren metotlar

            string StudentName()
            {
                return "Engin Demiroğ";
            }

            string student = StudentName();
            Console.WriteLine(student);

            Console.WriteLine(StudentName());

            #endregion

            Console.WriteLine();
            Console.WriteLine("******************");
            Console.WriteLine();

            #region değer döndüren string parametreli metotlar

            string CountryCard(string country, string city)
            {
                string info = $"Country: {country}, City: {city}";
                return info;
            }

            Console.Write("Write your country: ");
            string a = Console.ReadLine();

            Console.Write("Write your city: ");
            string b = Console.ReadLine();

            Console.WriteLine(CountryCard(a, b));

            #endregion

            Console.WriteLine();
            Console.WriteLine("******************");
            Console.WriteLine();

            #region değer döndüren int parametreli metotlar

            int Sum(int num1, int num2)
            {
                int result = num1 + num2;
                return result;
            }

            int total = Sum(3, 5);
            Console.WriteLine(total);

            Console.WriteLine(Sum(5,7));

            #endregion

            Console.WriteLine();
            Console.WriteLine("******************");
            Console.WriteLine();

            #region mini proje uygulaması

            string StudentScore (string name, int exam1, int exam2, int exam3)
            {
                int score = (exam1 + exam2 + exam3) / 3;

                Console.WriteLine($"Student: {name}, Score: {score}");

                if (score >= 50)
                {
                    return "Ortalama ile geçti.";
                }
                else
                {
                    return "Ortalama ile kaldı.";
                }

            }

            Console.WriteLine(StudentScore("Engin", 70, 60, 70));
            Console.WriteLine("");
            Console.WriteLine(StudentScore("Derin", 40, 50, 45));

            #endregion

            Console.Read();
        }
    }
}
