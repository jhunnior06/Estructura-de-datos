//4.Desarrollo y Actividades Ejercicio: 

//Recursividad:
//1) Ejercicio 1: Escribe una función recursiva que imprima los números pares del 1 al 100. 

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
    }

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