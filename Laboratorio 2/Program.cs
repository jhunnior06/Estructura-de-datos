//Desarrollo y Actividades 
//Ejercicio parte 01: 
//Operaciones B�sicas: 

Console.WriteLine("Ingrese un n�mero para elegir una opci�n:");
int a = int.Parse(Console.ReadLine());

////1) Realiza la suma, resta, multiplicaci�n y divisi�n de dos n�meros ingresados por el usuario. 
if (a == 1)
{
    Console.WriteLine("Ingresa el primer n�mero:");
    var numero1 = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Ingresa el segundo n�mero:");
    var numero2 = Convert.ToDouble(Console.ReadLine());

    // Resolver
    var suma = numero1 + numero2;
    var resta = numero1 - numero2;
    var multiplicacion = numero1 * numero2;

    // Verificar si el segundo n�mero es distinto de cero para evitar divisi�n por cero
    var division = 0.0;
    if (numero2 != 0)
        division = numero1 / numero2;
    else
        Console.WriteLine("No es posible dividir entre cero.");

    //Mostrar resultados
    Console.WriteLine($"Suma: {suma}");
    Console.WriteLine($"Resta: {resta}");
    Console.WriteLine($"Multiplicaci�n: {multiplicacion}");
    if (numero2 != 0)
        Console.WriteLine($"Divisi�n: {Math.Round(division, 2)}");
}
//Verificaci�n de N�mero Par o Impar: 
//2) Solicita un n�mero al usuario y determina si es par o impar. 

else if (a == 2)
{
    Console.WriteLine("Ingrese un n�mero para verificar si es par o impar:");
    int n1 = int.Parse(Console.ReadLine());
    if (n1 % 2 != 0)
        Console.WriteLine(n1 + " es impar");
    else
        Console.WriteLine(n1 + " es par");
}
//�rea de un Tri�ngulo: 
//3) Pide la base y la altura de un tri�ngulo al usuario y calcula su �rea. 

else if (a == 3)
{
    Console.WriteLine("Ingrese la base del tri�ngulo:");
    int b = int.Parse(Console.ReadLine());
    Console.WriteLine("Ingrese la altura del tri�ngulo:");
    int h = int.Parse(Console.ReadLine());
    Console.WriteLine("�rea del tri�ngulo: " + ((b * h) / 2));
}
//Calculadora de Factorial: 
//4) Crea una funci�n que calcule la factorial de un n�mero. 

else if (a == 4)
{
    Console.WriteLine("Ingrese un n�mero para calcular su factorial:");
    int n1 = int.Parse(Console.ReadLine());
    int res = 1;
    for (int i = 1; i <= n1; i++)
    {
        res *= i;
    }
    Console.WriteLine("Factorial de " + n1 + ": " + res);
}

//Console.WriteLine("========================================= Ejercicio 4 ==========================================");
//Console.WriteLine("Ingresa un n�mero para calcular su factorial:");
//int numero = Convert.ToInt32(Console.ReadLine());

//long factorial = 1;
//for (int i = 2; i <= numero; i++)
//{
//    factorial *= i;
//}

//Console.WriteLine($"El factorial de {numero} es: {factorial}");
//N�mero Primo: 

//5) Verifica si un n�mero ingresado por el usuario es primo o no.

else if (a == 5)
{
    Console.WriteLine("========================================= Ejercicio 5 ==========================================");
    Console.WriteLine("Ingrese un n�mero para verificar si es primo:");
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
        Console.WriteLine("El n�mero " + n1 + " es primo");
    else
        Console.WriteLine("El n�mero " + n1 + " no es primo");
}
//Inversi�n de Cadena: 
//6) Toma una cadena de texto y muestra su inversi�n. 

//Console.WriteLine("========================================= Ejercicio 5 ==========================================");
//Suma de N�meros Pares: 
//7) Calcula la suma de los n�meros pares en un rango especificado por el usuario. 

//Lista de Cuadrados: 
//8) Crea una lista de los cuadrados de los primeros 10 n�meros naturales. 

//Contador de Vocales: 
//9) Cuenta el n�mero de vocales en una cadena de texto. 

//N�meros de la Serie Fibonacci: 
//10) Genera los primeros 10 n�meros de la serie Fibonacci. 


//Ordenamiento de Lista: 
//11) Ordena una lista de n�meros ingresados por el usuario de menor a mayor. 

//Pal�ndromo: 
//12) Verifica si una palabra ingresada por el usuario es un pal�ndromo. 

//Generador de Tablas de Multiplicar: 
//13) Crea un programa que genere la tabla de multiplicar de un n�mero ingresado por el usuario. 

//C�lculo del �rea de un C�rculo: 
//14) Pide el radio de un c�rculo al usuario y calcula su �rea. 

//Suma de D�gitos: 
//15) Toma un n�mero entero y calcula la suma de sus d�gitos. 

