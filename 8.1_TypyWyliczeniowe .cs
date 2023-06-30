using System;

class Program
{
    enum DniTygodnia
    {
        Poniedziałek = 1,
        Wtorek,
        Środa,
        Czwartek,
        Piątek,
        Sobota,
        Niedziela
    }

    enum EtapyPrania
    {
        PierwszePlukanie = 1,
        Pranie,
        DrugiePłukanie,
        Wirowanie,
        Suszenie
    }

    enum Posiłki
    {
        Śniadanie = 1,
        Obiad,
        Deser,
        Kolacja
    }

    [Flags]
    enum BierkiSzachowe
    {
        Pionek = 10,
        Skoczek = 11,
        Goniec = 12,
        Wieża = 13,
        Hetman = 14,
        Król = 15
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Wyliczenia:");
        Console.WriteLine(" ");
        Console.WriteLine("Dni tygodnia:");
        foreach (DniTygodnia dzien in Enum.GetValues(typeof(DniTygodnia)))
        {
            Console.WriteLine((int)dzien + " - " + dzien);
        }

        Console.WriteLine();

        Console.WriteLine("Etap prania:");
        foreach (EtapyPrania etap in Enum.GetValues(typeof(EtapyPrania)))
        {
            Console.WriteLine((int)etap + " - " + etap);
        }

        Console.WriteLine();

        Console.WriteLine("Posiłki:");
        foreach (Posiłki posilek in Enum.GetValues(typeof(Posiłki)))
        {
            Console.WriteLine((int)posilek + " - " + posilek);
        }

        Console.WriteLine();

        Console.WriteLine("Bierki szachowe:");
        foreach (BierkiSzachowe bierka in Enum.GetValues(typeof(BierkiSzachowe)))
        {
            Console.WriteLine((int)bierka + " - " + bierka);
        }

        Console.ReadLine();
    }
}
