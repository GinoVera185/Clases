using System.Reflection.Metadata;
using System.Runtime.InteropServices;

public class Potencia
{
    private float coe;
    private int exp;

    public Potencia()
    {
        coe = 1;
        exp = 0;
    }

    public Potencia(float coe, int exp)
    {
        this.coe = coe;
        this.exp = exp;
    }

    public void print()
    {
        Console.WriteLine($"Potencia = {coe}x^{exp}");
    }

    public void input()
    {
        Console.WriteLine("Coeficiente: ");
        coe = float.Parse(Console.ReadLine());
        Console.WriteLine("Exponente: ");
        exp = int.Parse(Console.ReadLine());
    }

    public float evaluar()
    {
        float r = 1;

        for (int i = 1; i <= (exp > 0 ? exp : -exp); i++)
        {
            r *= coe;
        }
        return (exp > 0 ? r : 1 / r);
    }

    static float evaluar(float c, int e)
    {
        Potencia tmp = new Potencia(c, e);
        return tmp.evaluar();
    }
}