using System.Linq;
using System.Collections;

namespace LINQ{

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("LINQ !!!");
            long memoryBefore = GC.GetTotalMemory(true);
            Console.WriteLine($"Memory free = {memoryBefore} byte");

            int[] numeri = { 1, 2, 3, 4, 5 };
            var numeriPari = from n in numeri where (n%2 == 0) select n;

            foreach(int n in numeriPari)
            {
                Console.WriteLine(n);
            }

            string[] nomi = { "Peppe", "Andrea", "Paola", "Patrizia" };
            var nomiCheInizianoConLaP = from n in nomi  where n.StartsWith("P") orderby n ascending select n;
            foreach(string s in nomiCheInizianoConLaP)
            {
                Console.WriteLine(s);
            }

            ArrayList coll = new ArrayList(); 
            coll.Add("Valeria"); 
            coll.Add("Raffaele"); 
            coll.Add("Sofia"); 
            coll.Add("Maria"); 
            coll.Add("Gatto"); 
            coll.Add("Gabriele"); 
            coll.Add("Mia"); 


            coll.Sort();

            IEnumerator enumerator = coll.GetEnumerator(); 
            int cont=0;
            while (enumerator.MoveNext()) 
            { 
                Console.WriteLine($"coll[{cont++}] = {enumerator.Current}");
            }

            var query = from String s in coll where s.StartsWith("M") orderby s descending select s;
            foreach(string str in query)
            {
                Console.WriteLine(str);
            }
            


        }
    }
}
