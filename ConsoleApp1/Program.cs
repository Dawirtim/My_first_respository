namespace respository;
internal class Program
{
    private static void Main(string[] args)
    {
        Samochod mercedesc180cdiw204 = new Samochod("Dark Red", "Mercedes", "Klasa C", 2112, 4);
        mercedesc180cdiw204.Opis();
        Samochod skodaSuperb = new Samochod("Dark Green", "Skoda", "Superb", 1996, 4);
        skodaSuperb.Opis();
        Samochod fordmondeo = new Samochod("Dark Blue", "Ford", "Mondeo", 2164, 4);
        fordmondeo.Opis();
        Samochod fordfocus = new Samochod("Yellow", "Ford", "Focus", 1545, 2);
        fordfocus.Opis();
        Console.ReadKey();
    }
}