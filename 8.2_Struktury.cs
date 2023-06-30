using System;

struct Student
{
    public string Imie;
    public string Nazwisko;
    public float DataUrodzenia;
    public int NumerAlbumu;
    public int RokStudiow;
    public int Semestr;
    public string Email;
    public string OddzialUczelni;
}

struct Przedmiot
{
    public string Nazwa;
    public string Kod;
    public int PunktyECTS;
    public string Prowadzacy;
    public string CelZajec;
    public int IloscGodzin;
}

struct NauczycielAkademicki
{
    public string Imie;
    public string Nazwisko;
    public string StopienNaukowy;
    public string Specjalizacja;
    public string Uczelnia;
    
}

class Program
{
    static void Main(string[] args)
    {
        // baza danych
        Student student = new Student();
        student.Imie = "Maria";
        student.Nazwisko = "Blum";
        student.DataUrodzenia = 20-04-1992;
        student.NumerAlbumu = 12345;
        student.RokStudiow = 3;
        student.Semestr = 5;
        student.Email = "maria.blum@wsb.gdansk.com.pl";
        student.OddzialUczelni = "WSB GDAŃSK";

        Przedmiot przedmiot = new Przedmiot();
        przedmiot.Nazwa = "Programowanie";
        przedmiot.Kod = "PROG0301";
        przedmiot.PunktyECTS = 10;
        przedmiot.Prowadzacy = "Dr. Antoni Kiełbasa";
        przedmiot.CelZajec = "Nauka programowania w języku Python";
        przedmiot.IloscGodzin = 50;

        NauczycielAkademicki nauczyciel = new NauczycielAkademicki();
        nauczyciel.Imie = "Antoni";
        nauczyciel.Nazwisko = "Kiełbasa";
        nauczyciel.StopienNaukowy = "Dr";
        nauczyciel.Specjalizacja = "Informatyka";
        nauczyciel.Uczelnia = "WSB GDAŃSK";


        // wyswietlenie
        // o studencie
        Console.WriteLine("Informacje o studencie:");
        Console.WriteLine("Imię: " + student.Imie);
        Console.WriteLine("Nazwisko: " + student.Nazwisko);
        Console.WriteLine("Numer albumu: " + student.NumerAlbumu);
        Console.WriteLine("Rok studiów: " + student.RokStudiow);
        Console.WriteLine("Semestr: " + student.Semestr);
        Console.WriteLine("Email: " + student.Email);
        Console.WriteLine("Oddzial uczelni: " + student.OddzialUczelni);

        Console.WriteLine();

        // o przedmiocie
        Console.WriteLine("Informacje o przedmiocie:");
        Console.WriteLine("Nazwa: " + przedmiot.Nazwa);
        Console.WriteLine("Kod: " + przedmiot.Kod);
        Console.WriteLine("PunktyECTS: " + przedmiot.PunktyECTS);
        Console.WriteLine("Prowadzący: " + przedmiot.Prowadzacy);
        Console.WriteLine("Cel zajęć: " + przedmiot.CelZajec);
        Console.WriteLine("Ilość godzin: " + przedmiot.IloscGodzin);

        Console.WriteLine();

        // o wykladowcy
        Console.WriteLine("Informacje o nauczycielu akademickim:");
        Console.WriteLine("Imię: " + nauczyciel.Imie);
        Console.WriteLine("Nazwisko: " + nauczyciel.Nazwisko);
        Console.WriteLine("Stopień naukowy: " + nauczyciel.StopienNaukowy);
        Console.WriteLine("Specjalizacja: " + nauczyciel.Specjalizacja);
        Console.WriteLine("Uczelna: " + nauczyciel.Uczelnia);

        Console.ReadLine();
    }
}