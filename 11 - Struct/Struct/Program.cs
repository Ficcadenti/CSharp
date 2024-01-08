namespace Struct;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Struct !!!");

        Persona p=new Persona(){Nome="Raffaele"};
        //value type
        Persona p1=p;


        p1.Nome="Valeria";
        Console.WriteLine($"p.nome={p.Nome}");
        Console.WriteLine($"p1.nome={p1.Nome}");

        PersonaC pc=new PersonaC(){Nome="Gabriele"};
        //reference type
        PersonaC pc1=pc;

        pc1.Nome="Maria";
        Console.WriteLine($"p.nome={pc.Nome}");
        Console.WriteLine($"p1.nome={pc1.Nome}");

    }

    struct Persona
    {
        public string Nome{get;set;}
    }
    
    class PersonaC
    {
        public string Nome{get;set;}
    }
}
