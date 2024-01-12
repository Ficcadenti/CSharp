using System;

namespace Biblioteca
{
    class Biblioteca
    {
        static IUtente[]? utenti;

        static void Main(string[] args)
        {
            Persona persona=new Persona();
            persona.Id="0001";
            persona.Nome="Raffaele";
            persona.Cognome="Ficcadenti";
            persona.AnnoIscrizione="2026";

            Organizzazione organizzazione=new Organizzazione();
            organizzazione.Id="0001";
            organizzazione.RagioneSogiale="E-Tech s.r.l.";
            organizzazione.AnnoIscrizione="2005";

            utenti=new IUtente[] {persona,organizzazione};

            stampaUtenti();
            
        }


        static void stampaUtenti()
        {
            if(utenti!=null)
            {
                foreach(IUtente utente in utenti)
                {
                    Console.WriteLine(utente.Denominazione);
                }
            }
        }
    }

    public interface IUtente
    {
        string? Id{get;set;}
       
        string? AnnoIscrizione{get;set;}

        string? Denominazione{get;}
    }

    public class Persona: IUtente
    {
        public string? Nome{get;set;}
        public string? Cognome{get;set;}  

        public string? Id{get;set;}       
        public string? AnnoIscrizione{get;set;}
        public string Denominazione{
            get
            {
                return $"{Id} {Nome} {Cognome}";
            }
        }
    }

    public class Organizzazione: IUtente
    {
        public string? RagioneSogiale{get;set;}

        public string? Id{get;set;}       
        public string? AnnoIscrizione{get;set;}
        public string Denominazione{
            get
            {
                return $"{Id} {RagioneSogiale} ";
            }
        }

    }

   
}