//sumar

int Sumar(int a, int b)
{
    return a + b;
}

//restar

int Restar(int a, int b)
{
    return a - b;
}

//multiplicar

int Multiplicar(int a, int b)
{
    return a * b;
}

//dividir

float Dividir(float a, float b)
{
    if (b != 0)
        return a / b;
    else
        throw new DivideByZeroException("No se puede dividir por cero.");
}

//potencia

double Potencia(double baseNum, double exponente)
{
    return Math.Pow(baseNum, exponente);
}

//modulo

int Modulo(int a, int b)
{
    return a % b;
}

//valor absoluto

int ValorAbsoluto(int num)
{
    return Math.Abs(num);
}

//factorial

int Factorial(int num)
{
    if (num == 0)
        return 1;
    else
        return num * Factorial(num - 1);
}

//máximo entre 2 numeros

int Maximo(int a, int b)
{
    return Math.Max(a, b);
}

//mínimo

int Minimo(int a, int b)
{
    return Math.Min(a, b);
}

//redondear un decimal hacia arriba

double RedondearHaciaArriba(double num)
{
    return Math.Ceiling(num);
}
    
//hacia abajo

double RedondearHaciaAbajo(double num)
{
    return Math.Floor(num);
}

//seno de un ángulo en radianes

double Seno(double angulo)
{
    return Math.Sin(angulo);
}

//coseno

double Coseno(double angulo)
{
    return Math.Cos(angulo);
}

//tangente

double Tangente(double angulo)
{
    return Math.Tan(angulo);
}

//convertir grados a radianes

double GradosARadianes(double grados)
{
    return grados * Math.PI / 180.0;
}

//rad a grados

double RadianesAGrados(double radianes)
{
    return radianes * 180.0 / Math.PI;
}

//generar un numero aleatorio entre 1 y 0 

double NumeroAleatorio()
{
    Random rnd = new Random();
    return rnd.NextDouble();
}

//generar un numero dentro de un rango específico

int NumeroAleatorioEnRango(int min, int max)
{
    Random rnd = new Random();
    return rnd.Next(min, max + 1);
}

//valor absoluto de un decimal

double ValorAbsoluto(double num)
{
    return Math.Abs(num);
}

//raiz cuadrada

double RaizCuadrada(double num)
{
    return Math.Sqrt(num);
}

//logaritmo natural

double LogaritmoNatural(double num)
{
    return Math.Log(num);
}

//log base 10 double LogaritmoBase10(double num)
{
    return Math.Log10(num);
}

//MCD

int MCD(int a, int b)
{
    while (b != 0)
    {
        int temp = b;
        b = a % b;
        a = temp;
    }
    return a;
}

//MCM

int MCM(int a, int b)
{
    return (a * b) / MCD(a, b);
}

//verificar si es primo

bool EsPrimo(int num)
{
    if (num <= 1)
        return false;
    if (num == 2)
        return true;
    if (num % 2 == 0)
        return false;
    for (int i = 3; i * i <= num; i += 2)
    {
        if (num % i == 0)
            return false;
    }
    return true;
}

//area de un circulo con r radio

double AreaCirculo(double radio)
{
    return Math.PI * Math.Pow(radio, 2);
}


