using System.ComponentModel;
using System;
using bertozzi.mattia._5H.PrimoEF.Models;

namespace bertozzi.mattia._5H.PrimoEF
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ciao Rimac db-World!");

            //apro il db
            DbPersone db = new();

            for(int i=0;i<1000;i++)
            {
                //aggiungo una nuova persona
                db.Persone.Add(new Persona{Nome="Mattia",Cognome="Bertozzi",Email="matty.bertozzi@gmail.com"});
            }

            db.SaveChanges();
        }
    }
}
