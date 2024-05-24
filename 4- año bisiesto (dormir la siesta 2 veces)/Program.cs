using System.ComponentModel.Design;
using System.Runtime.CompilerServices;

namespace añoBisiesto
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {    
                string Desicion;

                Console.Clear();
                System.Console.WriteLine("Verificador de año bisiesto");
                System.Console.WriteLine("Para continuar presione una tecla...");
                Console.ReadKey();
                
                Console.Clear();
                System.Console.WriteLine("ingrese el año que desea consultar");
                
                int año=0;
                LeerNumero(ref año);

                if (bisiesto(año))
                {
                    Console.Clear();
                    System.Console.WriteLine(año + "Es un año bisiesto");
                    System.Console.WriteLine("quiere consultar otro año? S/N");
                    Desicion = Console.ReadLine();
                }
                else
                {
                    Console.Clear();
                    System.Console.WriteLine(año + "No es un año bisiesto");
                    System.Console.WriteLine("quiere consultar otro año? S/N");
                    Desicion = Console.ReadLine();
                }
            if(Desicion.ToUpper()!="S")
            {   
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                System.Console.WriteLine("-.W.-");
                Console.ResetColor();
                break;
            }
            }while (true);
        
        }

        static void LeerNumero(ref int numero)
        {
            bool numeroValido = false;
            while(!numeroValido)
            {
                string numeroIngresado = Console.ReadLine();
                    if (int.TryParse(numeroIngresado,out numero))
                    {
                        numeroValido = true;
                    }

                        else
                        {
                            System.Console.WriteLine("entrada invalida, por favor ingrese un numero entero");
                        }
            }
        }
    
        static bool bisiesto(int año)
        {
            if(año % 4==0)
            {
                if(año % 100 ==0)
                {
                    if (año % 400==0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                }
                else
                {
                    return true;
                }
            }
            else
            {
                return false;
            }
        }
    
    }
}