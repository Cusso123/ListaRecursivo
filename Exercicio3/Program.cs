
int[] valores = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
Console.WriteLine("O arrey em ordem decrescente fica: ");
ArrayInvertido(valores);

foreach (int element in valores)
{
    Console.Write(element + " ");
}

static void ArrayInvertido(int[] array)
{
    ArrayApoio(array, 0, array.Length - 1);
}

static void ArrayApoio(int[] array, int Inicio, int Fim)
{
    if (Inicio >= Fim)
    {
        return;
    }

    int temp = array[Inicio];
    array[Inicio] = array[Fim];
    array[Fim] = temp;

    ArrayApoio(array, Inicio + 1, Fim - 1);
}
