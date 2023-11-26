using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Uppgift_5._9 
/*Kom först inte på något inte jättekrångligt sätt att lösa uppgiften på och stötte på listor,
 så jag lärde mig om det ett tag och använde det för att lösa uppgiften.
 Sen kom jag på en lösning till att göra det med en array så jag har gjort så att man får välja
 vilken lösning man vill använda i början av programmet, båda ger samma resultat såklart men 
 så att du kan se att båda fungerar.*/
{
    class Program
    {
        public static void Main()
        {
            try
            {
                Console.WriteLine("Vilken lösning vill du testa?");
                Console.WriteLine("1. Lösning med lista");
                Console.WriteLine("2. Lösning med array");
                string svar = Console.ReadLine();
                if (svar == "1")
                {
                    LösningMedLista();
                }
                else
                {
                    LösningMedArray();
                }
                Console.ReadKey();
            }
            catch
            {
                Console.WriteLine("Fel input, vänligen försök igen");
                Console.ReadKey();
                Main();
            }
        }

        public static void LösningMedLista()
        {
            try
            {
                List<string> namnLista = new List<string>();

                while (namnLista.Count < 5)
                {
                    Console.WriteLine("Skriv in ett namn (skriv \"e\" om du vill avsluta)");
                    string svar = Console.ReadLine();
                    if (svar.ToLower() == "e")
                    {
                        break;
                    }
                    namnLista.Add(svar);
                }
                foreach (string namn in namnLista)
                {
                    Console.WriteLine(namn);
                }
            }
            catch
            {
                Console.WriteLine("Fel input, vänligen försök igen");
                Console.ReadKey();
                LösningMedLista();
            }
        }

        public static void LösningMedArray()
        {
            try
            {
                string[] namnArray = new string[1000];

                for (int i = 0; i < namnArray.Length; i++)
                {
                    Console.WriteLine("Skriv in ett namn (skriv \"e\" om du vill avsluta)");
                    string svar = Console.ReadLine();
                    if (svar.ToLower() == "e")
                    {
                        break;
                    }
                    namnArray[i] = svar;

                }
                for (int i = 0; i < namnArray.Length && namnArray[i] != null; i++)
                {
                    Console.WriteLine(namnArray[i]);
                }
            }
            catch
            {
                Console.WriteLine("Fel input, vänligen försök igen");
                Console.ReadKey();
                LösningMedArray();
            }
        }
    }
}
