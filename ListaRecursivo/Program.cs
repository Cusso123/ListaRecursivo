
Console.Write("Digite a base da potencia: ");

int Base = int.Parse(Console.ReadLine());


Console.Write("Digite o expoente da potencia: ");
int Expoente = int.Parse(Console.ReadLine());

int Resultado = Potencia(Base, Expoente);


Console.WriteLine("O resultado é: " + Resultado);
int Potencia(int A, int B)
{
    // Caso base: x^0 = 1
    if (B == 0)
        return 1;

    // Passo da recursão: x^n = x * x^(n-1)
    return A * Potencia(A, B - 1);
}
