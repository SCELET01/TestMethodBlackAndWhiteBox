using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestMethodBlackAndWhiteBox
{
    public class Test
    {
        public double Sum(double a, double b)
        {
            return a + b;
        }
        public double Raznosti(double a, double b)
        {
            return a - b;
        }
        public double Proizv(double a, double b)
        {
            return a * b;
        }
        public double Del(double a, double b)
        {
            return a / b;
        }
        public double Vosved(double a)
        {
            return a * a;
        }
        public double Izvlech(double a)
        {
            return Math.Sqrt(a);
        }
        public double Procent(double a, double b)
        {
            return (a * b) / 100;
        }
        public double Log(double a)
        {
            return Math.Log(a);
        }
        public double Sin(double a)
        {
            return Math.Sin(a);
        }
        public double Ctg(double a)
        {
            return Math.Cos(a) / Math.Sin(a);
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            Test test = new Test();
            Console.WriteLine("Введите операцию:\n" +
                "1. Сложение\n" +
                "2. Вычитание\n" +
                "3. Произведение\n" +
                "4. Деление\n" +
                "5. Возведение в степень\n" +
                "6. Извлечение корня\n" +
                "7. Процент от числа\n" +
                "8. Log\n" +
                "9. Sin\n" +
                "10. Ctg\n");
            int n = Convert.ToInt32(Console.ReadLine());
            switch (n)
            {
                case 1:
                    Console.WriteLine("Ответ: " + test.Sum(Convert.ToDouble(Console.ReadLine()), Convert.ToDouble(Console.ReadLine())));
                    break;
                case 2:
                    Console.WriteLine("Ответ: " + test.Raznosti(Convert.ToDouble(Console.ReadLine()), Convert.ToDouble(Console.ReadLine())));
                    break;
                case 3:
                    Console.WriteLine("Ответ: " + test.Proizv(Convert.ToDouble(Console.ReadLine()), Convert.ToDouble(Console.ReadLine())));
                    break;
                case 4:
                    Console.WriteLine("Ответ: " + test.Del(Convert.ToDouble(Console.ReadLine()), Convert.ToDouble(Console.ReadLine())));
                    break;
                case 5:
                    Console.WriteLine("Ответ: " + test.Vosved(Convert.ToDouble(Console.ReadLine())));
                    break;
                case 6:
                    Console.WriteLine("Ответ: " + test.Izvlech(Convert.ToDouble(Console.ReadLine())));
                    break;
                case 7:
                    Console.WriteLine("Ответ: " + test.Procent(Convert.ToDouble(Console.ReadLine()), Convert.ToDouble(Console.ReadLine())));
                    break;
                case 8:
                    Console.WriteLine("Ответ: " + test.Log(Convert.ToDouble(Console.ReadLine())));
                    break;
                case 9:
                    Console.WriteLine("Ответ: " + test.Sin(Convert.ToDouble(Console.ReadLine())));
                    break;
                case 10:
                    Console.WriteLine("Ответ: " + test.Ctg(Convert.ToDouble(Console.ReadLine())));
                    break;
                default:
                    Console.WriteLine("Такой операции не существует");
                    break;

            }
            Console.ReadKey();
        }
    }
}
