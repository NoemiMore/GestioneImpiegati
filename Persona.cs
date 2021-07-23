using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestioneImpiegati
{
    class Persona
    { public string FirstName { get; set; }
        public string LastName { get; set; }

        public string FiscalCode { get; set; }



        public Persona (string firstName, string lastName, string fiscalCode)
        {
           
            FirstName = firstName;
            LastName = lastName;
            FiscalCode = fiscalCode;
            
        }

        public Persona ()
        {

        }
    }
}
