using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    class CheckCard
    {
        string num, pass;

        
        public void CheckNum()
        {
            Console.WriteLine("\nВведите номер карты: ");
            num = Console.ReadLine();

            Console.WriteLine("Введите пин-код: ");
            pass = Console.ReadLine();

            

            if (num == "1234 1234 5678 5678" && pass=="1111") 
            {
                string n;

                Console.WriteLine("\nLoding...\n\n\nКарта присутствует в системе\nLoding...\n\n");
                UsedCard use = new UsedCard();
                use.Use();
                Console.WriteLine("\nВернуться назад?\n\na) Да \nb) Нет");
                n = Console.ReadLine();
                if(n=="a")
                {
                    use.Use();

                }
                use.Use();
                
            }
            if(num == "4321 4321 8765 8765" && pass == "1212")
            {
                string n;

                Console.WriteLine("\n\nLoding...\nКарта присутствует в системе\nLoding...\n\n");
                UsedCard1 use = new UsedCard1();
                use.Use1();
                Console.WriteLine("Вернуться назад? \na) Да \nb) Нет");
                n = Console.ReadLine();
                if (n == "a")
                {
                    use.Use1();

                }
                use.Use1();
            }
            else
            {
                Console.WriteLine("Введены неверные данные!");
            }
        }
    }
}
