using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

using EjercicioIndumentaria.Dominio.Indumentaria;
using EjercicioIndumentaria.Dominio.Ventas;
using EjercicioIndumentaria.Dominio.Exceptions;
using EjercicioIndumentaria.Dominio.Enums;


namespace EjercicioIndumentaria.Consola
{
    class Program
    {
        public static EjercicioIndumentaria.Dominio.TiendaRopa InstanciaTiendaRopa;
        //public static List<Categoria> ListaCategorias;
        public static List<Indumentaria> ListaIndumentaria;
        public static List<Venta> ListaVenta;
        //public static List<Repuesto> listPorCodigoCategoria;

        static void Main(string[] args)
        {
            //List<Categoria> ListaCategorias = new List<Categoria>();
            ListaIndumentaria = new List<Indumentaria>();
            ListaVenta = new List<Venta>();

            InstanciaTiendaRopa = new EjercicioIndumentaria.Dominio.TiendaRopa(ListaIndumentaria, ListaVenta, 123);

            //Categoria generales = new Categoria(0001, "Repuestos Generales");
            //Categoria autos = new Categoria(0002, "Repuestos autos");
            //Categoria motos = new Categoria(0003, "Repuestos motos");
            //Categoria triciclos = new Categoria(0004, "Repuestos triciclos");
            //Categoria monopatin = new Categoria(0005, "Repuestos monopatin");

            //ListaCategorias.Add(generales);
            //ListaCategorias.Add(autos);
            //ListaCategorias.Add(motos);
            //ListaCategorias.Add(triciclos);
            //ListaCategorias.Add(monopatin);

            //Repuesto kitDistribucion = new Repuesto(20001, "Kit de Distibucion", 19901, 20, autos);
            //Repuesto bombaAceite = new Repuesto(20002, "Bomba De Aceite", 13200, 19, autos);
            //Repuesto bateriaBosch = new Repuesto(30001, "Bateria 12n5-3b", 5300, 10, motos);
            //Repuesto conjuntoCambio = new Repuesto(40001, "Conjunto Cambio", 16036, 50, triciclos);
            //Repuesto motorCurrus = new Repuesto(50001, "Motor Currus Panther", 65000, 5, monopatin);

            //ListaRepuestos.Add(kitDistribucion);
            //ListaRepuestos.Add(bombaAceite);
            //ListaRepuestos.Add(bateriaBosch);
            //ListaRepuestos.Add(conjuntoCambio);
            //ListaRepuestos.Add(motorCurrus);

            DesplegarBienvenida();

            string tareaARealizar = "";
            do
            {
                try
                {
                    bool flag = false;

                    DesplegarOpcionesMenu();
                    tareaARealizar = Console.ReadLine();

                    switch (tareaARealizar.ToUpper())
                    {
                        case "1":
                            break;
                        case "2":
                            break;
                        case "3":
                            break;
                        case "4":
                            break;
                        case "5":
                            break;
                        case "6":
                            break;
                        case "7":
                            break;
                        case "X":
                            Console.Write("Fin del programa. Saludos!");
                            Thread.Sleep(2500);
                            break;
                        default:
                            Console.Write("\r\nERROR. Ingresaste un valor que no existe \r\n");
                            flag = true;
                            break;
                    }
                }
                catch (ErrorAlHacerTareaException ex)
                {
                    Console.WriteLine("Volver a empezar");
                }
            } while (tareaARealizar.ToUpper() != "X");
        }

        public static void DesplegarBienvenida()
        {
            Console.Write("Bienvenido al Sistema de Ropa \r\n");
        }

        public static void DesplegarOpcionesMenu()
        {
            Console.Write("\r\nPara continuar, presione el boton correspondiente y precione Enter: \r\n");
            Console.Write("" +
                "1. Agregar Indumentaria\r\n" +
                "2. Modificar Indumentaria\r\n" +
                "3. Quitar Indumentaria \r\n" +
                "4. Ingresar Orden de Venta \r\n" +
                "5. Listar Indumentaria\r\n" +
                "6. Listar Orden \r\n" +
                "7. Devolver Orden \r\n" +
                "X. Para salir \r\n");
        }

        public static T IngresarNumero<T>(string input)
        {
            string value;
            int salidaCodigoInt = 0;
            double salidaCodigoDouble = 0;
            bool flag;

            do
            {
                Console.WriteLine($"Ingrese {input}");
                value = Console.ReadLine();

                if (typeof(T) == typeof(int))
                {
                    flag = ValidarEntero(value, ref salidaCodigoInt);
                }
                else if (typeof(T) == typeof(double)) flag = ValidarDouble(value, ref salidaCodigoDouble);
                else flag = true;
            } while (flag == false);

            T valueReturn = (T)Convert.ChangeType(value, typeof(T));

            return valueReturn;
        }

        //public static void ValidarStock(int stock)
        //{
        //    if (stock > 100)
        //    {
        //        throw new StockCompletoException();
        //    }
        //}

        public static bool ValidarEntero(string numero, ref int salida)
        {
            bool flag = false;

            if (!int.TryParse(numero, out salida))
            {
                Console.WriteLine("Usted debe ingresar un número entero.");
            }
            else if (salida <= 0)
            {
                Console.WriteLine("Usted debe ingresar un número mayor que cero.");
            }
            else
            {
                flag = true;
            }

            return flag;
        }

        private static bool ValidarDouble(string registro, ref double salida)
        {
            bool flag = false;

            if (registro.Contains("."))
            {
                Console.WriteLine("Utilice las ',' (comas) para los centavos. NO utilice puntos bajo ningun punto de vista");
            }
            else if (!double.TryParse(registro, out salida))
            {
                Console.WriteLine("Usted debe ingresar un valor numérico.");
            }
            else if (salida <= 0)
            {
                Console.WriteLine("Usted debe ingresar un numero positivo.");
            }
            else
            {
                flag = true;
            }

            return flag;
        }
  
    }
}