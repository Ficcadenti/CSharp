using System;
using System.Collections;

namespace Collection{

    class Program
    {
        

        static void Main(string[] args)
        {
            Console.WriteLine("Le Collections!");

            //ArrayList
            ArrayList coll = new ArrayList(); 
            string s = "Ciao"; 
            coll.Add(s); 
            coll.Add("Test"); 
            coll.Add(50); 
            coll.Add(new object());

            string[] tempArray = new string[]{"uno", "due", "tre" }; 
            coll.AddRange(tempArray); 
            object[] altroArray = new object[]{new object(), new ArrayList()}; 
            coll.AddRange(altroArray);

            coll.Insert(3, "Buogiorno"); 
            string[] altreStringhe =new string[] { "buonasera", "ciao" };
            coll.InsertRange(4, altreStringhe);

            coll[3] = "Buongiorno modificato alla posizione 3";

            //Rimuove l'elemento 'uno' dalla collezione
            coll.Add("uno"); 
            coll.Remove("uno");

            // Rimuove il primo elemento (indice 0)
            coll.RemoveAt(0);

            // Rimuove 4 elementi a partire dall'indice 0 (cioè i primi quattro elementi)
            coll.RemoveRange(0, 4);


            string testString = "tre"; 

            if (coll.Contains(testString)) 
            { 
                int indice = coll.IndexOf(testString); 
                Console.WriteLine($"Trovata string {testString} nella collection in posizione {indice}, la cancello !!!");
                coll.RemoveAt(indice); 
            } 

            //svuota tutta la collezione
            //coll.Clear();
            
            int cont=0;
            foreach(var c in coll)
            {
                Console.WriteLine($"coll[{cont++}] = {c}");
            }
            Console.WriteLine("------------------------");
            for (int x = 0; x < coll.Count; ++x) 
            { 
                Console.WriteLine($"coll[{x}] = {coll[x]}");
            }
            Console.WriteLine("------------------------");
            IEnumerator enumerator = coll.GetEnumerator(); 
            cont=0;
            while (enumerator.MoveNext()) 
            { 
                Console.WriteLine($"coll[{cont++}] = {enumerator.Current}");
            }

            ArrayList coll2 = new ArrayList(); 
            coll2.Add("Wolf"); 
            coll2.Add("Test"); 
            coll2.Add("Albero"); 

            //ordina la collezione solo se contiene gli stessi tipi
            coll2.Sort();

            enumerator = coll2.GetEnumerator(); 
            cont=0;
            Console.WriteLine("------------------------");
            while (enumerator.MoveNext()) 
            { 
                Console.WriteLine($"coll[{cont++}] = {enumerator.Current}");
            }

            //Queue FIFO
            Queue q = new Queue(); 
            q.Enqueue("OGGETTO1"); 
            q.Enqueue("OGGETTO2"); 
            q.Enqueue("OGGETTO3"); 
            q.Enqueue("OGGETTO4"); 

            enumerator = q.GetEnumerator(); 
            Console.WriteLine("------------------------");
            while (enumerator.MoveNext()) 
            { 
                Console.WriteLine($"{enumerator.Current}");
            }

            Console.WriteLine("------------------------");
            while (q.Count!=0) 
            { 
                Console.WriteLine($"{q.Dequeue()}");
            }

            //Stack LIFO
            Stack stack = new Stack(); 
            stack.Push("OGGETTO1");
            stack.Push("OGGETTO2");
            stack.Push("OGGETTO3");
            stack.Push("OGGETTO4");
            enumerator = stack.GetEnumerator(); 
            Console.WriteLine("------------------------");
            while (enumerator.MoveNext()) 
            { 
                Console.WriteLine($"{enumerator.Current}");
            }

            Console.WriteLine("------------------------");
            while (stack.Count!=0) 
            { 
                Console.WriteLine($"{stack.Pop()}");
            }

            //Hashtable
            Hashtable nazioniHashtable = new Hashtable();
            nazioniHashtable.Add("Vincenzo","Italia"); 
            //Alternativa
            nazioniHashtable ["Paul"] = "Francia";

            enumerator = nazioniHashtable.GetEnumerator(); 
            Console.WriteLine("------------------------");
            while (enumerator.MoveNext()) 
            { 
                Console.WriteLine($"{enumerator.Current}");
            }
            Console.WriteLine("------------------------");
            foreach (DictionaryEntry oggetto in nazioniHashtable) 
            { 
                Console.WriteLine($"key={oggetto.Key} ; value={oggetto.Value}"); 
            }

            ICollection keys=nazioniHashtable.Keys;
            enumerator = keys.GetEnumerator(); 
            Console.WriteLine("------------------------");
            while (enumerator.MoveNext()) 
            { 
                Console.WriteLine($"{enumerator.Current}");
            }

            ICollection values=nazioniHashtable.Values;
            enumerator = values.GetEnumerator(); 
            Console.WriteLine("------------------------");
            while (enumerator.MoveNext()) 
            { 
                Console.WriteLine($"{enumerator.Current}");
            }

            //SortedList
            SortedList sort = new SortedList(); 
            sort["Primo"] = "1"; 
            sort["Secondo"] = "2"; 
            sort["Terzo"] = "3"; 
            sort["Quarto"] = "4"; 
            sort["quarto"] = "4"; 

            Console.WriteLine("------------------------");
            foreach (DictionaryEntry entry in sort) 
            { 
            Console.WriteLine($"{entry.Key} = {entry.Value}"); 
            }

            //BitArray
            BitArray bits = new BitArray(3); 
            bits[0] = false; 
            bits[1] = false; 
            bits[2] = true;

            BitArray bits2 = new BitArray(3); 
            bits2[0] = true; 
            bits2[1] = true; 
            bits2[2] = false;

            

            BitArray orBits = bits.Or(bits2); 
            Console.WriteLine("------------------------");
            foreach (bool bit in orBits) 
            { 
                Console.WriteLine($"orBits {bit}"); 
            }
            foreach (bool bit in bits) 
            { 
                Console.WriteLine($"bits {bit}"); 
            }

            BitArray andBits = bits.And(bits2); 
            Console.WriteLine("------------------------");
            foreach (bool bit in andBits) 
            { 
                Console.WriteLine(bit); 
            }
            



        }
    }
}
