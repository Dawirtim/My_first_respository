namespace respository
{
    public class Samochod
    {
        string kolor, marka, model;
        int pojemnoscSilnika, iloscDrzwi;
        public Samochod(string kolor, string marka, string model, int pojemnoscSilnika, int iloscDrzwi)
        {
            this.kolor = kolor;
            this.marka = marka;
            this.model = model;
            this.pojemnoscSilnika = pojemnoscSilnika;
            this.iloscDrzwi = iloscDrzwi;
        }
        public void Opis()
        {
            Console.WriteLine($"Kolor: {kolor}, Marka: {marka}, Model: {model}, Pojemność silnika {pojemnoscSilnika} cm^3, Ilosc drzwi: {iloscDrzwi}");
        }
    }
}