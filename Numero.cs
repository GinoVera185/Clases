public class Numero
{
    int Num;
    public static int getNumero(string mensaje = "")
    {
        int Num;

        do
        {
            Console.WriteLine(mensaje);

        } while (!int.TryParse(Console.ReadLine(), out Num));

        return Num;
    }
}
