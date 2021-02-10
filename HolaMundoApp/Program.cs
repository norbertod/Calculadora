using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolaMundoApp
{

    class Program
    {
        public class Operacion
        {
            public string tituloOperacion { get; set; }
            public string tituloValor1 { get; set; }
            public string tituloValor2 { get; set; }
            public string tituloResultado { get; set; }

            public double valor1 { get; set; }
            public double valor2 { get; set; }
            public double resultado { get; set; }
            public virtual void Operar() { }

        }


        public class Suma : Operacion
        {
            public Suma()
            {
                tituloOperacion = "Ingrese los valores a sumar";
                tituloValor1 = "Ingrese el primer valor: ";
                tituloValor2 = "Ingrese el segundo valor: ";
                tituloResultado = "El resultado de la suma es: ";
            }
            public override void Operar()
            {
                resultado = valor1 + valor2;
            }
        }


        public class Resta : Operacion
        {
            public Resta()
            {
                tituloOperacion = "Ingrese los valores a restar";
                tituloValor1 = "Ingrese el primer valor: ";
                tituloValor2 = "Ingrese el segundo valor: ";
                tituloResultado = "El resultado de la resta es: ";
            }
            public override void Operar()
            {
                resultado = valor1 - valor2;
            }
        }

        public class Multiplicacion : Operacion
        {
            public Multiplicacion()
            {
                tituloOperacion = "Ingrese los valores a multiplicar";
                tituloValor1 = "Ingrese el primer valor: ";
                tituloValor2 = "Ingrese el segundo valor: ";
                tituloResultado = "El resultado de la multiplicacion es: ";
            }
            public override void Operar()
            {
                resultado = valor1 * valor2;
            }
        }
        public class Division : Operacion
        {
            public Division()
            {
                tituloOperacion = "Ingrese los valores a dividir";
                tituloValor1 = "Ingrese el primer valor: ";
                tituloValor2 = "Ingrese el segundo valor: ";
                tituloResultado = "El resultado de la division es: ";
            }
            public override void Operar()
            {
                resultado = valor1 / valor2;
            }
        }

        public class RaízCuadrada : Operacion
        {
            public RaízCuadrada()
            {
                tituloOperacion = "Calcular Raiz Cuadrada";
                tituloValor1 = "Ingrese el valor a aplicar la raiz cuadrada: ";
                tituloValor2 = "";
                tituloResultado = "La raiz cuadrada de es: ";
            }
            public override void Operar()
            {
                resultado = Math.Sqrt(valor1);
            }
        }

        public class PotenciaCuadrado : Operacion
        {
            public PotenciaCuadrado()
            {
                tituloOperacion = "Calcular Potencia al cuadrado";
                tituloValor1 = "Ingrese el valor a aplicar la potencia: ";
                tituloValor2 = "";
                tituloResultado = "El resultado de la potencia es: ";
            }
            public override void Operar()
            {
                resultado = Math.Pow(valor1, 2);
            }
        }

        public class PotenciaALaN : Operacion
        {
            public PotenciaALaN()
            {
                tituloOperacion = "Calcular Potencia a la N";
                tituloValor1 = "Ingrese el valor a aplicar la potencia: ";
                tituloValor2 = "Ingrese el valor de N: ";
                tituloResultado = "El resultado de la potencia es: ";
            }
            public override void Operar()
            {
                resultado = Math.Pow(valor1, valor2);
            }
        }

        public class Cadena
        {
            public string cadena { get; set; }
            public char caracter { get; set; }

            public static string operacion { set; get; }

            public void contar()
            {
                Console.WriteLine("Ingrese una cadena de caracteres");
                cadena = Console.ReadLine();
                Console.WriteLine("La cantidad de caracteres de la cadena ingresada es: " + cadena.Length);
                Console.ReadKey();
            }
            public void ContarCaracteresRepetidos()
            {
                int count = 0;

                Console.WriteLine("Ingrese una cadena de caracteres");
                cadena = Console.ReadLine();
                Console.WriteLine("Ingrese el caracter a buscar: ");
                caracter = char.Parse(Console.ReadLine());


                char[] caract = cadena.ToCharArray(0, cadena.Length);
                foreach (char c in caract)
                    if (c == caracter) { count++; };
                Console.WriteLine("La cantidad de veces que se repite el caracter es: " + count);
                Console.ReadKey();
            }

        }

        class Prueba
        {
            public static Operacion oper { get; set; }
            public static Cadena cadena { get; set; }
            static void Main(string[] args)
            {
                //TOMA EL VALOR INGRESADO DE LA OPCION DEL MENU
                string linea;
                do
                {
                    Console.WriteLine("MENU PRINCIPAL");
                    Console.WriteLine();
                    Console.WriteLine("1-Suma");
                    Console.WriteLine("2-Resta");
                    Console.WriteLine("3-Multiplicación");
                    Console.WriteLine("4-División");
                    Console.WriteLine("5-Raíz Cuadrada");
                    Console.WriteLine("6-Potencia(al cuadrado).");
                    Console.WriteLine("7-Potencia(a la n)");
                    Console.WriteLine("8-Contar caracteres de un texto ingresado por el usuario");
                    Console.WriteLine("9-Contar repeticiones de un carácter recibido como parámetro, en un texto que también ingresa el usuario");
                    Console.WriteLine("0-Salir");
                    Console.WriteLine();
                    Console.Write("Ingrese el numero de opcion: ");
                    linea = Console.ReadLine();
                    //VALIDA SI LA OPCION INGRESADA ES CORRECTA
                    try
                    {
                        int.Parse(linea);
                    }
                    catch (Exception)
                    {
                        //SI NO CORRECTA, MUESTRA UN MENSAJE Y VUELVE AL MENU PRINCIPAL
                        Console.WriteLine("Ingrese una opcion correcta");
                        Console.WriteLine("Presione un tecla para continuar");
                        Console.ReadKey();
                        linea = "-1";
                        Console.Clear();
                        continue;

                    }


                    //DE ACUERDO A LA OPCION ELEGIDA CREA LA INSTANCIA CORRECTA
                    switch (int.Parse(linea))
                    {
                        case 1:
                            oper = new Suma();
                            break;
                        case 2:
                            oper = new Resta();
                            break;
                        case 3:
                            oper = new Multiplicacion();
                            break;
                        case 4:
                            oper = new Division();
                            break;
                        case 5:
                            oper = new RaízCuadrada();
                            break;
                        case 6:
                            oper = new PotenciaCuadrado();
                            break;
                        case 7:
                            oper = new PotenciaALaN();
                            break;
                        case 8:
                            cadena = new Cadena();
                            Cadena.operacion = "contar";
                            break;
                        case 9:
                            cadena = new Cadena();
                            Cadena.operacion = "ContarCaracteresRepetidos";
                            break;
                        default:
                            Console.Write("Se ingreso un valor fuera de rango");
                            break;
                    }
                    //SI SELECCIONA LA OPCION SALIR
                    if (int.Parse(linea) == 0) { return; }
                    //SI SELECCIONO LA OPCION 8 O 9 INGRESA A ESTE IF
                    if (cadena != null)
                    {
                        try
                        {
                            //VERIFICA EL VALOR DEL ATRIBUTO OPERACION Y REALIZA O NO LA ACCION
                            if (Cadena.operacion == "contar")
                            {
                                cadena.contar();
                                Console.Clear();
                                cadena = null;
                            }
                            else
                            {
                                cadena.ContarCaracteresRepetidos();
                                Console.Clear();
                                cadena = null;
                            }

                        }
                        catch (Exception ex)
                        {
                            Console.Write("Error: " + ex.Message);
                            throw;
                        }
                        //EVITA INGRESAR EN EL SIGUIENTE TRY - CATCH PARA VOLVER AL MENU PRINCIPAL
                        continue;
                    }
                    // SI SE ELIGIO LAS OPCIONES DESDE LA 1 A LA 7 INGRESA EN ESTE TRY
                    try
                    {

                        //SI SELECCIONA RAIZ CUADRADA O LA POTENCIA AL CUADRADO (OPCION 5 O 6) REALIZA ESTA OPERACION
                        if (oper is RaízCuadrada || oper is PotenciaCuadrado)
                        {
                            Console.Write(oper.tituloValor1);
                            oper.valor1 = double.Parse(Console.ReadLine());
                            oper.Operar();
                            Console.WriteLine(oper.tituloResultado + oper.resultado);
                            Console.ReadKey();
                        }
                        else if (oper != null)
                        {
                            Console.WriteLine(oper.tituloOperacion);
                            Console.Write(oper.tituloValor1);
                            oper.valor1 = double.Parse(Console.ReadLine());
                            Console.Write(oper.tituloValor2);
                            oper.valor2 = double.Parse(Console.ReadLine());
                            oper.Operar();
                            Console.WriteLine(oper.tituloResultado + oper.resultado);
                            Console.ReadKey();
                        }
                    }
                    catch (Exception)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Debe ingresar valores validos, volvera al menu principal ");
                        Console.WriteLine("Presione una tecla para continuar");
                        Console.ReadKey();
                        Console.Clear();
                        continue;
                    }
                    //LIMPIA LA CONSOLA
                    Console.Clear();
                    oper = null;
                } while (int.Parse(linea) != 0);
                Console.ReadKey();
            }
        }
    }
}
