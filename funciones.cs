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

