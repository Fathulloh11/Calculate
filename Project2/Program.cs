using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Project2
{
    class Programm  
    {
        static void Main(string[] args)
        {
            double firstValue, secondValue;
            string action;
            Console.WriteLine("Amal 1");
            firstValue = double.Parse(Console.ReadLine());

            Console.WriteLine("Amal 2");
            secondValue = double.Parse(Console.ReadLine());
            Console.WriteLine("'+''-''/''*''%'");
            action = Console.ReadLine();

            switch(action)
            {
                case "+":
                Console.WriteLine(firstValue+secondValue);
                    break;

                case "-":
                    Console.WriteLine(firstValue-secondValue);
                    break;
                case "*":
                    Console.WriteLine(firstValue*secondValue);
                    break;
                    case "/":
                    Console.WriteLine(firstValue/secondValue);
                    break;
                    case "%":
                
                    Console.WriteLine(firstValue+secondValue);

                    if(secondValue == 0)
                        Console.WriteLine(0);

                    else
                        Console.WriteLine(firstValue%secondValue);
                    break;
                default:
                    Console.WriteLine("ERoR");
                    break;
            }
            Console.ReadLine(); 
        }
    }
}
