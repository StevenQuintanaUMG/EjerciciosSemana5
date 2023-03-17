static void pulsartecla() //Funcion que utilizare a lo largo del programa
{
    Console.WriteLine("\nPulse una tecla para continuar...");
    Console.ReadKey();
    Console.Clear();
}

//Ejercicio 1

Console.WriteLine("--------Calcular el area de un circulo al ingresar el radio-------");
static double area_circulo(double radio)
{
    return Math.PI * radio * radio;
}

double radio = 0;

while (radio <= 0)
{
    try
    {
        Console.Write("\nEscriba el radio del circulo: ");
        radio = Convert.ToDouble(Console.ReadLine());

    }
    catch (Exception)
    {
        Console.WriteLine("\n!!!Por favor escribe un radio valido!!!");
    }
}

Console.WriteLine("\nEl area del circulo es: {0:N2}", area_circulo(radio));

pulsartecla();

//Ejercicio 2

Console.WriteLine("-------Calcular perimetro de un rectangulo con base y altura-------");
static double perimetro_rectangulo(double Rectbase, double Rectaltura)
{
    return 2 * (Rectbase + Rectaltura);
}

double Rectbase = 0;
double Rectaltura = 0;

while (Rectbase <= 0)
{
    try
    {
        Console.Write("\nEscriba la base del rectangulo: ");
        Rectbase = Convert.ToDouble(Console.ReadLine());

    }
    catch (Exception)
    {
        Console.WriteLine("\n!!!!Por favor escribe una base valida!!!!!");
    }
}

while (Rectaltura <= 0)
{
    try
    {
        Console.Write("\nEscriba la altura del rectangulo: ");
        Rectaltura = Convert.ToDouble(Console.ReadLine());

    }
    catch (Exception)
    {
        Console.WriteLine("\n!!!!!Por favor escribe una altura valida!!!!!");
    }
}

Console.WriteLine("\nEl perimetro del rectangulo es: {0:N2}", perimetro_rectangulo(Rectbase, Rectaltura));

pulsartecla();

//Ejercicio 3

Console.WriteLine("-------Calcular promedio de una lista de numeros-------");
static double promedio_numeros(List<int> lista)
{
    return lista.Average();
}

bool condicion = false;
List<int> lista = new List<int>();

while (!condicion)
{
    try
    {
        Console.Write("\nIngrese una lista de numeros separados con espacios: ");
        string entrada_numeros = Console.ReadLine();

        lista = entrada_numeros.Split(' ').Select(int.Parse).ToList();
        condicion = true;
    }
    catch (Exception)
    {
        Console.WriteLine("\n!!!!!Por favor ingrese una lista de numeros separadas por espacios!!!!!!");
    }
}

Console.WriteLine("\nEl promedio de la lista de numeros es: {0:N2}", promedio_numeros(lista));

pulsartecla();

//Ejercicio 4

Console.WriteLine("--------Comprobar si un numero es par o impar--------");
static string numero_mayor_menor(int num)
{
    if (num % 2 == 0)
    {
        return "par";
    }
    else
    {
        return "impar";
    }
}

int num = 0;

do
{
    Console.Write("\nIngrese un numero entero: ");
} while (!int.TryParse(Console.ReadLine(), out num));

Console.WriteLine($"\nEl numero es {numero_mayor_menor(num)}");

pulsartecla();

//Ejercicio 5

Console.WriteLine("--------Convertir cadena a mayusculas--------");
static string cadenamayus(string cadena)
{
    return cadena.ToUpper();
}

string cadena;

Console.Write("\nIngrese una cadena de texto en minusculas: ");
cadena = Console.ReadLine();

Console.WriteLine($"\nSu cadena en mayusculas es: {cadenamayus(cadena)}");

pulsartecla();

//Ejercicio 6

Console.WriteLine("-------Calcular la distancia entre dos puntos-------");
static double distanciapuntos(double x1, double x2, double y1, double y2)
{
    return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
}

double x1, y1, x2, y2;
do
{
    Console.WriteLine("\nIngrese las coordenadas del primer punto:");
    Console.Write("X: ");
} while (!double.TryParse(Console.ReadLine(), out x1));

do
{
    Console.Write("Y: ");
} while (!double.TryParse(Console.ReadLine(), out y1));

do
{
    Console.WriteLine("\nIngrese las coordenadas del segundo punto:");
    Console.Write("X: ");
} while (!double.TryParse(Console.ReadLine(), out x2));

do
{
    Console.Write("Y: ");
} while (!double.TryParse(Console.ReadLine(), out y2));

Console.WriteLine("\nLa distancia entre los puntos es: {0:N2}", distanciapuntos(x1, x2, y1, y2));

pulsartecla();

//Ejercicio 7

Console.WriteLine("--------Calcular la suma de los primeros n numeros naturales--------");
static uint primeros_n(uint numero)
{
    uint suma = 0;
    for (uint i = 1; i <= numero; i++)
    {
        suma += i;
    }
    return suma;
}

uint numero;

do
{
    Console.Write("\nIngrese un numero natural: ");
} while (!uint.TryParse(Console.ReadLine(), out numero));

Console.WriteLine($"\nLa suma de los primeros n numeros naturales es {primeros_n(numero)}");

pulsartecla();

//Ejercicio 8

Console.WriteLine("--------Calcular el factorial de un numero-------");
static uint factorial_numero(uint numero_fact)
{
    uint factorial = 1;
    for (uint i = 1; i <= numero_fact; i++)
    {
        factorial *= i;
    }
    return factorial;
}

uint numero_fact;

do
{
    Console.Write("\nIngrese un numero natural: ");
} while (!uint.TryParse(Console.ReadLine(), out numero_fact));

Console.WriteLine($"El factorial del numero es: {factorial_numero(numero_fact)}");

pulsartecla(); 

Console.WriteLine("Gracias por usar el programa :)"); // No lo usara nadie
