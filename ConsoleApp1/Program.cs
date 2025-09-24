namespace respository;
using system.data.SqlClient;
internal class Program
{
    private static void Main(string[] args)
    {
        Samochod mercedesc180cdiw204 = new Samochod("Dark Red", "Mercedes", "Klasa C", 2112, 4);
        mercedesc180cdiw204.Opis();
        Samochod skodaSuperb = new Samochod("Dark Green", "Skoda", "Superb", 1996, 4);
        skodaSuperb.Opis();
        Console.ReadKey();
    }
}