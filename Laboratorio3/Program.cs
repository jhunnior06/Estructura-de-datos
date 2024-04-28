// See https://aka.ms/new-console-template for more information

//var i = 5;

//if (i >= 4) ;
//{
//    //postiva 
//    Console.WriteLine(''en numero mayor es mayor o igual a 4!'');

//else
//    { Console.WriteLine()}
//}

//Console.WriteLine("================ Programa que determina si es par o impar ==========");
//Console.WriteLine("INGRESE UN NUMERO ENTERO: ");
//var nemeroRecibido = Console.ReadLine();
//var numero = int.Parse(nemeroRecibido);
//var esPar = false;

////Resolver
//if (numero % 2 == 0) ;
//{
//    esPar = true;
//}

////MOSTRAR
//Console.WriteLine(esPar ? "Es Par " : "Es impar");
//Console.ReadLine(); 


//1.	/*se desea calcular la distancia recorrida (m) por un móvil que tiene velocidad constante
//     (m/s) durante un tiempo T (sg), considerar que es un MRU (movimiento rectilíneo uniforme) */


////declaración 
//double d, v, t;


//Console.Write("ingrese la velocidad constante: ");
//v = int.Parse(Console.ReadLine()); 
//Console.Write("ingrese el tiempo : "); 
//t = int.Parse(Console.ReadLine()); 

////resolución 
//d = v * t;
//// 
//Console.Write("la distancia es: {0}", d); 
//Console.ReadLine();



//// Solicitar al usuario que ingrese dos números
//Console.WriteLine("Ingresa el primer número:");
//var numero1 = Convert.ToDouble(Console.ReadLine());

//Console.WriteLine("Ingresa el segundo número:");
//var numero2 = Convert.ToDouble(Console.ReadLine());

//// Resolver
//var suma = numero1 + numero2;
//var resta = numero1 - numero2;
//var multiplicacion = numero1 * numero2;

//// Verificar si el segundo número es distinto de cero para evitar división por cero
//var division = 0.0;
//if (numero2 != 0)
//{
//    division = numero1 / numero2;
//}
//else
//{
//    Console.WriteLine("No es posible dividir entre cero.");
//}

//// Mostrar resultados
//Console.WriteLine($"Suma: {suma}");
//Console.WriteLine($"Resta: {resta}");
//Console.WriteLine($"Multiplicación: {multiplicacion}");
//if (numero2 != 0)
//{
//    Console.WriteLine($"División: {Math.Round(division,2)}");
//}


//calcular el factorial de un numero

// crea una funcion que calcule el fatorial de un numero 


Console.WriteLine("Ingresa un número para calcular su factorial:");
int numero = Convert.ToInt32(Console.ReadLine());

long factorial = 1;
for (int i = 2; i <= numero; i++)
{
    factorial *= i;
}

Console.WriteLine($"El factorial de {numero} es: {factorial}");
