
double[] Valores = { 5.25, 10.5, 15, 20 };

double soma = Soma(Valores, Valores.Length);

Console.WriteLine(soma);
double Soma(double[] valores, int A)
{

    if (A == 0)
        return 0;

    return Valores[A - 1] + Soma(Valores, A - 1);
}
