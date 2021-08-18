using System;

namespace taller2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int num, intento=0;
            Random rand = new Random();

            do
            {
                try
                {
                    num = Convert.ToInt32(Console.ReadLine());
                    if (num < rand.Next(100))
                        Console.WriteLine("El numero es menor");
                    if (num > rand.Next(100))
                        Console.WriteLine("El numero es mayor");
                }
                catch (Exception)
                {
                    Console.WriteLine("Error al ingresar dato");
                    num = -1;
                }
                finally
                {
                    Console.WriteLine("Intente nuevamente");
                    intento++;
                }

            } while (rand.Next(100) != num);

            Console.WriteLine("felicidades acerto en {0}", intento);
        }
    }
}
