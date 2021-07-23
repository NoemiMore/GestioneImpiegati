using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestioneImpiegati
{
    class Impiegato : Persona
    { public SectorEnum Sector { get; set; }

    //public Dictionary<SectorEnum, string> Sector = new Dictionary<SectorEnum, string>();
        public decimal SalaryOfficeWorker { get; set; }
        // SalaryCalculation();

        // potrei inserire per lo stipendio impiegato un dizionario con chiave enum valore decimal?

        public Impiegato(string firstName, string lastName, string fiscalCode, SectorEnum sector, decimal salaryOfficeWorker) :
            base ( firstName, lastName, fiscalCode)
        {

            Sector = sector;
            SalaryOfficeWorker = salaryOfficeWorker;

        }

        public Impiegato()
        {

        }

    }
    public enum SectorEnum
    {
        Sales, //Stagista,
        Administration, //Manager, 
        Development//= Tecnico
    }
}
