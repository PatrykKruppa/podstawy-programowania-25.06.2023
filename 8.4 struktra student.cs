using System;

// Struktura Student
struct Student
{
    public string nazwisko;
    public int nrAlbumu;
    public double ocena;
    public Plec plec;
}

enum Plec
{
    Mezczyzna,
    Kobieta
}

class Program
{
    static void Main()
    {
        // Tablica do przechowywania grupy studentów
        Student[] grupa = new Student[5];

        // Pętal do wypełnienia struktury Student
        for (int i = 0; i < grupa.Length; i++)
        {
            Console.WriteLine("Proszę o wprowadzenie danych dla studenta {0}:", i + 1);
            WypelnijDaneStudenta(ref grupa[i]);
        }

        Console.WriteLine("\nInformacje o studentach:");
        // Wyświetlanie informacji o studentach
        foreach (Student student in grupa)
        {
            WyswietlInformacjeStudenta(student);
        }

        // Średnia wszystkich ocen
        double srednia = ObliczSredniaOcen(grupa);

        Console.WriteLine("\nŚrednia ocen wszystkich studentów: {0}", srednia.ToString("F2"));
    }

    static void WypelnijDaneStudenta(ref Student student)
    {
        Console.Write("Nazwisko studenta: ");
        student.nazwisko = Console.ReadLine();

        Console.Write("Nr albumu studenta: ");
        student.nrAlbumu = Convert.ToInt32(Console.ReadLine());

        do
        {
            Console.Write("Ocena z egzaminu: ");
            student.ocena = Convert.ToDouble(Console.ReadLine());

            // Weryfikacja wpisanej wartości przez uzytkownika
            if (student.ocena < 2.0)
            {
                Console.WriteLine("Błędna ocena! Wprowadź ocenę nie niższą niż 2.0.");
            }
            else if (student.ocena > 5.0)
            {
                Console.WriteLine("Błędna ocena! Wprowadź ocenę nie wyższą niż 5.0.");
            }
        }
        while (student.ocena < 2.0 || student.ocena > 5.0);

        Console.Write("Płeć studenta (0 - Mężczyzna, 1 - Kobieta): ");
        int plec = Convert.ToInt32(Console.ReadLine());
        student.plec = (Plec)plec;
    }

    static void WyswietlInformacjeStudenta(Student student)
    {
        Console.WriteLine("Nazwisko studenta: {0}, Nr albumu syudenta: {1}, Ocena z egzaminu: {2}, Płeć studenta: {3}",
            student.nazwisko, student.nrAlbumu, student.ocena, student.plec);
    }

    static double ObliczSredniaOcen(Student[] grupa)
    {
        double sumaOcen = 0.0;

        foreach (Student student in grupa)
        {
            sumaOcen += student.ocena;
        }

        double srednia = sumaOcen / grupa.Length;

        return srednia;
    }
    
    
}