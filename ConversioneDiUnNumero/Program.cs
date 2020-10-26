using System;
using System.Reflection.Emit;

namespace ConversioneDiUnNumero
{
    class Program
    {
        static void Main(string[] args)
        {

            int abase, dabase;
            double numero;
            Console.Write("Inserisci la base da cui convertire: ");
            dabase = int.Parse(Console.ReadLine());
            Console.Write("Inserisci la base in cui convertire: ");
            abase = int.Parse(Console.ReadLine());
            Console.Write("inserisci il numero da convertire: ");
            numero = double.Parse(Console.ReadLine());
            string risultato = Convert.ToString(Convert.ToInt32(numero, dabase), abase);
            Console.WriteLine($"il numero convertito è {risultato}");
        }
    }
}

