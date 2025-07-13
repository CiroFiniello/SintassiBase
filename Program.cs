using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Facciamo una somma e verifichiamo se il risultati è intero");

        float numero1 = 0;
        float numero2 = 0;

        Console.WriteLine("Inserisci il primo numero");
        numero1 = float.Parse(Console.ReadLine());

        Console.WriteLine("Inserisci il secondo numero");
        numero2 = float.Parse(Console.ReadLine());
    }
}