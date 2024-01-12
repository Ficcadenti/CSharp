namespace Eccezioni{

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Eccezioni !!!");

            int x=0;
            Console.Write("Inserisci un numero: ");
            string? s=Console.ReadLine();

            try{
                //possibile eccezzione System.FormatException
                x=Convert.ToInt32(s);
                Console.WriteLine($"Il numero inseito è : {x}");
            }catch(Exception e)
            {
                Console.WriteLine(e.StackTrace);
                Console.WriteLine("Il parametro inserito non è un numero !!!");
            }
            finally
            {
                Console.WriteLine("Parte di codice sempre eseguita");
            }

            try
            {
                sollevaEccezione(); 
            }catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }

        static void sollevaEccezione()
        {
            throw new Exception("Mia eccezione !!!");
        }
    }
}
