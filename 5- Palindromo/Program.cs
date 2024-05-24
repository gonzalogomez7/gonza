using System.ComponentModel.Design;

namespace Palindomo
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                string desicion;
                Console.Clear();
                System.Console.WriteLine("PALINDROMOS");
                System.Console.WriteLine("Para continuar presione una tecla");
                Console.ReadKey();
                Console.Clear();
                System.Console.WriteLine("ingrese una palabra");
                string palabraIngresada = Console.ReadLine();

                string palabraLimpia= palabraIngresada.Replace(" ", string.Empty);

                palabraLimpia=palabraLimpia.ToLower();

                bool palindromo = esPalindromo(palabraLimpia);

                    if(palindromo)
                    {
                        Console.Clear();
                        System.Console.WriteLine("La palabra ingresada es un palindromo");
                        System.Console.WriteLine("desea probar otra palabra ? S/N");
                        desicion = Console.ReadLine();
                    }
                    else
                    {
                        Console.Clear();
                        System.Console.WriteLine("La palabra ingresada NO es un palindormo");
                        System.Console.WriteLine("desea probar otra palabra ? S/N");
                        desicion = Console.ReadLine();
                    }
            
                if(desicion.ToUpper()!= "S")    
            {
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                System.Console.WriteLine("-.W.-");
                Console.ResetColor();
                break;
            }
            }while(true);
            



        }


        static bool esPalindromo(string palabra)
        {
            int cuenta = palabra.Length;
            for(int numero = 0; numero < cuenta /2; numero++)
            {
                if(palabra[numero] != palabra[cuenta - 1 - numero])
                {
                    return false;
                }

                  
            }
            return true;  
        }   
    }
}