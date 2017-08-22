using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculadora_6a.Libreria;

namespace Calculadora_6A.Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            metodos misMetodos = new metodos();
            Console.WriteLine(misMetodos.saludo());
            Console.WriteLine(misMetodos.Sumar(20,30));
            Console.WriteLine(misMetodos.Restar(100, 18));
            Console.WriteLine(misMetodos.Dividir(300, 30));
            Console.WriteLine(misMetodos.Multiplicar(20, 200));
            Console.ReadKey();
        }
    }
}
