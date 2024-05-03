//4.Desarrollo y Actividades Ejercicio: 

//Recursividad:
//1) Ejercicio 1: Escribe una función recursiva que imprima los números pares del 1 al 100. 

using System.ComponentModel.Design;

Console.WriteLine("Ingrese un número para elegir una opción:");
int a = int.Parse(Console.ReadLine());

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


    static int SumaNumeros(int n)
    {
        if (n == 1)
        {
            return 1;
        }
        else
        {
            return n + SumaNumeros(n - 1);
        }
    }
}


else if (a == 3)

//Esta duncion nos permite calcular factorial recurisvo 

{
    int Factorial(int fact)
    {
        if (fact > 0)
        {
            int valor = fact * Factorial(fact - 1);
            return valor;
        }
        else
            return 1;
    }

    int f = Factorial(5);
    Console.WriteLine("El factorial de 5 es " + f);
    Console.ReadKey();

}

else if (a == 4)
{
    int Fibonacci(int n)
    {
        if ((n == 0) || (n == 1))
        {
            return n;
        }
        else
        {
            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }
    }
    Console.Write("ESCRIBA LA CANTIDAD DE LOS NUMEROS DE FIBONACCI QUE DESEA IMPRIMIR:");
    int n = Convert.ToInt32(Console.ReadLine());
    for (int i = 2; i <= n + 1; i++)
    {
        Console.WriteLine(Fibonacci(i));
    }

}

else if (a == 5)

{
    // Declarar a array simple de 5 enteros.
    int[] array1 = new int[5];

    // Declarar y asignar array de enteros.
    int[] array2 = [1, 2, 3, 4, 5, 6];

    // Declarar un array de 2 dimensiones.
    int[,] multiDimensionalArray1 = new int[2, 3];

    // Declarar y asignar un array 2 dimensiones de enteros.
    int[,] multiDimensionalArray2 = { { 1, 2, 3 }, { 4, 5, 6 } };

}

else if (a == 6)
{
    int[] array = new int[5];
    string[] weekDays = ["Lunes", "Martes", "Miercoles", "Jueves", "Viernes", "Sabado", "Domingo"];

    Console.WriteLine(weekDays[1]);
    Console.WriteLine(weekDays[2]);
    Console.WriteLine(weekDays[3]);
    Console.WriteLine(weekDays[4]);
    Console.WriteLine(weekDays[5]);
    Console.WriteLine(weekDays[6]);

}

else if (a == 7)

{
    // array 2D.
    int[,] array2DInitialization = { { 1, 2 }, { 3, 4 }, { 5, 6 }, { 7, 8 } };
    // array 3D.
    int[,,] array3D = new int[,,] { { { 1, 2, 3 }, { 4,   5,  6 } },
                                { { 7, 8, 9 }, { 10, 11, 12 } } };

    // Accediendo al array 2D.
    Console.WriteLine(array2DInitialization[0, 0]);
    Console.WriteLine(array2DInitialization[0, 1]);
    Console.WriteLine(array2DInitialization[1, 0]);
    Console.WriteLine(array2DInitialization[1, 1]);
    Console.WriteLine(array2DInitialization[3, 0]);
    Console.WriteLine(array2DInitialization[3, 1]);

    // Accediendo al array 3D.
    Console.WriteLine(array3D[1, 0, 1]);
    Console.WriteLine(array3D[1, 1, 2]);

    // obteniendo el numero total de elementos .
    var allLength = array3D.Length;
    var total = 1;
    for (int i = 0; i < array3D.Rank; i++)
    {
        total *= array3D.GetLength(i);
    }
    Console.WriteLine($"{allLength} igual a {total}");

}

else if (a == 8)
{
    Console.Write("Ingrese tamaño del array : ");
    int n = int.Parse(Console.ReadLine());
    int[] m = new int[n];
    Console.WriteLine("Ingrese elementos : ");
    bool multiplo = false; int temp = 0;
    for (int i = 0; i < m.Length; i++)
    {
        multiplo = false;
        while (multiplo == false)
        {
            Console.Write("Ingrese elemento [" + i + "] : ");
            temp = int.Parse(Console.ReadLine());
            if (temp % 5 == 0)
            { m[i] = temp; multiplo = true; }
            else
            { Console.WriteLine(temp + " no es múltiplo de 5"); }
        }
    }
    Console.WriteLine("Los elementos del array son :");
    foreach (int i in m)
    { Console.Write(i + " "); }
    Console.ReadLine();


}

else if (a == 9)
{
    double[] m = new double[20];
    Console.WriteLine("Ingrese elementos : ");
    double temp = 0;
    for (int i = 0; i < m.Length; i++)
    {
        Console.Write("Ingrese elemento [" + i + "] : ");
        m[i] = double.Parse(Console.ReadLine());
        temp += m[i];
    }
    Console.WriteLine("La suma de elementos es : " + temp);
    Console.WriteLine("El media aritmética es : " + (temp / 20));
    Console.ReadLine();

}

//solisita el tamaño del arreglo de enteros, la suma de sus elementos y mostrar la cantidad
//stak cover flow la solucion del error la pagina para consultar 
else if (a == 10)
{
    Console.Write("Ingrese tamaño del array : ");
    int n = int.Parse(Console.ReadLine());
    int[] m = new int[n];

    for (int i = 0; i < m.Length; i++)
    {
        Console.Write("Ingrese elementos del array [" + i + "] : ");
        m[i] = int.Parse(Console.ReadLine());
    }

    int suma = CalcularSuma(m);
    int cantidadElementos = m.Length;

    Console.WriteLine($"La suma de los elementos del arreglo es: {suma}");
    Console.WriteLine($"La cantidad de elementos en el arreglo es: {cantidadElementos}");

    int CalcularSuma(int[] arreglo)
    {
        int suma = 0;
        foreach (int elemento in arreglo)
        {
            suma += elemento;
        }
        return suma;
    }
}
else if (a == 11)

//3.Crear un array que permita ingresar n números enteros, contar cuántos números son negativos, positivos y cuántos son cero.
{

    Console.Write("Ingrese tamaño del array : ");
    int[] m = new int[20];
    double pos = 0, neg = 0, cero = 0;
    for (int i = 0; i < m.Length; i++)
    {
        Console.Write("Ingrese elemento [" + i + "] : ");
        m[i] = int.Parse(Console.ReadLine());
        if (m[i] == 0)
        { cero++; }
        else if (m[i] > 0)
        { pos++; }
        else { neg++; }
    }
    Console.WriteLine("Total Positivos :" + pos);
    Console.WriteLine("Total Negativos :" + neg);
    Console.WriteLine("Total Ceros :" + cero);
    Console.ReadLine();

}

//Realizar la suma de dos arreglos de una dimension 
else if (a == 12)
{
    Console.Write("Ingrese tamaño del primer arreglo : ");
    int n = int.Parse(Console.ReadLine());
    int[] arreglo1 = new int[n];

    for (int i = 0; i < arreglo1.Length; i++)
    {
        Console.Write("Ingrese elemento [" + i + "] del primer arreglo: ");
        arreglo1[i] = int.Parse(Console.ReadLine());
    }

    Console.Write("Ingrese tamaño del segundo arreglo : ");
    int k = int.Parse(Console.ReadLine());
    int[] arreglo2 = new int[k];

    for (int i = 0; i < arreglo2.Length; i++)
    {
        Console.Write("Ingrese elemento [" + i + "] del segundo arreglo: ");
        arreglo2[i] = int.Parse(Console.ReadLine());
    }

    int[] arregloSuma = SumarArreglos(arreglo1, arreglo2);
    ImprimirArreglo(arregloSuma);
    }

    int[] SumarArreglos(int[] arreglo1, int[] arreglo2)
    {
    int[] arregloSuma = new int[Math.Max(arreglo1.Length, arreglo2.Length)];

    for (int i = 0; i < arregloSuma.Length; i++)
    {
        int valorArreglo1 = (i < arreglo1.Length) ? arreglo1[i] : 0;
        int valorArreglo2 = (i < arreglo2.Length) ? arreglo2[i] : 0;
        arregloSuma[i] = valorArreglo1 + valorArreglo2;
    }

    return arregloSuma;
    }

    static void ImprimirArreglo(int[] arreglo)
    {
    Console.WriteLine("El arreglo resultado de la suma es:");
    foreach (int elemento in arreglo)
    {
        Console.Write(elemento + " ");
    }
    Console.WriteLine();
}