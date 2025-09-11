using System;

public class Program
{

    public static void Main(String[] args)
    {
        int num;
        num = Numero.getNumero();
        Console.WriteLine($"Los mutiplos de {num} son:");

        int[] A = new int[10];

        int J = 0;

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