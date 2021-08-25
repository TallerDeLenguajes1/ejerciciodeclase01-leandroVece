using System;

namespace Problema02
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;
            byte result;
            try
            {
                num1 = 30;
                num2 = 60;
                result = Convert.ToByte(num1 * num2);
            }
            catch (Exception)
            {
                Console.WriteLine("La operacion solicitada es demacaido grande para el trabajo selecciondo ¿desea cambiar la operacion?");
            }
            
            Console.ReadLine();
        }
    }
}
