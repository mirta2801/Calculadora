using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_6a.Libreria
{
    public class metodos
    {
        /// <summary>
        /// Funcion que envia saludo
        /// </summary>
        /// <returns>Cadena de caracteres</returns>
        public string saludo()
        {
            return "hola mundo";
        }
        //realiza la operacion de sumar dos numeros
        //numero1 y numero2 son las variables que almacenan los numeros
        public float Sumar(float numero1, float numero2)
        {
            var resultado = numero1 + numero2;
            return resultado; 
        }
        //realiza la operacion de restar dos numeros
        //num1 y num2 son las variables que almacenan los numeros
        public float Restar(float num1, float num2)
        {
            var resultado = num1 - num2;
            return resultado;
        }
        //realiza la operacion de divicion dos numeros
        //x y yson las variables que almacenan los numeros
        public float Dividir(float x, float y)
        {
            var resultado = x / y;
            return resultado;
        }
        //realiza la operacion de multiplicar dos numeros
        //a y b son las variables que almacenan los numeros
        public float Multiplicar(float a, float b)
        {
            var resultado = a * b;
            return resultado;
        }
    }
}
