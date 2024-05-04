using System;
using System.IO;

class Program
{
    static void Main()
    {
        string sciezkaDoPliku = "plik.txt"; // wpisz ścieżkę do pliku

        if (File.Exists(sciezkaDoPliku))
        {
            using (FileStream strumienPliku = new FileStream(sciezkaDoPliku, FileMode.Open, FileAccess.Read))
            {
                using (StreamReader czytnik = new StreamReader(strumienPliku))
                {
                    string zawartoscPliku = czytnik.ReadToEnd();
                    Console.WriteLine("Zawartość pliku:");
                    Console.WriteLine(zawartoscPliku);
                }
            }
        }
        else
        {
            Console.WriteLine("Plik nie istnieje.");
        }

        Console.ReadLine();
    }
}
