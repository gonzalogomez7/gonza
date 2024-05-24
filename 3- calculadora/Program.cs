using System.ComponentModel.Design;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            bool continuar = true;
            while(continuar)
            {   
                //intro
                Console.Clear();
                System.Console.WriteLine("Calculadora -.W.-");
                System.Console.WriteLine("Para continuar presione una tecla");
                //menu
                System.Console.WriteLine("ingrese una opcion...");
                System.Console.WriteLine("1) Operacion Suma");
                System.Console.WriteLine("2) Operacion Resta");
                System.Console.WriteLine("3) Operacion Multiplicacion");
                System.Console.WriteLine("4) Operacion Division");
                System.Console.WriteLine("5) Salir de la calculadora");
                int opcionMenu;
                if(int.TryParse(Console.ReadLine(), out opcionMenu))
                {
                    switch(opcionMenu)
                    {
                        case 1:
                            calculoSuma();
                            break;
                        case 2:
                            calculoResta();
                            break;
                        case 3:
                            calculoMultiplicacion();
                            break;
                        case 4:
                            calculoDivision();
                            break;
                        case 5:
                            System.Console.WriteLine("gracias por usar la calculadora -.W.-");
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
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    System.Console.WriteLine("opcion no valida, intente nuevamente...");
                    Console.ReadKey();
                    Console.ResetColor();
                }
            }
        }
        static void calculoSuma()
        {
            double sumaA=0;
            double sumaB=0;
            double resulSuma=0;
            //ingreso datos
            Console.Clear();
            System.Console.WriteLine("Ingrese el primer numero");
            LeerNumero(ref sumaA);
            Console.Clear();
            System.Console.WriteLine("ingrese el segundo numero");
            LeerNumero(ref sumaB);
            //calculo
            resulSuma = sumaA + sumaB ;
            //muestra datos
            Console.Clear();
            System.Console.WriteLine("el resultado = " + resulSuma);
            System.Console.WriteLine("presione una tecla para continuar...");
            Console.ReadKey();
        }

        static void calculoResta()
        {
            double restaA=0;
            double restaB=0;
            double resulResta=0;
            //ingreso datos
            Console.Clear();
            System.Console.WriteLine("Ingrese el primer numero");
            LeerNumero(ref restaA);
            Console.Clear();
            System.Console.WriteLine("ingrese el segundo numero");
            LeerNumero(ref restaB);
            //calculo
            resulResta = restaA - restaB ;
            //mustrad resultados
            Console.Clear();
            System.Console.WriteLine("el resultado = " + resulResta);
            System.Console.WriteLine("presione una tecla para continuar...");
            Console.ReadKey();
        }
        static void calculoMultiplicacion()
        {
        double multiplicando=0;
        double multiplicador=0;
        double productoMulti=0;
        //ingreso datos     
        Console.Clear();
        System.Console.WriteLine("Ingrese el numero que desea multiplicar");
        LeerNumero(ref multiplicando);
        Console.Clear();
        System.Console.WriteLine("ingrese el numero multiplicador");
        LeerNumero(ref multiplicador);
        //calculo
        productoMulti = multiplicando * multiplicador;
        //muestra resultados
        Console.Clear();
        System.Console.WriteLine("El resultado es: " + productoMulti);
        System.Console.WriteLine("presione una tecla para continuar...");
        Console.ReadKey();

        }
        static void calculoDivision()
        {
            double numeroDiv=0;
            double divisor=0;
            double resultadoDiv =0;
            //ingreso de datos
            Console.Clear();
            System.Console.WriteLine("ingrese el numero que desea dividir...");
            LeerNumero(ref numeroDiv);
            //bucle 0
            while(true)
            {
                Console.Clear();
                System.Console.WriteLine("ingrese el divisor...");
                LeerNumero(ref divisor);
                // evitar dividir por 0
                if (divisor ==0)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    System.Console.WriteLine("El divisor no puede ser 0, intenta nuevamente");
                    Console.ResetColor();
                    System.Console.WriteLine("para continuar presione una tecla");
                }
                else
                {
                    //salir del bucle
                    break;
                }
            }              
            // calculo
            resultadoDiv = numeroDiv / divisor;
            //muestra resultado
            Console.Clear();
            System.Console.WriteLine("el resultado es de:" + resultadoDiv);
            System.Console.WriteLine("presione una tecla para continuar...");
            Console.ReadKey();            
            
                
            

            
        }
        static void LeerNumero(ref double numero)
        {
            bool numeroValido = false;
            while(!numeroValido)
            {
                string numeroIngresado = Console.ReadLine();
                if (double.TryParse(numeroIngresado,out numero))
                {
                    numeroValido = true;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    System.Console.WriteLine("entrada invalida, por favor intente nuevamente");
                    Console.ResetColor();
                }
            }
        }        
    }
}
