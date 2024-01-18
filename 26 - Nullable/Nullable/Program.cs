using System;
namespace Nullable{

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nullable reference types !!!");

            //int x =null; //ERRORE

            #nullable enable
            string? s=null;
            saluto(s!);
        }

        private static void saluto(string s)
        {
            if(s!=null)
                Console.WriteLine($"Ciao {s}");
        }
    }
}