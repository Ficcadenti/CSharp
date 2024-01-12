using static System.Console;

namespace Primo.Secondo.Terzo
{
    class Utility
    {
        public static void m(string[] args)
        {
            Console.WriteLine("Namespace  Primo.Secondo.Terzo.Program !!!");
            if(args!=null)
            {
                foreach(string str in args)
                {
                    //codice poco leggibile
                    WriteLine(str);
                }
            }
        }
    }
}



namespace A
{
    namespace B
    {
        namespace C
        {

            class Utility
            {
                public static void m(string[] args)
                {
                    Console.WriteLine("Namespace  A.B.C.Program !!!");
                    if(args!=null)
                    {
                        foreach(string str in args)
                        {
                            Console.WriteLine($"str={str}");
                        }
                    }
                }
            }
        }
    }
}

namespace Test
{
    using alias1 = Primo.Secondo.Terzo;
    using alias2 = A.B.C;
    class Program
    {
        static void Main(string[] args)
        {
            alias1.Utility.m(args);
            alias2.Utility.m(args);
        }
    }
}

