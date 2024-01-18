namespace Records{

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Records !!!");

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

}
