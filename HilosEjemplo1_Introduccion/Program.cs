using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*Using necesario para el manejo de hilos*/
using System.Threading;

namespace HilosEjemplo1_Introduccion
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Inicia el hilo, mandando por parametro la funcion que controlara*/
            Thread hilo = new Thread(pintarCaracter);

            hilo.Start();
            //hilo.Join();/*Prioriza el hilo para que hasta que el no termine, no se ejecute nada mas*/
            //Thread.Sleep(2000);/*Duerme todos los hilos generados por 2 segundos*/
            //hilo.Start("y"); //Si se quisiera mandar parametros en el hilo
            pintarX();

            /*Para ejecutar una funcion con parametros, toca utilizar expresiones lambda*/
            //Thread hilo2 = new Thread(() => pintarPalabras(".NET","C#"));
            //hilo2.Start();


            /*Permite que deje la consola para entrada de datos, sin esto la consola se cierra*/
            Console.Read();
        }

        static void pintarX()
        {
            for (int i = 0; i < 1000; i++)
            {
                Console.Write("x");
            }
        }

        static void pintarCaracter()
        {
            for (int i = 0; i < 1000; i++)
            {
                Console.Write("y");
            }
        }

        /*Solo recibe objeto generico*/
        //static void pintarCaracter(Object letra)
        //{
        //    for (int i = 0; i < 1000; i++)
        //    {
        //        Console.Write(letra.ToString());
        //    }
        //}


        static void pintarPalabras(String palabra1, String palabra2)
        {
            for (int i = 0; i < 1000; i++)
            {
                Console.Write(palabra1 + "-" + palabra2);
            }
        }
    }
}
