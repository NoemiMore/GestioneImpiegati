using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestioneImpiegati
{
    internal class Menu
    {
        internal static void Start()
        {
            SalaryCalculation();
            Add();
            Console.WriteLine("Benvenuto! ");
            string  firstName, lastName, fiscalCode;

           
            
                Console.WriteLine(" Inserisci il tuo Nome");
                firstName = Console.ReadLine();

                Console.WriteLine(" Inserisci il tuo Cognome");
                lastName = Console.ReadLine();
                Console.WriteLine(" Inserisci il tuo Codice Fiscale");
                fiscalCode = Console.ReadLine();
                // fiscalCode = string.TryParse(Console.ReadLine() out fiscalCode) || fiscalCode.ToCharArray< 16;

                Console.WriteLine($"Benvenuto {firstName} + {lastName}");

            do
            {
                Console.WriteLine(" Scegli tra le seguenti opzioni:");

                Console.WriteLine("Scegli 1 per visualizzare tutti gli impiegati");
                Console.WriteLine("Scegli 2 per visualizzare i tecnici");
                Console.WriteLine("Scegli 3 per visualizzare i manager");
                Console.WriteLine("Scegli 4 per visualizzare gli stagisti ");
                Console.WriteLine("Scegli 5 per aggiungere un nuovo impiegato");
                Console.WriteLine("Scegli 6 per eliminare un impiegato");
                Console.WriteLine("Scegli 0 per uscire");


            }
            while ();


            












        }

        private static void SalaryCalculation()
        {
            throw new NotImplementedException();
        }

        private static void Add()
        {
            throw new NotImplementedException();
        }
    }

    //  private static decimal SalaryCalculation(){ al suo interno ci mettiamo un dizionario con chiave enum e valore stipendio}

    


}
