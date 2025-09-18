using System;

public class Program
{

    public static void Main(String[] args)
    {
        //Clase Semana 1
        /*int num, t;
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

        //clase Semana 2 16/09/2025
        /*
        Potencia p = new Potencia();
        Potencia p1 = new Potencia(2, 3);
        p.print();
        p1.print();
        p.input();
        p.print();
        Console.WriteLine($"Evaluando {p1.evaluar()}");

        Console.WriteLine($"Evaluando {Potencia.evaluar(3, 2)}");
        */

        //clase Semana 2 18/09/2025
        Arreglo A;

        int n;
        n = Numero.getNumero("Ingrese cantidad de numero: ");
        A = new Arreglo(n);
        A.input();
        A.print();
    }
}