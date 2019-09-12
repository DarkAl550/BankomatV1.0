using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    class UsedCard
    {
        string n,s;
        int m=150;

        public void Use()
        {
            Console.WriteLine("Выбирети операцию: \na) Состояние счета \nb) Снятие средств\n\nc) Завершить работу");
            n=Console.ReadLine();
            Convert.ToString(n);
            if(n=="a")
            {
                Console.WriteLine(m + "руб");
            }
            if(n=="b")
            {
                Console.WriteLine("Введите количество снятия средств");
                s=Console.ReadLine();
                m = m- Convert.ToInt16(s);
                if(m<0)
                {
                    m = m + Convert.ToInt16(s);
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
