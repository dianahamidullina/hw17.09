using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace tymakov17._09
{
    enum Credits
    {
        Сберегательный,
        Текущий
    }
    struct cash
    {
        public int number;
            public string type;
        public string balance;
        public cash(int number, string type, string balance):
            this()
        {
            this.number= number;
            this.type = type;
            this.balance = balance;

        }
        public void Print()
        {
            Console.WriteLine($"Номер банковского счета: {number}" + "\n" + $"Тип банковского счета:{type}" + "\n" + $"Баланс на банковском счету:{balance}");
        }
        enum VUZ
        {
            KGU=0,
            KAI=1,
            KHTI=2,
        }
        struct worker
        {
            public string name1;
            public int vuz;
            public worker(string name1, int vuz):
                this()
            {
                this.name1 = name1;
                this.vuz = vuz;

            }
            public void Print()
                {
                Console.WriteLine("Информация о работнике:" + "\n" + $"Имя:{name1}" + "\n" + $"ВУЗ:{vuz}");
    }
            
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Упражнение 1");
                foreach(Credits credit in Enum.GetValues(typeof(Credits)))
                {
                    Console.WriteLine("Кредит -{0}, Номер -{1}", credit, (int)credit);
                }
                Console.ReadKey();

                Console.WriteLine("Упражнение 2)");
            cash inf= new cash(87658, "текущий", "20399399$");
            Console.WriteLine(inf);
            Console.ReadKey();


            Console.WriteLine("Упр.3");
                worker Worker1 = new worker("Петрушин Тумак", (int)VUZ.KHTI);
                Console.WriteLine(Worker1);
                worker Worker2 = new worker("Аксаков Борис", (int)VUZ.KAI);
                Console.WriteLine(Worker2);
                worker Worker3 = new worker("Емельянов Игорь", (int)VUZ.KGU);
                Console.WriteLine("P.S.: 1-КХТИ,1-КАИ,1-КГЭУ");
                Console.ReadKey();
            
    }
}
