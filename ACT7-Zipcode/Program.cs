class Program
{
    static void Main()
    {
        const string MENU = "1. Afegir Codi - Ciutat a la llista\n2. Mostrar la llista\n3. Sortir";
        int option;
        List<string> cities = new List<string>();

        do
        {
            Console.WriteLine(MENU);
            option = int.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                    Console.Write("Introdueix el codi de la ciutat: ");
                    string cityCode = Console.ReadLine();
                    Console.Write("Introdueix el nom de la ciutat: ");
                    string cityName = Console.ReadLine();
                    cities.Add($"{cityCode} - {cityName}");
                    break;

                case 2:
                    Console.WriteLine("Llista de ciutats:");
                    foreach (var city in cities)
                    {
                        Console.WriteLine(city);
                    }
                    Console.ReadKey();
                    break;

                case 3:
                    Console.WriteLine("Sortint...");
                    break;

                default:
                    Console.WriteLine("Opció no vàlida. Torna a intentar-ho.");
                    Console.ReadKey();
                    break;
            }
            Console.Clear();
        } while (option != 3);
    }
}
