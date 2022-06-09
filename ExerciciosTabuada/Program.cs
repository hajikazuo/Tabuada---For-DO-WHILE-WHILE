using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosTabuada
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int inicio, final, cont, multi;
            //Console.WriteLine("Qual a tabuada? ");
            //multi = int.Parse(Console.ReadLine());

            //Console.WriteLine("Qual o numero de inicio? ");
            //inicio = int.Parse(Console.ReadLine());

            //Console.WriteLine("Qual o numero final? ");
            //final = int.Parse(Console.ReadLine());

            //if (inicio<0 || inicio>100 && final<0 || final>100)
            //{
            //    Console.WriteLine("Digite valores validos");
            //}
            //for (cont = inicio; cont<=final; cont++) 
            //{
            //    Console.WriteLine(multi + " x " + cont + " = " + multi * cont);
            //}

            //int multi, inicio, final;


            //Console.WriteLine("Qual a tabuada? ");
            //multi = int.Parse(Console.ReadLine());

            //Console.WriteLine("Qual o numero de inicio? ");
            //inicio = int.Parse(Console.ReadLine());

            //Console.WriteLine("Qual o numero final? ");
            //final = int.Parse(Console.ReadLine());

            //if ((inicio > 0 && inicio< 100) && (final > 0 && final <100))
            //{
            //    do
            //    {
            //        Console.WriteLine(multi + " x " + inicio + " = " + multi * inicio);
            //        inicio++;
            //    }
            //    while (inicio<=final);

            int multi, inicio, final;


            Console.WriteLine("Qual a tabuada? ");
            multi = int.Parse(Console.ReadLine());

            Console.WriteLine("Qual o numero de inicio? ");
            inicio = int.Parse(Console.ReadLine());

            Console.WriteLine("Qual o numero final? ");
            final = int.Parse(Console.ReadLine());

            if ((inicio < 0 && inicio > 100) && (final < 0 && final > 100))
            {
                Console.WriteLine("Numero invalido ");
            }
            else
            {
                while (inicio <= final)
                {
                    Console.WriteLine(multi + " x " + inicio + " = " + multi * inicio);
                    inicio++;
                }
            }   
                Console.ReadKey();
            }
            
        }
    }
    
