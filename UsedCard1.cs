using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    class UsedCard1
    {
        string n, s;
        int m1 = 200;

        public void Use1()
        {
            Console.WriteLine("Выбирети операцию: \na) Состояние счета \nb) Снятие средств\n\nc) Завершить работу");
            n = Console.ReadLine();
            Convert.ToString(n);
            if (n == "a")
            {
                Console.WriteLine(m1 + "руб");
            }
            if (n == "b")
            {
                Console.WriteLine("Введите количество снятия средств");
                s = Console.ReadLine();
                m1 = m1 - Convert.ToInt32(s);
                if (m1 < 0)
                {
                    m1 = m1 + Convert.ToInt32(s);
                    Console.WriteLine("Недостаточно средств!");
                }
                else
                {
                    Console.WriteLine("Операция прошла успешно!");
                }

            }
            if(n=="c")
            {
                System.Environment.Exit(0);

            }
        }
    }
}
