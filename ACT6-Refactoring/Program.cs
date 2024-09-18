class Program
{
    static void Main()
    {
        const int NUM_NOTES = 3, NOTA_TALL = 6;
        int nota1, nota2, nota3;

        Console.WriteLine("Introdueix la primera qualificació: ");
        nota1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Introdueix la segona qualificació: ");
        nota2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Introdueix la tercera qualificació: ");
        nota3 = Convert.ToInt32(Console.ReadLine());

        float promig = (nota1 + nota2 + nota3) / NUM_NOTES;
        string msg = "El promig de les notes es: " + promig;

        Console.WriteLine(msg += (promig > NOTA_TALL) ? "\n\nAprovat" : "\n\nSuspès");        
    }
}
