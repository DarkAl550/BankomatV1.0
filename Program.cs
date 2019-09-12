using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    class Program
    {
        static void Main(string[] args)
        {
            string n;
           

            Console.WriteLine("Выбирете соответствующий пункт: \na) Добавить карту " + "\nb) Использовать существующую карту\n\nс)Выйти\n");
            n = Console.ReadLine();
            Convert.ToString(n);
            if(n=="a")
            {
                Console.WriteLine("\nДанная функция временно не доступна :(\n");
                /*AddCard ad = new AddCard();
                ad.CardAdd();*/
            }
            if(n=="b")
            {
                CheckCard che = new CheckCard();
                che.CheckNum();
            }
            else
            {
                Console.WriteLine("Нажмите любую клавишу для завершения работы...");
                Console.ReadKey();
            }

            

        }
    }
}
