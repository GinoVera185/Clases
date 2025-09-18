using System.Runtime.InteropServices;

public class Arreglo
{
    private int[] numeros;
    private int size;

    public Arreglo()
    {
        numeros = new int[10];
        size = 10;
    }

    public Arreglo(int n)
    {
        size = (n < 1 ? 10 : n);
        numeros = new int[size];
    }

    public void input()
    {
        Console.WriteLine($"Ingrese {size} numeros: ");
        for (int i = 0; i < size; i++)
        {
            numeros[i] = Numero.getNumero($"Ingrese el elemento {i + 1}: ");
        }
    }

    public void print()
    {
        Console.WriteLine($"Mostrando arreglo de {size} localidades: ");
        foreach (int num in numeros)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
    }

    public void printArray()
    {
        foreach (int num in numeros)
        {
            Console.Write(num + " ");
        }
    }

    public void metodo()
    {
        Console.WriteLine("Mostrando metodo alterno a la burbuja");
        int it = 0, c = 0, inter = 0;
        print();
        for (int i = 0; i < size - 1; i++)
        {
            inter++;
            for (int j = i + 1; j < size; j++)
            {
                it++;
                if (numeros[i] > numeros[j])
                {
                    c++;
                    int tmp = numeros[i];
                    numeros[i] = numeros[j];
                    numeros[j] = tmp;
                    printArray();
                }
            }
        }
        Console.WriteLine($"Iteraciones: {it}");
        Console.WriteLine($"Comparaciones: {c}");
        Console.WriteLine($"Intercambios: {inter}");
    }
}