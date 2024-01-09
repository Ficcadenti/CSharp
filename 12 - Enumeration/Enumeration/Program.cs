using System;
using System.Xml;

namespace Enumeration
{
    enum PuntoCardinale:short {nord,sud,est,ovest};
    enum Esito {OK=1,KO=0};

    enum HttpError {OK=200,FORBIDDEN=403, INTERNAL_ERROR};
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enumeratione !!!");
            PuntoCardinale direzione=PuntoCardinale.est;
            Console.WriteLine(direzione);

            if(direzione==PuntoCardinale.est)
            {
                Console.WriteLine("Sei puntato ad est, dove sorge il sole... !!!");
            }

            Console.WriteLine((short)PuntoCardinale.ovest);
            Console.WriteLine(Esito.OK);
            Console.WriteLine((int)Esito.OK);
            Console.WriteLine((int)HttpError.FORBIDDEN);
            Console.WriteLine((int)HttpError.INTERNAL_ERROR);
        }
    }
}
