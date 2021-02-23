using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите номер билета от 4 до 8 знаков: ");
            bool isChecked = false;
            do
            {
                string num_ticket = Console.ReadLine();
                if (!(int.TryParse(num_ticket, out _)))
                {
                    Console.Write("Номер билета может содержать только цифры, попробуйте еще раз: ");
                    continue;
                }
                    
                else if (num_ticket.Length < 4 || num_ticket.Length > 8)
                {
                    Console.Write("Введенный номер билета не соответствует правилам, пробуйте еще раз: ");
                    continue;
                }
                    
                else if (num_ticket.Length % 2 != 0)
                {
                    num_ticket = "0" + num_ticket;
                }
                for(int i = 0, s1 = 0, s2 = 0; i < num_ticket.Length; i++)
                {
                    
                    if(i < num_ticket.Length / 2)
                    {
                        s1 += int.Parse(num_ticket[i].ToString());
                    } 
                    else
                    {
                        s2 += int.Parse(num_ticket[i].ToString());
                    }
                    if(i == num_ticket.Length - 1)
                    {
                        if(s1 == s2)
                        {
                            Console.WriteLine("Поздравляем, у вас выигрышный билет");
                        }
                        else
                        {
                            Console.WriteLine("К сожалению, ваш билет не выиграл");
                        }
                        //isChecked = true;
                    }
                }
                /*
                 * Debug
                 * Console.WriteLine("======Debug=====");
                 * Console.WriteLine("Итоговый номер: " + num_ticket);
                 * Console.WriteLine("================");
                 */
    
                //Repeating
                Console.WriteLine("================");
                Console.Write("Введите номер билета от 4 до 8 знаков: ");
            } while (!isChecked);
            
                
           
        }
    }
}
