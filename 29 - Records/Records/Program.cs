namespace Records{

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Records !!!");

            Libro l1=new Libro("Aspetta primavera, Bandini","John Fante");
            Libro l2=new Libro("Bravo, Burro!","John Fante");
            Libro l3=new Libro("Bravo, Burro!","John Fante");

            Console.WriteLine(l1);
            Console.WriteLine(l2);
            Console.WriteLine(l3);

            Console.WriteLine(l1==l2);
            Console.WriteLine(l3==l3);


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

        /*
        public override string ToString()
        {
            return $"{base.ToString} - {Titolo} - {Autore}";
        }
        */
    }

}
