//Desarrollo y Actividades 
//Ejercicio parte 01: 
//Operaciones B�sicas: 
//1) Realiza la suma, resta, multiplicaci�n y divisi�n de dos n�meros ingresados por el usuario. 

//Verificaci�n de N�mero Par o Impar: 
//2) Solicita un n�mero al usuario y determina si es par o impar. 

//�rea de un Tri�ngulo: 
//3) Pide la base y la altura de un tri�ngulo al usuario y calcula su �rea. 

//Calculadora de Factorial: 
//4) Crea una funci�n que calcule la factorial de un n�mero. 

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




Console.WriteLine("========================================= Ejercicio 5 ==========================================");

int numero = ObtenerNumero();

Console.WriteLine(EsPrimo(numero)
    ? $"{numero} es un n�mero primo."
    : $"{numero} no es un n�mero primo.");
    
static int ObtenerNumero()
{
    Console.WriteLine("Ingresa un n�mero para verificar si es primo:");
    return Convert.ToInt32(Console.ReadLine());
}
static Boolean EsPrimo(int numero)
{
    if (numero <= 1)
        return false;

    for (int i = 2; i * i <= numero; i++)
        if (numero % i == 0)
            return false;

    return true;
}



//Inversi�n de Cadena: 
//6) Toma una cadena de texto y muestra su inversi�n. 

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

