using System.Linq.Expressions;
using System.Threading.Channels;

namespace HomeWork9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int code=0;
            double a = 0;
            double b = 0;
            double result=0;
            Console.WriteLine("Добро пожаловать в CalculateFromEgorIfElse");
            try
            {
                Console.Write("Введи 1-ое число Х = ");
                a = Convert.ToDouble(Console.ReadLine());
                Console.Write("Введи 2-ое число У = ");
                b = Convert.ToDouble(Console.ReadLine());
            }

            catch (Exception ex)
            { Console.WriteLine("Error" + ex.Message); }

            try
            {

                Console.Write("Введите код операции \n 1 – сложение \n 2 – вычитание \n 3 – произведение \n 4 – частное \n Ваш выбор  ");
                code = Convert.ToInt32(Console.ReadLine());
                
                if (code >= 1  && code <= 4)
                {
                    switch (code)
                    {
                        case 1:
                            result = a + b;
                            break;
                        case 2:
                            result = a - b;
                            break;
                        case 3:
                            result = a * b;
                            break;
                        case 4:
                            result = a / b;
                            break;
                    }
                    

                }

                else 
                {
                    Console.WriteLine();
                    Console.WriteLine("Нет операции с указанным номером");
                }
                
            }
            catch (Exception ex) { Console.WriteLine("Error" + ex.Message); }
            Console.WriteLine();
            Console.WriteLine("Результат {0}", result);












        }
    }
}
