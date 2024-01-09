namespace Struct;

using prs = Struct.Program.Persona;
using prid = Struct.Program.PeerId;

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


        //Built-in types 
        System.Boolean b=new System.Boolean();
        b=true;
        Console.WriteLine(b);

        //alias
        prs p3=new prs();
        p3.Nome="10";
        Console.WriteLine($"p3.nome={p3.Nome}");

        prid p4=34;
        Console.WriteLine($"prid={p4}");

    }

    public struct Persona
    {
        public string Nome{get;set;}
    }
    
    class PersonaC
    {
        public string Nome{get;set;}
    }

    public struct PeerId
    {
        private int peer;

        public static implicit operator PeerId(int i)
        {
            return new PeerId {peer=i};
        }

        public static implicit operator int(PeerId p)
        {
            return p.peer;
        }
    }
}
