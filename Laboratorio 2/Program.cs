//Desarrollo y Actividades 
//Ejercicio parte 01: 
//Operaciones B�sicas: 

Console.WriteLine("Ingrese un n�mero para elegir una opci�n:");
int a = int.Parse(Console.ReadLine());

////1) Realiza la suma, resta, multiplicaci�n y divisi�n de dos n�meros ingresados por el usuario. 
if (a == 1)
{
    Console.WriteLine("========================================= Ejercicio 1 ==========================================");
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
    Console.WriteLine("========================================= Ejercicio 2 ==========================================");
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
    Console.WriteLine("========================================= Ejercicio 3 ==========================================");
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
    Console.WriteLine("========================================= Ejercicio 4 ==========================================");
    Console.WriteLine("Ingrese un n�mero para calcular su factorial:");
    int n1 = int.Parse(Console.ReadLine());
    int res = 1;
    for (int i = 1; i <= n1; i++)
    {
        res *= i;
    }
    Console.WriteLine("Factorial de " + n1 + ": " + res);
}

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

else if (a == 6)
{
    Console.WriteLine("========================================= Ejercicio 6 ==========================================");
    Console.WriteLine("Ingrese una cadena de texto para invertir:");
    string cadena = Console.ReadLine();
    string res = "";
    for (int i = cadena.Length - 1; i >= 0; i--)
        res += cadena[i];
    Console.WriteLine("Cadena de texto invertida: " + res);
}

//Suma de N�meros Pares: 
//7) Calcula la suma de los n�meros pares en un rango especificado por el usuario. 

else if (a == 7)
{
    Console.WriteLine("========================================= Ejercicio 7 ==========================================");
    Console.WriteLine("Ingrese el inicio del rango:");
    int n1 = int.Parse(Console.ReadLine());
    Console.WriteLine("Ingrese el final del rango:");
    int n2 = int.Parse(Console.ReadLine());
    int res = 0;
    for (int i = n1 + 1; i < n2; i++)
    {
        if (i % 2 == 0)
            res += i;
    }
    Console.WriteLine("Suma de n�meros pares en el rango: " + res);
}
//Lista de Cuadrados: 
//8) Crea una lista de los cuadrados de los primeros 10 n�meros naturales. 

else if (a == 8)
{
    Console.WriteLine("========================================= Ejercicio 8 ==========================================");
    Console.WriteLine("Lista de cuadrados de los primeros 10 n�meros naturales:");
    for (int i = 1; i <= 10; i++)
        Console.WriteLine(i + "^2 = " + (i*i));
}
//Contador de Vocales: 
//9) Cuenta el n�mero de vocales en una cadena de texto. 

else if (a == 9)
{
    Console.WriteLine("========================================= Ejercicio 9 ==========================================");
    Console.WriteLine("Ingrese una cadena para contar las vocales:");
    string txt = Console.ReadLine();
    int cont = 0;
    foreach (char c in txt)
    {
        if ("aeiouAEIOU".Contains(c))
            cont++;
    }
    Console.WriteLine("N�mero de vocales: " + cont);
}

//N�meros de la Serie Fibonacci: 
//10) Genera los primeros 10 n�meros de la serie Fibonacci. 

else if (a == 10)
{
    Console.WriteLine("========================================= Ejercicio 10 ==========================================");
    Console.WriteLine("Primeros 10 n�meros de la serie Fibonacci:");
    int num1 = 0, num2 = 1, count = 0;
    while (count < 10)
    {
        Console.WriteLine(num1);
        int temp = num1;
        num1 = num2;
        num2 = temp + num2;
        count++;
    }
}

//Ordenamiento de Lista: 
//11) Ordena una lista de n�meros ingresados por el usuario de menor a mayor. 

else if (a == 11)
{
    Console.WriteLine("========================================= Ejercicio 11 ==========================================");
    Console.WriteLine("Ingrese la cantidad de elementos para la lista de numeros:");
    int n1 = int.Parse(Console.ReadLine());
    int[] lista = new int[n1];
    for (int i = 0; i < n1; i++)
    {
        Console.WriteLine("Ingrese los elementos " + (i + 1) + ":");
        lista[i] = int.Parse(Console.ReadLine());
    }
    Array.Sort(lista);
    Console.WriteLine("Lista ordenada: " + string.Join(", ", lista));
}
//Pal�ndromo: 
//12) Verifica si una palabra ingresada por el usuario es un pal�ndromo. 

else if (a == 12)
{
    Console.WriteLine("========================================= Ejercicio 12 ==========================================");
    Console.WriteLine("Ingrese una palabra o frase para verificar si es pal�ndromo:");
    string pl = Console.ReadLine().Replace(" ", "").ToLower();
    bool esPalindromo = true;
    for (int i = 0; i < pl.Length / 2; i++)
    {
        if (pl[i] != pl[pl.Length - 1 - i])
        {
            esPalindromo = false;
            break;
        }
    }
    if (esPalindromo)
        Console.WriteLine($"La palabra {pl} es un pal�ndromo.");
    else
        Console.WriteLine($"La palabra {pl} no es un pal�ndromo.");
}

//Generador de Tablas de Multiplicar: 
//13) Crea un programa que genere la tabla de multiplicar de un n�mero ingresado por el usuario. 

else if (a == 13)
{
    Console.WriteLine("========================================= Ejercicio 13 ==========================================");
    Console.WriteLine("Ingrese un n�mero para generar su tabla de multiplicar:");
    int n1 = int.Parse(Console.ReadLine());
    for (int i = 0; i <= 12; i++)
        Console.WriteLine($"{n1} x {i} = {n1 * i}");
}

//C�lculo del �rea de un C�rculo: 
//14) Pide el radio de un c�rculo al usuario y calcula su �rea. 

else if (a == 14)
{
    Console.WriteLine("========================================= Ejercicio 14 ==========================================");
    Console.WriteLine("Ingrese el radio del c�rculo:");
    double radio = double.Parse(Console.ReadLine());
    double area = Math.PI * radio * radio;
    Console.WriteLine($"�rea del c�rculo es : {area}");
}

//Suma de D�gitos: 
//15) Toma un n�mero entero y calcula la suma de sus d�gitos. 

else if (a == 15)
{
    Console.WriteLine("========================================= Ejercicio 15 ==========================================");
    Console.WriteLine("Ingrese un n�mero para calcular la suma de sus d�gitos:");
    string num = Console.ReadLine();
    int sumaDigitos = 0;
    foreach (char digito in num)
        sumaDigitos += int.Parse(digito.ToString());
    Console.WriteLine("Suma de d�gitos: " + sumaDigitos);
}
else
{
    Console.WriteLine("Opci�n no v�lida.");
}