using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestioneImpiegati
{
    class Tecnico : Impiegato
    {
        public decimal SalaryHour { get; set; }
        public decimal Hours { get; set; }


        public Tecnico (string firstName, string lastName, string fiscalCode, SectorEnum sector, decimal salaryOfficeWorker, decimal salaryHour, decimal hours) :
            base(firstName, lastName, fiscalCode, sector, salaryOfficeWorker)
        {

            SalaryHour = salaryHour;
            Hours = hours;

        }

        //•Paga Oraria
        //•Ore Lavorate
        //•Calcolo stipendio; lo stipendio mensile del tecnico è dato da: Ore Lavorate * Paga Oraria
    }
}
