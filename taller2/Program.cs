using System;
using System.IO;

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
                        Console.WriteLine("El numero que ingresaste es menor");
                    if (num > rand.Next(100))
                        Console.WriteLine("El numero que ingresaste es mayor");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al ingresar dato");
                    GuardarError(ex.Message);
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

     public static void GuardarError(string error)
        {
            string nombreArchivo = "registro de error";
            string formato = ".txt";
            string fecha = DateTime.Now.ToString();
            FileStream Archivo = new FileStream(nombreArchivo + formato, FileMode.Create);
            using (StreamWriter strWrite = new StreamWriter(Archivo))
            {
                strWrite.WriteLine("tiempo sucedio el error: {0}",fecha);
                strWrite.WriteLine("tipo de error: {0}",error);
                strWrite.Close();
            }

        }
     
    }
}
