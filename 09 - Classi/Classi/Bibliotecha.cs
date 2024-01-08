using System;

namespace Biblioteca
{
    class Biblioteca
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Biblioteca !!!");
            Utente u=new Utente("U001","Raffaele","Ficcadenti","2024");
            Utente u1=new Utente("U002","Valeria","Greco","2024");
            Libro l=new Libro("L001","Sono puri i loro sogni","Matteo Bussola");
            Console.WriteLine($"{u.Denominazione()}");
            Console.WriteLine($"{u1.Denominazione()}");
            Console.WriteLine($"{l.Descrizione()}");
            l.Prestito(u);
            l.Prestito(u1);
            l.Restituzione();
            l.Prestito(u1);

        }
    }

    public class Utente
    {
        private string id;
        private string nome;
        private string cognome;
        private string annoIscrizione;

        public Utente(string id,string nome, string cognome,string annoIscrizione)
        {
            this.id=id;
            this.nome=nome;
            this.cognome=cognome;
            this.annoIscrizione=annoIscrizione;
        }

        public string Denominazione()
        {
            return $"{this.cognome} {this.nome}, id={this.id}, iscritto il={this.annoIscrizione}";
        }

    }

    public class Libro
    {
        private string id;
        private string titolo;
        private string autore;

        private Utente? utente;

        public Libro(string id, string titolo,string autore)
        {
            this.id=id;
            this.titolo=titolo;
            this.autore=autore;
            utente=null;
        }

        public string Descrizione()
        {
            return $"{this.titolo} di {this.autore}";
        }

        public void Prestito(Utente utente)
        {
            if(this.utente!=null)
            {
                Console.WriteLine($"Titolo gia prestato a {this.utente.Denominazione()} !!!" );
                return;
            }
            this.utente=utente;
            Console.WriteLine($"Titolo prestato a {utente.Denominazione()} !!!" );
        }  

        public void Restituzione()
        {
            Console.WriteLine($"{this.utente.Denominazione()} ha restituito il libro !!! " );
            this.utente=null;
        }
    }
}