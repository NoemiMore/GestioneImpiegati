using System;

namespace GestioneImpiegati
{
    class Program
    {
        /*
         Creare una Console Application che per la gestione degli impiegati di un’azienda.
Entità:
L’impiegato deve essere inteso come una derivazione di Persona.
Persona ha le seguenti caratteristiche:
•Nome
•Cognome
•Codice Fiscale
L’impiegato ha anche le seguenti caratteristiche:
•Settore (Vendite, Amministrazione. Sviluppo)
•Calcolo stipendio mensile (metodo)
•Lista di skills (opzionale)
Il Tecnico è un impiegato ma ha anche:
•Paga Oraria
•Ore Lavorate
•Calcolo stipendio; lo stipendio mensile del tecnico è dato da: Ore Lavorate * Paga Oraria
Lo Stagista è un impiegato ma ha anche:
•Durata dello stage (in mesi. Esempio: 3)
•Calcolo stipendio: lo stipendio mensile dello stagista è 600 €.
Il manager è un impiegato ma ha anche:
•Ore di straordinario (nel mese)
•Stipendio di base (mensile)
•Calcolo stipendio: lo stipendio mensile del manager è dato da: Stipendio Base + (Ore di straordinario * 10).
(opzionale) La Skill ha come caratteristiche:
• Codice
• Descrizione
Inizializzare una lista di impiegati, con almeno un elemento per ogni sottoclasse di impiegato.
Programma:
All’accesso, l’utente deve poter scegliere tra:
1. Visualizzare tutti gli impiegati come Nome Cognome – Settore – Skills (opzionale) - Stipendio
2. Mostrare gli impiegati appartenenti ad un determinato settore
3. Inserire un nuovo impiegato, verificando che non sia già nella lista. Due Persone sono uguali se hanno lo stesso codice fiscale.
4. Eliminare un impiegato.
5. (opzionale) Visualizzare gli impiegati con stipendio maggiore o uguale a quello inserito dall’utente.
6. (opzionale) Visualizzare tutti gli impiegati con una certa skill
Quando l’utente termina un’operazione, deve poter rivedere il menu e fare un’altra scelta.
Inserire i controlli opportuni.
         */
        static void Main(string[] args)
        {
            Menu.Start();


        }

        
    }
}
