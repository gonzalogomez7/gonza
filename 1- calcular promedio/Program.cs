using System;

namespace conversorTemperatura 
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {

                double numero1= 0; 
                double numero2= 0;
                double numero3= 0;

                Console.Clear();
                System.Console.WriteLine("calculador de promedios");
                System.Console.WriteLine("presione una tecla para continuar");
                Console.ReadKey();
                
                //ingreso primer numero
               
                Console.Clear();
                System.Console.WriteLine("ingrese el primer numero");
                LeerNumero (ref numero1);
                System.Console.WriteLine("primer numero cargardo, presione una tecla para continuar");
                Console.ReadKey();
               
                //ingreso segundo numero
               
                Console.Clear();
                System.Console.WriteLine("ingrese el segundo numero");
                LeerNumero (ref numero2);
                System.Console.WriteLine("segundo numero cargardo, presione una tecla para continuar");
                Console.ReadKey();
                
                //ingreso tercer numero
                
                Console.Clear();
                System.Console.WriteLine("ingrese el tercer numero");
                LeerNumero (ref numero3);
                System.Console.WriteLine("tercer numero cargardo, presione una tecla para continuar");
                Console.ReadKey();

                double suma = numero1+numero2+numero3;
                double promedio = suma / 3;

                System.Console.WriteLine("el promedio es de: " + promedio);
                Console.ReadKey();

                //bucle
                Console.Clear();
                System.Console.WriteLine("desea un nuevo calculo?");
                System.Console.WriteLine("S: nuevo calculo");
                System.Console.WriteLine("N: fin del programa");
            
                string desicion = Console.ReadLine();

                if (desicion.ToUpper() !="S")
                {
                    break;
                }
            
            }while (true);
        }
   
        static void LeerNumero (ref double EntradaNumero)
        {
            bool numeroValido = false;
            while(!numeroValido)
            {
                string numeroIngresado = Console.ReadLine();
                if (double.TryParse(numeroIngresado,out EntradaNumero))
                {
                    numeroValido = true;
                }
                else
                {
                    System.Console.WriteLine("entrada invalida por favor ingrese un numero valido");
                }
            }
        }
   
    }
}
