using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestioneImpiegati
{
    class ManagementImpiegati
    {
        /*static Impiegato i1 = new Impiegato()
        {
            FirstName = "Tonino",
            LastName = "Balsi",
            FiscalCode = "BSRONBO75M41H501M",
            Sector = SectorEnum.Sales,
        SalaryOfficeWorker = SectorEnum.Sales.SalaryCalculation(),
            
            }


        static Impiegato i2 = new Impiegato()
        {
            FirstName = "Luca",
            LastName = "Nelsi",
            FiscalCode = "NSRONBO85M41H301M",
            Sector = SectorEnum.Sales,
            SalaryOfficeWorker = SectorEnum.Sales.SalaryCalculation(),

        }*/




        static List<Impiegato> impiegato = new List<Impiegato>
        {



            new Tecnico {FirstName = "Mario", LastName = "Rossi", FiscalCode= "BNCRRO65M41H301M",
               Sector =SectorEnum.Sales , SalaryOfficeWorker= 2,  SalaryHour = 8, Hours= 30 },

            new Manager { FirstName = "Ciro", LastName = "Bianchi", FiscalCode= "BNCRRO65M41H301M",
                 Sector = SectorEnum.Administration , SalaryOfficeWorker= 1, Overtime= 10, ManagerBasicSalary= 2000},

            new Stagista {FirstName = "Sara", LastName = "Neri", FiscalCode= "NRISRO85M41H301F" ,
               Sector = SectorEnum.Sales , SalaryOfficeWorker= 0, StageTime= 5, SalaryStage= 600 }

            };

        };

       // internal static decimal SalaryCalculation(){}
        
            // INSERIMENTO metodo con 3 if con operazioni differenti in base al ruolo ricoperto dall'impiegato
        
    }



