using System;
using System.Collections.Generic;

namespace compras
{
    class Program
    {
        static void Main(string[] args)
        {
            //Listas que indica el programa - Nombres de los productos y precios
            List<string> nombres = new List<string>();
            List<double> precios = new List<double>();
            int opcion1;

            Console.WriteLine("BecarioMart");

            do
            {
                //Menú para ingresar los productos o comprar
                Console.WriteLine("Menú");
                Console.WriteLine("Añadir al producto al carrito [1]\nCarrito [2]\nSalir [3]");
                try
                {
                    opcion1 = Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException fe)
                {
                    Console.WriteLine("Ingrese una número");
                    opcion1 = -1;
                    continue;
                }
                //Llama a los procedimientos de comprar o ver el carrito
                switch (opcion1)
                {
                    case 1:
                        Agregar(nombres, precios);
                        break;
                    case 2:
                        Carrito(nombres, precios);
                        break;
                    case 3:
                        Console.WriteLine("Adiós :)");
                        Console.ReadKey();
                        break;
                    default:
                        Console.WriteLine("Opción incorrecta");
                        Console.ReadKey();
                        break;
                }
                Console.Clear();
            } while (opcion1 != 3);
        }

        //Procedimiento para agregar productos y precios
        public static void Agregar(List<string> nombres, List<double> precios)
        {
            //Variables para guardar en la lista de nombres y precios
            string producto;
            double costo;
            Console.WriteLine("Nombre del producto");
            producto = Console.ReadLine();
            nombres.Add(producto);

            Console.WriteLine("Precio");
            do
            {
                try
                {
                    costo = Convert.ToDouble(Console.ReadLine());
                    precios.Add(costo);
                    break;
                }
                catch (FormatException fe)
                {
                    Console.WriteLine("Ingrese una número");
                    Console.ReadKey();
                }
            } while (true);
        }

        //Procedimiento para comprar o devolver un producto
        public static void Carrito(List<string> nombres, List<double> precios)
        {
            //Variables para opción del menú, borrar un elemento y compra del carrito
            int opcion2;
            int indice;
            double compraTotal;

            //Obtiene el resultado de la compra
            compraTotal = MostrarInformacion(nombres, precios);

            //Menú para comprar o retirar del carrito
            do
            {
                Console.WriteLine("Comprar[1]\nDejar productos [2]\nSalir [3]");
                try
                {
                    opcion2 = Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException fe)
                {
                    Console.WriteLine("Ingrese una número");
                    break;
                }
                switch (opcion2)
                {
                    case 1:
                        //Si es mayor termina se repite el menú
                        if (compraTotal > 500.00)
                        {
                            Console.WriteLine("Te pasaste :(");
                            Console.ReadKey();
                        }
                        //De lo contrario hace la "compra" y termina el programa
                        else
                        {
                            Console.WriteLine("Gracias por su compra!");
                            Console.ReadKey();
                            Environment.Exit(0);
                        }
                        break;
                    case 2:
                        Console.WriteLine("Eliminar producto");
                        //Muestra los productos
                        MostrarInformacion(nombres, precios);
                        Console.WriteLine("Indique el producto (mediante el indice) que desea eliminar");
                        indice =  Convert.ToInt32(Console.ReadLine());
                        try
                        {
                            nombres.RemoveAt(indice);
                            precios.RemoveAt(indice);
                            compraTotal = MostrarInformacion(nombres, precios);
                            break;
                        }
                        catch (IndexOutOfRangeException ioe)
                        {
                            Console.WriteLine("Ingrese un indice correcto");
                            Console.ReadKey();
                            break;
                        }

                    case 3:
                        Console.WriteLine("Adiós :)");
                        Console.ReadKey();
                        break;
                    default:
                        Console.WriteLine("Opción incorrecta");
                        Console.ReadKey();
                        break;
                }
                Console.Clear();
            } while (opcion2 != 3);
        }

        //Función que regresa el total de la compra más los productos, precios e indices
        public static double MostrarInformacion(List<string> nombres, List<double> precios)
        {
            //Variable para obtener la compra
            double total = 0;

            //Itera las dos listas y muestra el producto, precio e indice
            for (int i = 0; i < nombres.Count; i++)
            {
                Console.WriteLine("Producto: {0} - Precio: {1} -> Indice {2}", nombres[i], precios[i], i);
                total += precios[i];
            }

            return total;
        }
    }
}
