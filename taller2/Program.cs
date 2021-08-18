using System;

namespace taller2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int num = 0;
            Random rand = new Random();

            while (rand.Next(100) == num)
            {
                num = Convert.ToInt32(Console.ReadLine());
                if (num < rand.Next(100))
                    Console.WriteLine("El numero es menor");
                if (num > rand.Next(100))
                    Console.WriteLine("El numero es mayor");

            }

            Console.WriteLine("felicidades acerto");
        }
    }
}
