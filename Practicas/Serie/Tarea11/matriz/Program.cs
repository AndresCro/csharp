using System;

namespace matriz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculadora de matrices");
            Console.WriteLine("Ingresa el tamaño de la matriz (Un número entero)");
            //Variable de creación de arreglo
            int tam;
            //Hasta que el usuario lo tenga bien
            do
            {
                try
                {
                    tam = Convert.ToInt32(Console.ReadLine());
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Ingrese un número entero");
                }
            } while (true);

            int opcion;

            //Crea dos matrices para obtener el resultado
            double[,] matriz = new double[tam,tam];
            double[,] matriz2 = new double[tam, tam];
            

            do
            {
                Console.WriteLine("Suma [1]\nResta [2]\nMultiplicación [3]\nSalir [4]");
                
                //Hasta que el usuario ingrese un número correcto del menú
                try
                {
                    opcion = Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException)
                {
                    opcion = -1;
                    continue;
                }
                //Llama a obtener los valores más el procedimiento necesario
                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("Suma");
                        ObtenerValores(tam, matriz);
                        ObtenerValores(tam, matriz2);
                        Suma(matriz,matriz2,tam);
                        break;
                    case 2:
                        Console.WriteLine("Resta");
                        ObtenerValores(tam, matriz);
                        ObtenerValores(tam, matriz2);
                        Resta(matriz, matriz2, tam);
                        break;
                    case 3:
                        Console.WriteLine("Multiplicación");
                        ObtenerValores(tam, matriz);
                        ObtenerValores(tam, matriz2);
                        Mutliplicacion(matriz, matriz2, tam);
                        break;
                    case 4:
                        break;
                    default:
                        Console.WriteLine("Opción incorrecta");
                        Console.ReadKey();
                        break;
                }

            } while (opcion != 4);
            
        }
        public static void ObtenerValores(int tam, double[,] matriz)
        {
            Console.WriteLine("Ingrese los valores de la matriz");
            for (int i = 0; i < tam; i++)
            {
                for (int j = 0; j < tam; j++)
                {
                    Console.WriteLine("Ingrese el valor [{0}:{1}]", i, j);
                    do
                    {
                        //Verifica que cada valor sea un número cualquiera y no palabras
                        try
                        {
                            matriz[i, j] = Convert.ToDouble(Console.ReadLine());
                            break;
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("Ingrese un número");
                        }
                    } while (true);
                }
            }
        }

        public static void Suma(double[,] matriz, double[,] matriz2, int tam)
        {
            //Crea un matriz resultado donde se va a guardar el número 0,0 de la matriz A más el número 0,0 de la matriz B, así sucesivamente.
            double[,] resultado = new double[tam, tam];

            for (int i = 0; i < tam; i++)
            {
                for (int j = 0; j < tam; j++)
                {
                    resultado[i, j] = matriz[i, j] + matriz2[i, j];
                }
            }
            //Dibuja la matriz
            Dibujo(matriz, matriz2, resultado, tam);
        }
        public static void Resta(double[,] matriz, double[,] matriz2, int tam)
        {
            //Crea un matriz resultado donde se va a guardar el número 0,0 de la matriz A menos el número 0,0 de la matriz B, así sucesivamente.
            double[,] resultado = new double[tam, tam];

            for (int i = 0; i < tam; i++)
            {
                for (int j = 0; j < tam; j++)
                {
                    resultado[i, j] = matriz[i, j] - matriz2[i, j];
                }
            }
            //Dibuja la matriz
            Dibujo(matriz, matriz2, resultado, tam);
        }
        public static void Mutliplicacion(double[,] matriz, double[,] matriz2, int tam)
        {
            //Variables para obtener repetir el renglón determinadas veces para multiplicarlo por las columnas.
            //K -> renglón
            //L -> columna
            //contador = el número de veces que se va a repetir el renglón, ej: si es un matriz 4x4 se repetirá 4 veces el renglón.
            int k = 0;
            int l = 0;
            int contador = 0;

            double[,] resultado = new double[tam, tam];

            //Desde 0 hasta el tamaño de la matriz más, ya que es necesario porque se repite el renglón y hace saltos de 2 en 2 pero se le resta uno después.
            for (int i = 0; i < tam+1; i++)
            {
                //Si contador es igual al tamaño aumenta 1 y el contador se reinicia
                if (contador == tam)
                {
                    i++;
                    contador = 0;
                    
                }
                //El contador aumenta siempre en uno, ya que es por cada iteración
                contador++;

                //Si i vale 0 no pasa nada, sólo funciona al inicio de la serie.
                if (i != 0)
                {
                    i--;
                }

                //Si i es igual al tamaño rompe el for, esto debido a que hace saltos de 2 en 2, por lo tanto se puede salir del indice
                if (i == tam)
                {
                    break;
                }
                //Por renglón
                for (int j = 0; j < tam; j++)
                {
                    //Por cada iteración, k aumenta en 1 y l se conserva hasta que k termine de iterarse
                    //El resultado guarda los valores y los suma hasta que termine de iterarse el renglón i y columna l, porque por cada reglón de la primera matriz se multiplica por cada columna de la segunda matriz
                    resultado[i,l] += matriz[i, j] * matriz2[k,l];
                    //Calcular por columna     
                    //Si los dos coinciden se reinicia el ciclo de iteraciones por columnas.
                    if (k == tam-1 && l == tam-1)
                    {
                        l = 0;
                        k = 0;
                        continue;
                    }
                    //Salta a la otra columna desde el inicio
                    if (k == tam - 1)
                    {
                        l++;
                        k = 0;
                        continue;
                    }
                    //Aumenta en 1 k si no coincide con las condiciones
                    k++;
                }
               
            }
            //Dibuja la matriz fuera de los for
            Dibujo(matriz, matriz2, resultado, tam);
        }
        public static void Dibujo(double[,] matriz, double[,] matriz2, double[,] matriz3, int tam)
        {
            //Por cada matriz hace la impresión de lo valores
            Console.WriteLine("Valores de la matriz 1");
            for (int i = 0; i < tam; i++)
            {
                for (int j = 0; j < tam; j++)
                {
                    Console.Write(matriz[i,j]+"|");
                }
                Console.WriteLine();
            }

            Console.WriteLine("Valores de la matriz 2");
            for (int i = 0; i < tam; i++)
            {
                for (int j = 0; j < tam; j++)
                {
                    Console.Write(matriz2[i, j] + "|");
                }
                Console.WriteLine();
            }

            Console.WriteLine("Valores de la matriz resultado");
            for (int i = 0; i < tam; i++)
            {
                for (int j = 0; j < tam; j++)
                {
                    Console.Write(matriz3[i, j] + "|");
                }
                Console.WriteLine();
            }
        }
    }
}