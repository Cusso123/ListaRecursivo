using System;

class Program
{
    static void Main(string[] args)
    {
        int NumeroDecimal = 100;
        int[] NumeroBinario = new int[32];

        ConverterEmBinario(NumeroDecimal, NumeroBinario, 0);

        Console.Write("O numero decimal em número binário é: ");
        for (int i = 31; i >= 0; i--)
        {
            Console.Write(NumeroBinario[i]);
        }
        Console.WriteLine();
    }

    static void ConverterEmBinario(int NumeroDecimal, int[] NumeroBinario, int index)
    {
        if (NumeroDecimal > 0)
        {
            NumeroBinario[index] = NumeroDecimal % 2;
            ConverterEmBinario(NumeroDecimal / 2, NumeroBinario, index + 1);
        }
    }
}