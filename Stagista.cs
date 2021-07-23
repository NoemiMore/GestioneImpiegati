using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestioneImpiegati
{
    class Stagista : Impiegato
    { public int StageTime { get; set; }
        public decimal SalaryStage { get; set; } = 600;



        public Stagista (string firstName, string lastName, string fiscalCode, SectorEnum sector, decimal salaryOfficeWorker, int stageTime, decimal salaryStage) :
            base(firstName, lastName, fiscalCode, sector, salaryOfficeWorker)
        {

            StageTime = stageTime;
            SalaryStage = salaryStage;

        }

        public Stagista()
        { }

        }
    }
