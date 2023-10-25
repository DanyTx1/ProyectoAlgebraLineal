Console.WriteLine("!Bienvenidos!");

//Declaramos variables
int columaA, filaA, columaB, filaB, opcion;
bool entradaValida = false;

do
{

    //Opciones del menu
    Console.WriteLine("\n Eliga una de las siguientes obciones");
    Console.WriteLine(
        " 1.) Suma" +
        "\n 2.) Resta" +
        "\n 3.) Multiplicacion" +
        "\n 4.) Inversa por medio de Determinantes" +
        "\n 5.) Regla de Crammer" +
        "\n 6.) Salir");

    do
    {

        //Comprobamos que sean numeros y no texto o simbolos
        Console.WriteLine("Ingrese la opcion (debe ser un número entero):");

        if (int.TryParse(Console.ReadLine(), out opcion))
        {
            entradaValida = true;
        }
        else
        {
            Console.WriteLine("Entrada inválida. Por favor, ingrese un número entero.");
        }
    } while (!entradaValida);

    switch (opcion)
    {
        //Suma
        case 1:
      
                Console.WriteLine("!Suma de matices!");

            do
            {
                entradaValida = false;

                //Solicitamos las dimenciones de la matrices 
                Console.WriteLine("Ingrese el numero de filas de la matriz A:");

                if (int.TryParse(Console.ReadLine(), out filaA))
                {
                    entradaValida = true;
                }
                else
                {
                    Console.WriteLine("Entrada inválida. Por favor, ingrese un número entero.");
                }
            } while (!entradaValida);

            entradaValida = false; // Reiniciamos la bandera para la siguiente entrada

            do
            {
                Console.WriteLine("Ingrese el numero de columnas de la matriz A:");

                if (int.TryParse(Console.ReadLine(), out columaA))
                {
                    entradaValida = true;
                }
                else
                {
                    Console.WriteLine("Entrada inválida. Por favor, ingrese un número entero.");
                }
            } while (!entradaValida);

            do
            {

                entradaValida = false;

                Console.WriteLine("Ingrese el numero de filas de la matriz B:");

                if (int.TryParse(Console.ReadLine(), out filaB))
                {
                    entradaValida = true;
                }
                else
                {
                    Console.WriteLine("Entrada inválida. Por favor, ingrese un número entero.");
                }
            } while (!entradaValida);

            entradaValida = false; // Reiniciamos la bandera para la siguiente entrada

            do
            {
                Console.WriteLine("Ingrese el numero de columnas de la matriz B:");

                if (int.TryParse(Console.ReadLine(), out columaB))
                {
                    entradaValida = true;
                }
                else
                {
                    Console.WriteLine("Entrada inválida. Por favor, ingrese un número entero.");
                }
            } while (!entradaValida);

            //Comprobamos que las matrices sean del mismo tamaño
            if (filaA == filaB && columaA == columaB)
            {

                //Declaramos las mastrices
                int[,] A = new int[filaA, columaA];
                int[,] B = new int[filaB, columaB];
                int[,] C = new int[filaA, columaA];

                //Recuperamos los datos de las matrices
                Console.WriteLine("Ingrese los valores de la matriz A");
                for (int i = 0; i < filaA; i++)
                {
                    for (int j = 0; j < columaB; j++)
                    {
                        Console.WriteLine("\n Ingrese dato: {0} x {1}", i, j);
                        A[i, j] = Convert.ToInt32(Console.ReadLine());
                    }
                }

                Console.WriteLine("Ingrese los valores de la matriz B");
                for (int i = 0; i < filaA; i++)
                {
                    for (int j = 0; j < columaA; j++)
                    {
                        Console.WriteLine("\n Ingrese dato: {0} x {1}", i, j);
                        B[i, j] = Convert.ToInt32(Console.ReadLine());
                    }
                }

                //Suma de las matrices
                Console.WriteLine("Ingrese los valores de la matriz A");
                for (int i = 0; i < filaA; i++)
                {
                    for (int j = 0; j < columaA; j++)
                    {
                        C[i, j] = A[i, j] + B[i, j];
                    }
                }

                // Resultado
                Console.WriteLine("Resultado de la suma");
                for (int i = 0; i < filaA; i++)
                {
                    for (int j = 0; j < columaA; j++)
                    {
                        Console.Write(C[i, j] + "  ");
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("Las matrices no coinciden");
            }
            break;

        //Resta
        case 2:

                 Console.WriteLine("!Resta de matices!");

            do
            {

                entradaValida = false;

                //Solicitamos las dimenciones de la matrices 
                Console.WriteLine("Ingrese el numero de filas de la matriz A:");

                if (int.TryParse(Console.ReadLine(), out filaA))
                {
                    entradaValida = true;
                }
                else
                {
                    Console.WriteLine("Entrada inválida. Por favor, ingrese un número entero.");
                }
            } while (!entradaValida);

            entradaValida = false; // Reiniciamos la bandera para la siguiente entrada

            do
            {
                Console.WriteLine("Ingrese el numero de columnas de la matriz A:");

                if (int.TryParse(Console.ReadLine(), out columaA))
                {
                    entradaValida = true;
                }
                else
                {
                    Console.WriteLine("Entrada inválida. Por favor, ingrese un número entero.");
                }
            } while (!entradaValida);

            do
            {

                entradaValida = false;

                Console.WriteLine("Ingrese el numero de filas de la matriz B:");

                if (int.TryParse(Console.ReadLine(), out filaB))
                {
                    entradaValida = true;
                }
                else
                {
                    Console.WriteLine("Entrada inválida. Por favor, ingrese un número entero.");
                }
            } while (!entradaValida);

            entradaValida = false; // Reiniciamos la bandera para la siguiente entrada

            do
            {
                Console.WriteLine("Ingrese el numero de columnas de la matriz B:");

                if (int.TryParse(Console.ReadLine(), out columaB))
                {
                    entradaValida = true;
                }
                else
                {
                    Console.WriteLine("Entrada inválida. Por favor, ingrese un número entero.");
                }
            } while (!entradaValida);

            //Comprobamos que las matrices sean del mismo tamaño
            if (filaA == filaB && columaA == columaB)
            {

                //Declaramos matrices 
                int[,] A = new int[filaA, columaA];
                int[,] B = new int[filaB, columaB];
                int[,] C = new int[filaA, columaA];

                //Recuperamos los datos de las matrices
                //Colocarle la cordenada del dato que esta ingresando ejemplo 1x1 1x2 1x3 2x1
                Console.WriteLine("Ingrese los valores de la matriz A");
                for (int i = 0; i < filaA; i++)
                {
                    for (int j = 0; j < columaB; j++)
                    {
                        Console.WriteLine("\n Ingrese dato: {0} x {1}", i, j);
                        A[i, j] = Convert.ToInt32(Console.ReadLine());
                    }
                }

                Console.WriteLine("Ingrese los valores de la matriz B");
                for (int i = 0; i < filaA; i++)
                {
                    for (int j = 0; j < columaA; j++)
                    {
                        Console.WriteLine("\n Ingrese dato: {0} x {1}", i, j);
                        B[i, j] = Convert.ToInt32(Console.ReadLine());
                    }
                }

                //Resta de las matrices
                Console.WriteLine("Ingrese los valores de la matriz A");
                for (int i = 0; i < filaA; i++)
                {
                    for (int j = 0; j < columaA; j++)
                    {
                        C[i, j] = A[i, j] - B[i, j];
                    }
                }

                // Resultado
                //Notas a mejorar: Mostrar las matrices a sumar: Que se vea mas presentable la respuesta
                Console.WriteLine("Resultado de la suma");
                for (int i = 0; i < filaA; i++)
                {
                    for (int j = 0; j < columaA; j++)
                    {
                        Console.Write(C[i, j] + "  ");
                    }
                }
            }
            else
            {
                Console.WriteLine("Las matrices no coinciden");
            }

            break;




        //Multiplicacion
        case 3:

                Console.WriteLine("!Multiplicacion de matices!");

            do
            {

                entradaValida = false;

                //Solicitamos las dimenciones de la matrices 
                Console.WriteLine("Ingrese el numero de filas de la matriz A:");

                if (int.TryParse(Console.ReadLine(), out filaA))
                {
                    entradaValida = true;
                }
                else
                {
                    Console.WriteLine("Entrada inválida. Por favor, ingrese un número entero.");
                }
            } while (!entradaValida);

            entradaValida = false; // Reiniciamos la bandera para la siguiente entrada

            do
            {
                Console.WriteLine("Ingrese el numero de columnas de la matriz A:");

                if (int.TryParse(Console.ReadLine(), out columaA))
                {
                    entradaValida = true;
                }
                else
                {
                    Console.WriteLine("Entrada inválida. Por favor, ingrese un número entero.");
                }
            } while (!entradaValida);

            do
            {

                entradaValida = false;

                Console.WriteLine("Ingrese el numero de filas de la matriz B:");

                if (int.TryParse(Console.ReadLine(), out filaB))
                {
                    entradaValida = true;
                }
                else
                {
                    Console.WriteLine("Entrada inválida. Por favor, ingrese un número entero.");
                }
            } while (!entradaValida);

            entradaValida = false; // Reiniciamos la bandera para la siguiente entrada

            do
            {
                Console.WriteLine("Ingrese el numero de columnas de la matriz B:");

                if (int.TryParse(Console.ReadLine(), out columaB))
                {
                    entradaValida = true;
                }
                else
                {
                    Console.WriteLine("Entrada inválida. Por favor, ingrese un número entero.");
                }
            } while (!entradaValida);

            if (columaA == filaB)
            {

                //Declaramos matrices
                int[,] A = new int[filaA, columaA];
                int[,] B = new int[filaB, columaB];
                int[,] C = new int[columaA, filaB];

                //Recuperamos los datos de las matrices
                Console.WriteLine("Ingrese los valores de la matriz A");

                for (int i = 0; i < filaA; i++)
                {
                    for (int j = 0; j < columaA; j++)
                    {
                        Console.WriteLine("\n Ingrese dato: {0} x {1}", i, j);
                        A[i, j] = Convert.ToInt32(Console.ReadLine());
                    }
                }

                Console.WriteLine("Ingrese los valores de la matriz B");

                for (int i = 0; i < filaB; i++)
                {
                    for (int j = 0; j < columaB; j++)
                    {
                        Console.WriteLine("\n Ingrese dato: {0} x {1}", i, j);
                        B[i, j] = Convert.ToInt32(Console.ReadLine());
                    }
                }

                //Multiplicacion de las matrices
                Console.WriteLine("El resultado de la multiplicacion es");
                for (int i = 0; i < columaB; i++)
                {
                    for (int j = 0; j < filaA; j++)
                    {
                        for (int k = 0; k < columaB; k++)
                        {
                            C[i, j] += A[i, k] * B[k, j];
                        }
                    }
                }

                // Resultado
                Console.WriteLine("Resultado de la Multiplicacion");
                for (int i = 0; i < filaA; i++)
                {
                    for (int j = 0; j < columaA; j++)
                    {
                        Console.Write(C[i, j] + "  ");
                    }
                    Console.WriteLine();
                }

            }
            else
            {
                Console.WriteLine("Las Columas y Filas no coinciden");
            }

            break;

        //Inversa por medio de Determinantes
        case 4:
            Console.WriteLine("En desarrollo");
            break;

        //Regla de Crammer
        case 5:
            Console.WriteLine("En desarrollo");
            break;

        //Salir
        case 6:
            Console.WriteLine("Adios :)");
            break;
    }
} while (opcion != 6);