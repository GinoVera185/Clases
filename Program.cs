using System;

public class Program
{

    public static void Main(String[] args)
    {
        int num, t;
        num = Numero.getNumero("Ingrese un numero: ");
        t = Numero.getNumero("Ingrese el tamaño del arreglo: ");

        Console.WriteLine($"Los multiplos de {num} son: ");
        int[] A = new int[t];

        int j = 0;

        for (int i = 1; i <= 10; i++)
        {
            A[i] = 0;
        }

        for (int i = 1; i < 10; i++)
        {
            if (num % i == 0)
            {
                A[j++] = i;
            }
        }

        foreach (int i in A)
        {
            Console.WriteLine(i + " ");
        }

        /*
        for (int i = 1; i <= num; i++)
        {
            if (num % i == 0)
            {
                Console.WriteLine(i);
            }
        }
        */

    }
}