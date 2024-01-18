using System;
using System.Text;
namespace Records{

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Records !!!");

            StringBuilder myStringBuilder = new StringBuilder("String Builder !!!");
            myStringBuilder.Append("\nCiaone !!!");
            Console.WriteLine(myStringBuilder.ToString());

            Libro l1=new Libro("Aspetta primavera, Bandini","John Fante");
            Libro l2=new Libro("Bravo, Burro!","John Fante");
            Libro l3=new Libro("Bravo, Burro!","John Fante");
            Libro1 l4=new Libro1("Bravo, Burro!","John Fante");
            Libro1 l5=new Libro1("Bravo, Burro!","John Fante");

            Console.WriteLine(l1);
            Console.WriteLine(l2);
            Console.WriteLine(l3);
            Console.WriteLine(l4);

            Console.WriteLine(l1==l2);
            Console.WriteLine(l2==l3);
            Console.WriteLine(l5==l4);

            //l5.Titolo="Chiedi alla polvere";
            Console.WriteLine($"Titolo={l5.Titolo} Autore={l5.Autore}");

            LibroDigitale l6=new LibroDigitale("Bravo, Burro!","John Fante",100);
            LibroDigitale l7=new LibroDigitale("Bravo, Burro!","John Fante",100);
            LibroDigitale1 l8=new LibroDigitale1("Bravo, Burro!","John Fante",100);
            Console.WriteLine(l6);

            Console.WriteLine(l6==l7);
            Console.WriteLine(l7==l8);

        }
    }

    public record Libro
    {
        public string? Titolo {get;init;}
        public string? Autore {get;init;}

        public Libro(){}

        public Libro(string? titolo, string? autore)
        {   
            this.Titolo=titolo; 
            this.Autore=autore; 
        }
    }

    public record Libro1(string Titolo, string Autore);

    public record LibroDigitale (string Titolo, string Autore, int durata):Libro1(Titolo,Autore);
    public record LibroDigitale1 (string Titolo, string Autore, int durata):Libro1(Titolo,Autore);

}
