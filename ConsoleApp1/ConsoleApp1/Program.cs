using System;
using System.Text;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            sbyte a = -112;
            short b = 15;
            int c = 522;
            long d = 2522;
            byte e = 8;
            ushort f = 23;
            uint g = 89;
            char h = 'H';
            bool i1 = true;
            float j1 = 25.2f;
            double k = -89.2;
            decimal l = 12.3624m;
            string m = "Hello";
            object n = "n";
            long o = b;   // Неявное приведение short к long
            ushort p = h; // Неявное приведение char к ushort
            decimal q = g;
            double r = a;
            float s = c;
            byte t = (byte) c; // Явное приведение
            long u = (int) b;
            int v = (short) d;
            Object w = c; // Упаковка c
            int x = (int) w; // Распаковка
            var mas = new[] { 8, 12.5, -25, 1236.552 }; // неявно типизированная переменная
            int? y = null;
            // строки
            string string1 = "Первая строка";
            string string2 = "Вторая строка";
            string string3 = "Третья строка";
            Console.WriteLine(String.Compare(string1, string2));
            Console.WriteLine(string1 + string2);
            string string4 = String.Copy(string3);
            Console.WriteLine(string2.Substring(2,8));
            Console.WriteLine(string3.Split(new char[] { ' ' }));
            Console.WriteLine(string1.Insert(7, string2.Substring(0, 7)));
            Console.WriteLine(string3.Remove(4, 5));
            string string5 = "";
            Console.WriteLine(string1 + string5);
            Console.WriteLine(String.Compare(string3, string5));
            StringBuilder string6 = new StringBuilder("Remove", 20);
            string6.Remove(1, 5);
            string6.Insert(0, "NO");
            string6.Append("MAL");
            Console.WriteLine(string6);
            // массивы
            int[,] mas1 = { { 1, 256, 23 }, { 18, 564, 36 } };
            int rows = mas1.GetUpperBound(0) + 1;
            int columns = mas1.Length / rows;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"{mas1[i, j]}\t");
                }
                Console.WriteLine();
            }
            
            string[] subjects = new string[] { "Maths", "Physics", "Literature", "PE" };
            subjects[2] = "PE";
            foreach (string subjects1 in subjects)
                Console.Write("\t" + subjects1);
            Console.WriteLine();
            Console.WriteLine("Длина массива "+subjects.Length );
            int[][] mas2 = new int[3][];
            mas2[0] = new int[2];  
            mas2[1] = new int[3];
            mas2[2] = new int[4];
            foreach (int[] MAS2 in mas2)
            {
                foreach (int mas22 in MAS2)
                    Console.ReadLine();
            }
            foreach (int[] MAS2 in mas2)
            {
                foreach (int mas22 in MAS2)
                    Console.Write("\t" + mas22);
                Console.WriteLine();
            }
            // кортежи
            int age = 0;
            (int, string, char, string, ulong) person = (18, "Julia Korolenok", 'J', "Student", 2);
            Console.WriteLine($" {person}");
            Console.WriteLine(person.Item1);
            Console.WriteLine(person.Item3);
            Console.WriteLine(person.Item4);
            person.Item1 = (int) age;
            (int a, long b) left = (28, 36);
            (byte a, int b) right = (28, 36);
            Console.WriteLine(left == right);
            // локальная функция
            int[] mas3 = new[] { 2, 3, 4, 1 };
            string course = "Курс";
            var element = LocFun(mas3, course);
            Console.WriteLine();
            Console.WriteLine($"Max элемент: {element.Item1}; min элемент: {element.Item2}; Cумма: {element.Item3}; Буква: {element.Item4}");
            (int, int, int, string) LocFun(int[] mas4,string cour)
            {
                (int max, int min, int sum, string first) element1 = (mas4[0], mas4[0], 0, " ");
                for (int i = 0; i < mas4.Length; i++)
                {
                    if (element1.max < mas4[i])
                    {
                        element1.max = mas4[i];
                    }
                }
                for (int i = 0; i < mas4.Length; i++)
                {
                    if (element1.min > mas4[i])
                    {
                        element1.min = mas4[i];
                    }
                }
                for (int i = 0; i < mas4.Length; i++)
                {
                        element1.sum += mas4[i];
                }
                element1.first = cour.Remove(0,1);
                return element1;
            }
        }
    }
}
