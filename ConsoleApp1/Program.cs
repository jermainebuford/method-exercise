using System;

namespace ConsoleApp1
{
    internal class Program
    {
        public static int Add(int num1, int num2)
        {
            var answer = num1 + num2;
            return answer;


        } 
        public static int Subtract(int num1, int num2)

        {
            var answer = (num1 - num2);
            return answer;
        }
        static void Main(string[] args)
        {
         var answer = Add(1, 2);
            Console.WriteLine(answer);
            var answer2 = Subtract(1, 2);
            Console.WriteLine(answer2);
            Console.WriteLine("what is your name");
            var name = Console.ReadLine();


            Console.WriteLine($"hi {name}. what is your favorite color");
            var color = Console.ReadLine();

            Console.WriteLine($"{color} is a nice color. what is your favorite animal");
            var animal = Console.ReadLine();

            Console.WriteLine("nice! what is your favorite band");
            var band = Console.ReadLine();

            //name = jermaine
            //color = red
            //animal = dog
            //band = slipkont

            Console.WriteLine($"name { name}");
            Console.WriteLine($"favorite color {color}");
            Console.WriteLine($"favorite animal {animal}");
            Console.WriteLine($"favorite band {band}");




        }
    }
}
