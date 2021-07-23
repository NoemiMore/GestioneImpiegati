using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestioneImpiegati
{
    class Manager: Impiegato
    { 
        public int Overtime { get; set; }
        public decimal ManagerBasicSalary { get; set; } = 2000;



        public Manager (string firstName, string lastName, string fiscalCode, SectorEnum sector, decimal salaryOfficeWorker, int overtime, decimal managerBasicSalary) :
            base(firstName, lastName, fiscalCode, sector, salaryOfficeWorker)
        {

            Overtime = overtime;
            ManagerBasicSalary = managerBasicSalary;

        }

        public Manager()
        { }
        

       
    }
}
