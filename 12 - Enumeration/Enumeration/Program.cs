using System;
using System.Xml;

namespace Enumeration
{
    enum PuntoCardinale {nord,sud,est,oves};
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
        }
    }
}
