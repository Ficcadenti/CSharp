using System;

namespace Biblioteca
{
    class Biblioteca
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Biblioteca !!!");
            Utente u=new Utente(){Id="001",Nome="Raffaele",Cognome="Ficcadenti",AnnoIscrizione="2024"};
            Utente u1=new Utente(){Id="002",Nome="Valeria",Cognome="Greco",AnnoIscrizione="2023"};
            Libro l=new Libro(){Id="L001",Titolo="Sono puri i loro sogni",Autore="Matteo Bussola"};
            Console.WriteLine($"{u.Denominazione()}");
            Console.WriteLine($"{u1.Denominazione()}");
            Console.WriteLine($"{l.Descrizione}");
            l.Prestito(u);
            l.Prestito(u1);
            l.Restituzione();
            l.Prestito(u1);

        }
    }

    public class Persona
    {
        public string? Nome{get;set;}
        public string? Cognome{get;set;}

        public virtual string Denominazione()
        {
                return $"{Cognome} {Nome}";
        }
    }

    public class Utente: Persona
    {
        public string? Id{get;set;}
       
        public string? AnnoIscrizione{get;set;}

        public override string Denominazione()
        {
                return $"{Id} {Cognome} {Nome}";
        }

    }

    public class Libro
    {
        public string? Id{get;set;}
        public string? Titolo{get;set;}
        public string? Autore{get;set;}

        private Utente? utente{get;set;}=null;

        public string Descrizione
        {
            get{
                return $"{Titolo} di {Autore}";
            }
        }

        public void Prestito(Utente utente)
        {
            if(this.utente!=null)
            {
                Console.WriteLine($"Titolo gia prestato a {this.utente.Denominazione} !!!" );
                return;
            }
            this.utente=utente;
            Console.WriteLine($"Titolo prestato a {utente.Denominazione} !!!" );
        }  

        public void Restituzione()
        {
            if(this.utente!=null)
            {
                Console.WriteLine($"{this.utente.Denominazione} ha restituito il libro !!! " );
                this.utente=null;
            }
        }
    }
}