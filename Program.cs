using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace prueba
{

 
    public class NumerosPerfectosbuscar 
    {
        public bool encontrado_numero_perfecto(int numero) //meotod para encontrar número perfecto
        {
            int numeros_perfectos = 0; //definimos variable número perfecto

            for (int i = 1; i < numero; i++) //bucle donde iteramos i hasta numero para recorrer en 1 el bucle
            {
                if (numero % i == 0) //condicional para validar que la variable 'numero' sea un número divisible por los números recorridos en i 
                {
                    numeros_perfectos += i;//si se cumple se suman los números hasta el número perfecto
                }
            }
            return numeros_perfectos == numero;//se retorna números perfectos
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            //Se solicita numero minimo y número máximo para recorrer en el rango digitado por el usuario
            Write("ingrese el valor minimo: "); 
            int Minimo = Convert.ToInt32(Console.ReadLine()); 
            Write("ingrese el valor minimo: ");
            int Maximo = Convert.ToInt32(Console.ReadLine());


            NumerosPerfectosbuscar buscar = new NumerosPerfectosbuscar(); //se genera instancia 
            bool encontrado = false; 
            for (int valor_actual = Minimo; valor_actual <= Maximo; valor_actual++) 
            {
                if (buscar.encontrado_numero_perfecto((valor_actual))) //se llama metodo y se valida que variable valor actual se un número perfecto
                {

                
                    WriteLine($"Numeros perfectos del rango minimo: {Minimo} rango máximo:{Maximo}: {valor_actual}"); //se imprime números perfectos
                    encontrado = true;
                }
            }
                if(!encontrado) //se finaliza ciclo en caso de que no se encuentre números perfectos
                {
                    WriteLine("no se encontraaron números perfectos");
                }

            }

        }
    }

