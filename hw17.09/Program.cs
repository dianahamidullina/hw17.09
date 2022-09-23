using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw17._09
{
    struct pupil
    {
        public string sername;
        public string name;
        public int id;
        public string data;
        public string category;
        public double volume;
        public int age;
        public void Print()
        {
        Console.WriteLine($"Имя: {name} , Фамилия: {sername} , Возраст: {age} , ID: {id} , Категория алколизма - {category} , Объем выпитого: {volume}"); 
        }
}
    internal class Program
    {
        static void Main(string[] args)
        {

         Console.WriteLine("Упражнение 1");
              pupil pupil = new pupil();
                  pupil.age = 18;
                  pupil.id = 888;
                  pupil.name = "Лиза";
                  string b1 = person.name;
                  pupil sername = "Акулина";
                  pupil.category = "a";
                  pupil.volume = 10;
                  int b = pupil.volume;
                  pupil.Print();


                  pupil pupil = new pupil();
                  pupil.age = 18;
                  pupil.id = 999;
                  pupil.name = "Роман";
                  string c1 = person.name;
                  pupil sername = "Яковлев";
                  pupil.category = "c";
                  pupil.volume = 4;
                  int c1 = pupil.volume;
                  pupil.Print();


                  pupil pupil = new pupil();
                  pupil.age = 18;
                  pupil.id = 777;
                  pupil.name = "Диана";
                  string a1 = person.name;
                  pupil sername = "Хамидуллина";
                  pupil.category = "a";
                  pupil.wolume = 0;
                  int a = pupil.volume;
                  pupil.Print();

                  pupil pupil = new pupil();
                  pupil.age = 18;
                  pupil.id = 1010;
                  pupil.name = "Данил";
                  string d1 = person.name;
                  pupil sername = "Сорнаев";
                  pupil.category = "a";
                  person.kolvo = 12;
                  int d = pupil.volume;
                  pupil.Print();

                  pupil pupil = new pupil();
                  pupil.age = 18;
                  pupil.id = 1011;
                  pupil.name = "Зульфуша";
                  string e1 = person.name;
                  pupil sername = "Ушакова";
                  pupil.category = "a";
                  person.kolvo = 9;
                  int e = pupil.volume;
                  pupil.Print();

                  Console.ReadLine();

                  double colvo = a + b + c + d + e;
                  Console.WriteLine(f);
                  double a3 = (a / colvo) * 100;
                  Console.WriteLine(a3);
                  double b3 = (b / colvo) * 100;
                  double c3 = (c / colvo) * 100;
                  double d3 = (d / colvo) * 100;
                  double e3 = (e / colvo) * 100;
                  Math.Round(a3);
                  Math.Round(b3);
                  Math.Round(c3);
                  Math.Round(d3);
                  Math.Round(e3);
                  Console.WriteLine($"{a3}% выпил {a1}, {b3}% выпил {b1}, {c3}% выпил {c1}, {d3}% выпил {d1}, {e3}% выпил {e1}");

                  Console.ReadLine();

              Console.WriteLine("Упражнение 2");
            Console.WriteLine($"Byte={Byte.MinValue}-{Byte.MaxValue}\n");
            Console.WriteLine($"short: {short.MinValue}-{short.MaxValue}\n");
            Console.WriteLine($"ushort: {{ushort.MinValue}}-{ushort.MaxValue}\n");
            Console.WriteLine($"int: {int.MinValue}-{int.MaxValue}\n");
            Console.WriteLine($"uint: {uint.MinValue}-{uint.MaxValue}\n");
            Console.WriteLine($"long: {long.MinValue}-{long.MaxValue}\n");
            Console.WriteLine($"ulong: {ulong.MinValue}-{ulong.MaxValue}\n");
            Console.WriteLine($"float:{float.MinValue}-{float.MaxValue}\n");
            Console.ReadKey();


            Console.WriteLine("Упражнение 3");
              Console.WriteLine("Введите имя:");
              string name = Console.ReadLine();
              Console.WriteLine("Введите город:");
              string town = Console.ReadLine();
              Console.WriteLine("Введите ваш возраст:");
              int age = int.Parse(Console.ReadLine());
              Console.WriteLine("Введите ваш пин-код:");
              int pin =int.Parse(Console.ReadLine());
                  Console.WriteLine(name + " " + town + " " + age + " " + pin);
                  Console.ReadKey();

            Console.WriteLine("Упражнение 4");
            Console.WriteLine("Введите фамилию :");
            string a = Console.ReadLine();
            Console.WriteLine("Введите имя:");
            string b = Console.ReadLine();
            string ab = $"{a[0]}.{b[0]}.";
            Console.Write($"Инициалы: {ab}");
            Console.ReadKey();

            Console.WriteLine("Упр.5");
            Console.WriteLine("Цена виски в обычных магазинах:");
            int NormPrice = int.Parse(Console.ReadLine());
            Console.WriteLine("Скидка в DutyFre:");
            double salprice = double.Parse(Console.ReadLine());
            Console.WriteLine("Цена на отпуск:");
            int holidayprice = int.Parse(Console.ReadLine());
            double econom = NormPrice - (NormPrice * (1 -( salprice / 100.0)));
            double okyp = holidayprice/econom;
            Console.WriteLine(okyp);
            Console.ReadKey();
            
          Console.WriteLine("Упражнение 6");
            Console.WriteLine("Введите скорость в км/ч:");
            int kmh = int.Parse(Console.ReadLine());
            int msec= ((kmh*1000*100)/3600));
            Console.WriteLine(msec);
            Console.ReadKey();

            Console.WriteLine("Упражнение 7");
            Console.WriteLine("Введите любую заглавную букву:");
            char a = Console.ReadLine();
            
            Console.ReadKey();
          







        }
    }
}
