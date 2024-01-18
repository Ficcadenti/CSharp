using System;

namespace Indici{

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Indici !!!");

            string[] arr={"primo","secondo","terzo","quarto"};

            Index primo=0;
            Index ultimo=^1;

            string s=arr[primo];
            Console.WriteLine(s);
            s=arr[ultimo];
            Console.WriteLine(s);

            Console.WriteLine(arr[^2]);

        }
    }
}
