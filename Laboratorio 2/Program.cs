//Desarrollo y Actividades 
//Ejercicio parte 01: 
//Operaciones Básicas: 

Console.WriteLine("Ingrese un número para elegir una opción:");
int a = int.Parse(Console.ReadLine());

////1) Realiza la suma, resta, multiplicación y división de dos números ingresados por el usuario. 
if (a == 1)
{
    Console.WriteLine("Ingresa el primer número:");
    var numero1 = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Ingresa el segundo número:");
    var numero2 = Convert.ToDouble(Console.ReadLine());

    // Resolver
    var suma = numero1 + numero2;
    var resta = numero1 - numero2;
    var multiplicacion = numero1 * numero2;

    // Verificar si el segundo número es distinto de cero para evitar división por cero
    var division = 0.0;
    if (numero2 != 0)
        division = numero1 / numero2;
    else
        Console.WriteLine("No es posible dividir entre cero.");

    //Mostrar resultados
    Console.WriteLine($"Suma: {suma}");
    Console.WriteLine($"Resta: {resta}");
    Console.WriteLine($"Multiplicación: {multiplicacion}");
    if (numero2 != 0)
        Console.WriteLine($"División: {Math.Round(division, 2)}");
}
//Verificación de Número Par o Impar: 
//2) Solicita un número al usuario y determina si es par o impar. 

else if (a == 2)
{
    Console.WriteLine("Ingrese un número para verificar si es par o impar:");
    int n1 = int.Parse(Console.ReadLine());
    if (n1 % 2 != 0)
        Console.WriteLine(n1 + " es impar");
    else
        Console.WriteLine(n1 + " es par");
}
//Área de un Triángulo: 
//3) Pide la base y la altura de un triángulo al usuario y calcula su área. 

else if (a == 3)
{
    Console.WriteLine("Ingrese la base del triángulo:");
    int b = int.Parse(Console.ReadLine());
    Console.WriteLine("Ingrese la altura del triángulo:");
    int h = int.Parse(Console.ReadLine());
    Console.WriteLine("Área del triángulo: " + ((b * h) / 2));
}
//Calculadora de Factorial: 
//4) Crea una función que calcule la factorial de un número. 

else if (a == 4)
{
    Console.WriteLine("Ingrese un número para calcular su factorial:");
    int n1 = int.Parse(Console.ReadLine());
    int res = 1;
    for (int i = 1; i <= n1; i++)
    {
        res *= i;
    }
    Console.WriteLine("Factorial de " + n1 + ": " + res);
}

//Console.WriteLine("========================================= Ejercicio 4 ==========================================");
//Console.WriteLine("Ingresa un número para calcular su factorial:");
//int numero = Convert.ToInt32(Console.ReadLine());

//long factorial = 1;
//for (int i = 2; i <= numero; i++)
//{
//    factorial *= i;
//}

//Console.WriteLine($"El factorial de {numero} es: {factorial}");
//Número Primo: 

//5) Verifica si un número ingresado por el usuario es primo o no.

else if (a == 5)
{
    Console.WriteLine("========================================= Ejercicio 5 ==========================================");
    Console.WriteLine("Ingrese un número para verificar si es primo:");
    int n1 = int.Parse(Console.ReadLine());
    bool esPrimo = true; 
    int i = 2;
    while (i < n1)
    {
        if (n1 % i == 0)
        {
            esPrimo = false; 
            break;
        }
        i++;
    }
    if (esPrimo && n1 > 1) 
        Console.WriteLine("El número " + n1 + " es primo");
    else
        Console.WriteLine("El número " + n1 + " no es primo");
}
//Inversión de Cadena: 
//6) Toma una cadena de texto y muestra su inversión. 

//Console.WriteLine("========================================= Ejercicio 5 ==========================================");
//Suma de Números Pares: 
//7) Calcula la suma de los números pares en un rango especificado por el usuario. 

//Lista de Cuadrados: 
//8) Crea una lista de los cuadrados de los primeros 10 números naturales. 

//Contador de Vocales: 
//9) Cuenta el número de vocales en una cadena de texto. 

//Números de la Serie Fibonacci: 
//10) Genera los primeros 10 números de la serie Fibonacci. 


//Ordenamiento de Lista: 
//11) Ordena una lista de números ingresados por el usuario de menor a mayor. 

//Palíndromo: 
//12) Verifica si una palabra ingresada por el usuario es un palíndromo. 

//Generador de Tablas de Multiplicar: 
//13) Crea un programa que genere la tabla de multiplicar de un número ingresado por el usuario. 

//Cálculo del Área de un Círculo: 
//14) Pide el radio de un círculo al usuario y calcula su área. 

//Suma de Dígitos: 
//15) Toma un número entero y calcula la suma de sus dígitos. 

