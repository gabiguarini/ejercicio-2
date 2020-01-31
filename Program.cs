using System;

namespace ejercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int nro1, nro2, result;
            Console.WriteLine("ingrese 1 número");
            nro1=int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese otro número");
            nro2=int.Parse(Console.ReadLine());

            result = nro1 * nro2;
            Console.WriteLine("el producto es: " + result);
            
        }

    }
}
