//Desarrollo y Actividades 
//Ejercicio parte 01: 
//Operaciones Básicas: 
//1) Realiza la suma, resta, multiplicación y división de dos números ingresados por el usuario. 

//Verificación de Número Par o Impar: 
//2) Solicita un número al usuario y determina si es par o impar. 

//Área de un Triángulo: 
//3) Pide la base y la altura de un triángulo al usuario y calcula su área. 

//Calculadora de Factorial: 
//4) Crea una función que calcule la factorial de un número. 

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




Console.WriteLine("========================================= Ejercicio 5 ==========================================");

int numero = ObtenerNumero();

Console.WriteLine(EsPrimo(numero)
    ? $"{numero} es un número primo."
    : $"{numero} no es un número primo.");
    
static int ObtenerNumero()
{
    Console.WriteLine("Ingresa un número para verificar si es primo:");
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



//Inversión de Cadena: 
//6) Toma una cadena de texto y muestra su inversión. 

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

