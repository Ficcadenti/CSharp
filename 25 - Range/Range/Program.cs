using System;

namespace Range{

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Range !!!");

                string[] arr={"primo","secondo","terzo","quarto"};
                string[] a=arr[..2];
                foreach(string s in a)
                {
                    Console.WriteLine(s);
                }

                a=arr[2..];
                foreach(string s in a)
                {
                    Console.WriteLine(s);
                }

                a=arr[1..3];
                foreach(string s in a)
                {
                    Console.WriteLine(s);
                }

        }
    }
}
