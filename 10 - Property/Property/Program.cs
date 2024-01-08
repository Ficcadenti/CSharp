namespace Property;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Le Property !!!");
        Persona p=new Persona();
        p.Nome="Raffaele";
        Console.WriteLine($"nome={p.Nome}");
        Console.WriteLine($"nome={p.testNome()}");

        p.Cognome="Ficcadenti";
        Console.WriteLine($"cognome={p.Cognome}");

        Console.WriteLine($"p={p.Denominazione}");

        Console.WriteLine($"indirizzo={p.Indirizzo}");

        Persona p1=new Persona(){Nome="Valeria", Cognome="Greco"};
        Console.WriteLine($"nome={p1.Nome}");
        Console.WriteLine($"cognome={p1.Cognome}");
        Console.WriteLine($"p1={p1.Denominazione}");
        Console.WriteLine($"indirizzo={p1.Indirizzo}");
    }

    public class Persona{
        private string nome;
        //property con backing field
        public string Nome{
            get{ return nome;}
            set{nome=value;}
        }
        private string cognome;
        //property con backing field
        public string Cognome{
            get{ return cognome;}
            set{cognome=value;}
        }

        //property senza backing field
        public string Denominazione{
            get{ return $"{cognome} {nome}";}
            
        }
        
        public string testNome()
        {
            return nome;
        }

        //property auto-implementate
        public string Indirizzo{get;set;}="Via Castellamonte 82";


    }
}
