namespace respository;
internal class Program
{
    private static void Main(string[] args)
    {
        Samochod mercedesc180cdiw204 = new Samochod("Dark Red", "Mercedes", "Klasa C", 2112, 4);
        mercedesc180cdiw204.Opis();
        Console.ReadKey();
    }
}