public class Numero
{
    int Num;
    public static int getNumero(string mensaje = "")
    {
        int Num;

        do
        {
            Console.WriteLine("Ingrese un numero:");

        } while (!int.TryParse(Console.ReadLine(), out Num));

        return Num;
    }
}
