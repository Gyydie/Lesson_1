using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson
{
    class Program
    {

        //Архипов Денис

        static void Main(string[] args)
        {

            //Написать программу «Анкета». Последовательно задаются вопросы(имя, фамилия, возраст, рост, вес).В результате вся информация выводится в одну строчку:
            //а) используя склеивание;
            //б) используя форматированный вывод;
            //в) используя вывод со знаком $.



            Console.WriteLine("Введите имя: ");
            string name = Console.ReadLine();

            Console.WriteLine("Введите Фамилию: ");
            string surname = Console.ReadLine();

            Console.WriteLine("Введите возраст: ");
            string age = Console.ReadLine();

            Console.WriteLine("Введите рост: ");
            double h = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите вес: ");
            double m = double.Parse(Console.ReadLine());

            Console.WriteLine("Вас зовут:" + name + " " + age + ",вам " + age + ",ваш рост " + h + " см " + "и весите " + m + "кг");

            Console.WriteLine($"Вас зовут {name} {surname},вам {age} ,ваш рост {h} см и весите {m} кг");




            //Ввести вес и рост человека.Рассчитать и вывести индекс массы тела(ИМТ) по формуле I = m / (h * h); где m — масса тела в килограммах, h — рост в метрах.




            double i = m / ((h / 100) * (h / 100));

            Console.WriteLine($"Вес: {m}\nРост: {h} \nИндекс массы тела: = {i}");



            //а) Написать программу, которая подсчитывает расстояние между точками с координатами x1, y1 и x2,y2 по формуле r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2).Вывести результат, используя спецификатор формата .2f(с двумя знаками после запятой);


            int x1 = 100;
            int y1 = 50;
            int x2 = 40;
            int y2 = 80;

            double r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            Console.WriteLine("Результат: {0:#.##}", r);

            Console.ReadKey();
        }
    }
}
