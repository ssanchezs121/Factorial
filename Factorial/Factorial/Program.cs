using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            

            {

                bool continuar = true;

                while (continuar == true)

                {
                    Console.Title = "Factorial";

                    int Dato1;
                    double result = 1;


                    Console.WriteLine("Digite un valor para Factorialo");
                    Dato1 = int.Parse(Console.ReadLine());

                    for (int i = 1; i <= Dato1; i++)

                    {

                        result *= i;

                    }

                    Console.WriteLine("El Valor es :" + result.ToString());
                    Console.WriteLine("Listo, eso seria\n");
                    Console.WriteLine("1 Para Intentar con otro numero");
                    Console.WriteLine("2 Para Salir");
             


                    string opcion = Console.ReadLine();

                    if (opcion != "1")
                    {
                        continuar = false;
                    }

                    Console.Clear();

                }

            }

        }
    }

}
            

        
    

