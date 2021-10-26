using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateAndCircle
{
    class Program
    {
        //Вариант без статического класса - возможно его достаточно
        //создаю собственный delegate
        delegate double RadiusDelegate(double r);
        static void Main(string[] args)
        {
            //Данные
            Console.WriteLine("Введите радиус:");            
            double radius = Convert.ToDouble(Console.ReadLine());

            //Формирование методов в delegate
            RadiusDelegate @delegate = LengthCircle;
            @delegate += AreaCircle;
            @delegate += VolumeSphere;

            //Принятие double
            @delegate(radius);

            Console.ReadKey();


        }
        public static double LengthCircle(double r)
        {
            double length = 2 * Math.PI * r;
            Console.WriteLine($"Длина окружности равна {length:f2}.");
            return length;
        }
        public static double AreaCircle(double r)
        {
            double area = Math.PI * r * r;
            Console.WriteLine($"Площадь окружности равна {area:f2}.");
            return area;
        }
        public static double VolumeSphere(double r)
        {
            double volume = 4 / 3 * Math.PI * Math.Pow(r, 3);
            Console.WriteLine($"Объем сферы равен {volume:f2}.");
            return volume;
        }
    }

    
}
