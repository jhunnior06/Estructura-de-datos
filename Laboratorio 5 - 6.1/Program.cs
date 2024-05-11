using System.Numerics;

Console.WriteLine("Ingrese un número para elegir una opción:");
int a = int.Parse(Console.ReadLine());

//4.Desarrollo y Actividades Ejercicio: 

//Recursividad:
//1) Ejercicio 1: Escribe una función recursiva que imprima los números pares del 1 al 100. 
if (a == 1)
{
    Console.WriteLine("===================== Ejercicio 1 =====================");
    for (int i = 2; i <= 100; i += 2)
    {
        Console.WriteLine(i);
    }
}
//2) Ejercicio 2: Escribe una función recursiva que imprima la suma de los números del 1 al n. 
else if (a == 2)
{
    Console.WriteLine("===================== Ejercicio 2 =====================");
    Console.WriteLine("Ingrese un número :");
    int n = int.Parse(Console.ReadLine());
    int suma = SumaNumeros(n);
    Console.WriteLine("La suma de los números del 1 al " + n + " es: " + suma);

    int SumaNumeros(int n)
    {
        if (n <= 0)
        {
            return 0; 
        }
        else
        {
            return n + SumaNumeros(n - 1);
        }
    }
}
//3) Ejercicio 3: Escribe una función recursiva que imprima la pirámide de números del 1 al n. 
else if (a == 3)
{
    Console.WriteLine("===================== Ejercicio 3 =====================");
    Console.WriteLine("Ingrese un número :");
    int n = int.Parse(Console.ReadLine());
    ImprimirPiramideAscendente(n);  

    static void ImprimirPiramideAscendente(int n)
    {
        for (int i = 1; i <= n; i++)
        {
            for (int j = 1; j <= n - i; j++)
            {
                Console.Write(" ");  
            }
            for (int k = 1; k <= i * 2 - 1; k++)
            {
                Console.Write(i);
            }
            Console.WriteLine();  
        }
    }
}

//4) Ejercicio 4: Escribe una función recursiva que imprima la pirámide de números invertidos del 1 al n. 
else if (a == 4)
{
    Console.WriteLine("===================== Ejercicio 4 =====================");
    Console.WriteLine("Ingrese un número :");
    int n = int.Parse(Console.ReadLine());
    ImprimirPiramideInvertida(n);  

    static void ImprimirPiramideInvertida(int n)
    {
        ImprimirPiramideInvertidaRecursiva(n, n);
    }
    static void ImprimirPiramideInvertidaRecursiva(int original, int actual)
    {
        if (actual <= 0)
        {
            return;  
        }
        for (int i = 1; i <= original - actual; i++)
            Console.Write(" ");
        {
        }
        for (int j = 1; j <= actual * 2 - 1; j++)
        {
            Console.Write(actual); 
        }
        Console.WriteLine(); 
        ImprimirPiramideInvertidaRecursiva(original, actual - 1);
    }
}

//5) Ejercicio 2: Escribe una función recursiva que imprima la tabla de multiplicar del n. 
else if (a == 5)
{
    Console.WriteLine("===================== Ejercicio 5 =====================");
    Console.WriteLine("Ingrese un número :");
    int n = int.Parse(Console.ReadLine());
    TablaMultiplicar(n); 

    static void TablaMultiplicar(int n, int multiplicador = 1)
    {
        if (multiplicador <= 12)  
        {
            Console.WriteLine($"{n} x {multiplicador} = {n * multiplicador}");
            TablaMultiplicar(n, multiplicador + 1);
        }
    }
}
//Arreglos y Matrices: 
//6) Crea una matriz de números reales. 

else if (a == 6)
{
    Console.WriteLine("===================== Ejercicio 6 =====================");
    Random r = new Random();
    int[,] matriz = new int[3, 3];
    for (int i = 0; i < 3; i++)
    {
        for (int j = 0; j < 3; j++)
        {
            matriz[i, j] = r.Next(0, 10);
            Console.Write(matriz[i, j] + " ");
        }
        Console.WriteLine();
    }
}

//7) Crea una matriz de números complejos. 
else if (a == 7)
{
    Console.WriteLine("===================== Ejercicio 7 =====================");
    Random r = new Random();
    Complex[,] matrizCompleja = new Complex[3, 3];

    Console.WriteLine("Matriz de números complejos:");

    for (int i = 0; i < matrizCompleja.GetLength(0); i++)
    {
        for (int j = 0; j < matrizCompleja.GetLength(1); j++)
        {
            double real = r.Next(-10, 11);
            double imag = r.Next(-10, 11);
            matrizCompleja[i, j] = new Complex(real, imag);

            Console.Write($"({real:+0;-0;0},{imag:+0;-0;0}i)\t");
        }
        Console.WriteLine();
    }
}

//8) Crea una matriz de matrices. 
else if (a == 8)
{
    Console.WriteLine("===================== Ejercicio 8 =====================");
    int[][][] matrixOfMatrices = new int[3][][] {
            new int[2][] { new int[] {1, 2}, new int[] {3, 4} },
            new int[2][] { new int[] {5, 6}, new int[] {7, 8} },
            new int[2][] { new int[] {9, 10}, new int[] {11, 12} }
        };

    // Print the matrix of matrices
    foreach (var matrix in matrixOfMatrices)
    {
        Console.WriteLine("Nueva matriz");
        foreach (var row in matrix)
        {
            foreach (var element in row)
            {
                Console.Write(element + " ");
            }
            Console.WriteLine();
        }
    }
}

//9) Accede al elemento central de una matriz. 
else if (a == 9)
{
    Console.WriteLine("===================== Ejercicio 9 =====================");
    int[,] matriz = {
            { 1, 2, 3, 2, 8 },
            { 4, 5, 6, 4, 7 },
            { 7, 2, 0, 6, 9 },
            { 1, 6, 1, 4, 8 },
            { 1, 8, 0, 7, 8 }
        };
    int filas = matriz.GetLength(0), columnas = matriz.GetLength(1);

    if (filas % 2 == 1 && columnas % 2 == 1)
    {
        Console.WriteLine("Elemento central de la matriz: " + matriz[filas / 2, columnas / 2]);
    }
    else
    {
        Console.WriteLine("La matriz tiene un número par de filas o columnas, no hay un solo elemento central.");
        Console.WriteLine("Elementos centrales:");
        for (int i = filas / 2 - 1; i <= filas / 2; i++)
        {
            for (int j = columnas / 2 - 1; j <= columnas / 2; j++)
                Console.Write(matriz[i, j] + " ");
            Console.WriteLine();
        }
    }
}

//10) Suma dos matrices de diferentes tamaños. 
else if (a == 10)
{
    Console.WriteLine("===================== Ejercicio 10 =====================");
    int[,] matriz1 = { { 1, 2, 3 }, { 4, 5, 6 } };
    int[,] matriz2 = { { 7, 8 }, { 9, 10 }, { 11, 12 } };
    int[,] resultado = SumarMatrices(matriz1, matriz2);
    ImprimirMatriz(resultado);


    int[,] SumarMatrices(int[,] m1, int[,] m2)
    {
        int maxFilas = Math.Max(m1.GetLength(0), m2.GetLength(0));
        int maxColumnas = Math.Max(m1.GetLength(1), m2.GetLength(1));
        int[,] resultado = new int[maxFilas, maxColumnas];
        for (int i = 0; i < maxFilas; i++)
            for (int j = 0; j < maxColumnas; j++)
                resultado[i, j] = (i < m1.GetLength(0) && j < m1.GetLength(1) ? m1[i, j] : 0) + (i < m2.GetLength(0) && j < m2.GetLength(1) ? m2[i, j] : 0);
        return resultado;
    }

    void ImprimirMatriz(int[,] matriz)
    {
        for (int i = 0; i < matriz.GetLength(0); i++, Console.WriteLine())
            for (int j = 0; j < matriz.GetLength(1); j++)
                Console.Write(matriz[i, j] + " ");
    }
}

//11) Multiplica una matriz por un número. 
else if (a == 11)
{
    Console.WriteLine("===================== Ejercicio 11 =====================");
    int[,] matriz = {
            {1, 2, 3},
            {4, 5, 6},
            {7, 8, 9}
        };
    int escalar = 3;
    for (int i = 0; i < matriz.GetLength(0); i++)
    {
        for (int j = 0; j < matriz.GetLength(1); j++)
        {
            matriz[i, j] *= escalar;
            Console.Write(matriz[i, j] + " ");
        }
        Console.WriteLine();
    }
}

//12) Calcula la media de los elementos de una matriz. 
else if (a == 12)
{
    Console.WriteLine("===================== Ejercicio 12 =====================");
    int[,] matriz = {
            {1, 2, 3},
            {4, 5, 6},
            {7, 8, 9}
        };
    double media = Media(matriz);
    Console.WriteLine("La media es: " + media);
    int Media(int[,] matriz)
    {
        int sumaTotal = 0;
        int numeroDeElementos = 0;

        int filas = matriz.GetLength(0);
        int columnas = matriz.GetLength(1);

        for (int i = 0; i < filas; i++)
        {
            for (int j = 0; j < columnas; j++)
            {
                sumaTotal += matriz[i, j];
                numeroDeElementos++;
            }
        }
        if (numeroDeElementos == 0)
            return 0; 
        return (int)sumaTotal / numeroDeElementos;
    }
}

//Ejercicio Matrices: 

//Ejercicio 1: 
//Crea una matriz de números aleatorios de tamaño 100x100. 
else if (a == 13)
{
    Console.WriteLine("===================== Ejercicio 13 =====================");
    Random r = new Random();
    int[,] matriz = new int[100, 100];
    for (int i = 0; i < 100; i++)
    {
        for (int j = 0; j < 100; j++)
        {
            matriz[i, j] = r.Next(0, 101);
            Console.Write(matriz[i, j] + " ");
        }
        Console.WriteLine();
    }
}

//Ejercicio 2: 
//Calcula la media, la mediana y la desviación estándar de los elementos de una matriz. 
else if (a == 14)
{
    Console.WriteLine("===================== Ejercicio 14 =====================");
    int[,] matriz = {
            {1, 2, 3},
            {4, 5, 6},
            {7, 8, 9}
        };
    var elementos = matriz.Cast<int>().ToArray();
    double media = elementos.Average();
    double mediana = CalcularMediana(elementos);
    double desviacionEstandar = CalcularDesviacionEstandar(elementos, media);

    Console.WriteLine($"Media: {media}");
    Console.WriteLine($"Mediana: {mediana}");
    Console.WriteLine($"Desviación Estándar: {desviacionEstandar}");

    double CalcularMediana(int[] numeros)
    {
        int tamaño = numeros.Length;
        var numerosOrdenados = numeros.OrderBy(n => n).ToArray();
        if (tamaño % 2 == 0)
            return (numerosOrdenados[tamaño / 2 - 1] + numerosOrdenados[tamaño / 2]) / 2.0;
        else
            return numerosOrdenados[tamaño / 2];
    }
     double CalcularDesviacionEstandar(int[] numeros, double media)
    {
        double sumaDeCuadrados = numeros.Sum(num => (num - media) * (num - media));
        return Math.Sqrt(sumaDeCuadrados / numeros.Length);
    }
}

//Ejercicio 3: 
//Escribe una función que encuentre el elemento máximo de una matriz. 
else if (a == 15)
{
    Console.WriteLine("===================== Ejercicio 15 =====================");
    int[,] matriz = {
            {1, 2, 3},
            {4, 15, 6},
            {7, 8, 9}
        };
    int maximo = matriz.Cast<int>().Max();
    Console.WriteLine($"El elemento máximo de la matriz es: {maximo}");
}

//Ejercicio 4: 
//Escribe una función que encuentre la submatriz de mayor suma de una matriz. 
else if (a == 16)
{
    Console.WriteLine("===================== Ejercicio 16 =====================");
    int[,] matriz = {
            {1, 2, -1, -4, -20},
            {-8, -3, 4, 2, 1},
            {3, 8, 10, 1, 3},
            {-4, -1, 1, 7, -6}
        };
    Console.WriteLine($"La suma máxima de la submatriz es: {MaxSumSubmatrix(matriz)}");
    int MaxSumSubmatrix(int[,] matriz)
    { 
        int maxSum = int.MinValue, filas = matriz.GetLength(0), columnas = matriz.GetLength(1);

        for (int left = 0; left < columnas; left++)
        {
            int[] temp = new int[filas];

            for (int right = left; right < columnas; right++)
            {
                for (int i = 0; i < filas; i++)
                    temp[i] += matriz[i, right];

                int currentMax = temp[0], maxEndHere = temp[0];
                for (int i = 1; i < filas; i++)
                {
                    maxEndHere = Math.Max(temp[i], maxEndHere + temp[i]);
                    currentMax = Math.Max(currentMax, maxEndHere);
                }
                maxSum = Math.Max(maxSum, currentMax);
            }
        }
        return maxSum;
    }
}

//Ejercicio 5: 
//Escribe una función que encuentre la matriz de covarianza de dos matrices.
else if (a == 17)
{
    Console.WriteLine("===================== Ejercicio 17 =====================");
    double[,] matriz1 = { { 1, 2 }, { 3, 4 } };
    double[,] matriz2 = { { 5, 6 }, { 7, 8 } };
    int filas = matriz1.GetLength(0), cols = matriz1.GetLength(1);
    double[,] covarianza = new double[cols, cols];

    for (int i = 0; i < cols; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            double sum1 = 0, sum2 = 0, sum12 = 0;
            for (int k = 0; k < filas; k++)
            {
                sum1 += matriz1[k, i];
                sum2 += matriz2[k, j];
                sum12 += matriz1[k, i] * matriz2[k, j];
            }
            covarianza[i, j] = (sum12 - sum1 * sum2 / filas) / filas;
        }
    }
    for (int i = 0; i < cols; i++)
    {
        for (int j = 0; j < cols; j++)
            Console.Write(covarianza[i, j] + " ");
        Console.WriteLine();
    }
}


