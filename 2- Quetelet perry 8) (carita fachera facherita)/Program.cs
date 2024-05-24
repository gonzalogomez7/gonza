using System.ComponentModel.Design;

namespace CalculadorIMC
{
    class Program
    {
        static void Main(string[] args)
        {
            bool continuar = true;
            while (continuar)
            {
                //intro
                Console.Clear();
                System.Console.WriteLine("Calculador de Indice de Masa Muscular");
                System.Console.WriteLine("Para continuar presione una tecla");
                Console.ReadKey();
                //muestra menu
                Console.Clear();
                System.Console.WriteLine("Ingrese una opcion...");
                System.Console.WriteLine("1: Realizar calculo IMC");
                System.Console.WriteLine("2: Que es el IMC?");
                System.Console.WriteLine("3: Salir");
                //elccion menu
                int opcionMenu;
                if (int.TryParse(Console.ReadLine(), out opcionMenu))
                {
                    switch(opcionMenu)
                    {
                        case 1:
                            CalcularIMC();
                            break;
                        case 2:
                            InfoIMC();
                            break;
                        case 3:
                            System.Console.WriteLine("gracias por usar este calculador de IMC...");
                            continuar = false;
                            break;
                        default:
                            System.Console.WriteLine("Opcion no valida, presione una tecla para intentar nuevamente");
                            Console.ReadKey();
                            break;
                    }
                }
                else
                {
                    System.Console.WriteLine("Entrada no valida, presione una tecla para intentar nuevamente");
                    Console.ReadKey();
                }  
            }
        }
        //metodos
        static void leerNumero(ref double numero)
        {
            bool numeroValido = false;
            while(!numeroValido)
            { 
                string numeroIngresado = Console.ReadLine();
                if(double.TryParse(numeroIngresado, out numero))
                {
                    numeroValido = true;
                }
                else
                {
                    System.Console.WriteLine("Entrada invalida, Por favor intente nuevamente");
                }
            }
        }
        static void CalcularIMC()
        {
                    double pesoKG = 0;
                    double alturaM = 0;
                    System.Console.WriteLine("Calcular IMC en 2 simples pasos");
                    System.Console.WriteLine("Para continuar presione una tecla...");
                    Console.ReadKey();
                    // ingreso peso
                    Console.Clear();
                    System.Console.WriteLine("1) ingrese su peso en Kg");
                    leerNumero(ref pesoKG);
                    //ingreso altura
                    Console.Clear();
                    System.Console.WriteLine("2) ingrese su altura en Metros. ej:[1.70]");
                    leerNumero(ref alturaM);
                    //calculos
                    double multiplicacion = alturaM * alturaM;
                    double calculoIMC = pesoKG / multiplicacion;
                    double mejora = calculoIMC * 10000;
                    //muestra resultados y datos
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    System.Console.WriteLine("peso ingresado: " + pesoKG);
                    System.Console.WriteLine("altura ingresada: "+alturaM);
                    Console.ResetColor();
                    System.Console.WriteLine("Su resultado IMC para los datos ingresados: " + mejora);
                    //referencia
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    System.Console.WriteLine("datos de referencia:");
                    System.Console.WriteLine("Delgadez: IMC < 18.5");
                    System.Console.WriteLine("Peso saludable: IMC = 18.5 a 24.9");
                    System.Console.WriteLine("Sobrepeso: IMC = 25 a 29.9");
                    System.Console.WriteLine("Obesidad: imc ≥ 30");
                    Console.ResetColor();
                    Console.ReadKey();    
        }
        static void InfoIMC()
        {
            Console.Clear();
            System.Console.WriteLine("La fórmula de Quetelet fue desarrollada");
            System.Console.WriteLine("por el matemático belga Adolphe Quetelet");
            System.Console.WriteLine("en el siglo XIX y se ha convertido en una");
            System.Console.WriteLine("herramienta común para evaluar el peso");
            System.Console.WriteLine("corporal y determinar si una persona tiene ");
            System.Console.WriteLine("un peso saludable, sobrepeso o delgadez");
            System.Console.WriteLine("Para continuar presione una tecla...");
            Console.ReadKey();
        }
    }
}