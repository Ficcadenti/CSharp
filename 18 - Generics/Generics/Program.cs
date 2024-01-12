using System.Security.Cryptography.X509Certificates;

namespace Generics{


    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("I Generics !!!");

            Stampante t=new Stampante();
            int i=t.Stampa<int,string>(10,"Ciao","Ciaone");
            string s=t.Stampa<string,string>("Raffaele","Ficcadenti","Roma");
            double d=t.Stampa(3.14159d,10,11);

            Lista<string> listaStr=new Lista<string>();

            int pos=8;
            listaStr.Inserisci("Raffaele",pos);
            Console.WriteLine($"pos={pos} {listaStr.Valore(pos)}");

            MyGenClass<int> gen=new MyGenClass<int>();
            gen.Stampa();

            MyGenClassVincolata<A> myGenClassVincolata=new MyGenClassVincolata<A>();
            myGenClassVincolata.Stampa();


            MyClassA<int> a=new MyClassA<int>();
            Console.WriteLine(a.m(10));

            MyClassB b=new MyClassB();
            Console.WriteLine(b.m("Valeria !!!!"));

            MyStruct<double> ms;
            ms.a=3.14159;

            Console.WriteLine($"ms.a={ms.a} is {ms.a.GetType()}");

            //tipi Nullable in forma breve
            bool? myBool=null;
            Console.WriteLine(myBool);
            Console.WriteLine(myBool.HasValue);

            Nullable<bool> myBool2=true;
            Console.WriteLine(myBool2);
            Console.WriteLine(myBool2.HasValue);

            
            

        }

        //metodi generici
        public class Stampante
        {
            public T Stampa<T,S>(T n1,S n2, S n3)
            {
                Console.WriteLine($"n1={n1} n2={n2} n3={n3}");
                return n1;
            }
        }

        //Classe generica
        public class Lista<T>
        {
            private T[] lista;

            public Lista()
            {
                lista=new T[10];
            }

            public void Inserisci(T valore,int posizione)
            {
                if(posizione<10)
                {
                    lista[posizione]=valore;
                }
            }

            public T Valore(int posizione)
            {
                if(posizione<10)
                {
                    return lista[posizione];
                }else
                {
                    throw new Exception($"sei andato fuori indice posizione={posizione}!!!!");
                }
            }
        }

        //valori predefiniti
        public class A{
            public int Numero{get;set;}

            public A()
            {
                Numero=-1;
            }
        }

        //classe generica con default value
        public class MyGenClass<T>
        {
            private T? element;

            public MyGenClass()
            {
                element=default(T);
            }

            public void Stampa()
            {
                Console.WriteLine($"element={element}");
            }
        }

        //type constraint
        public class MyGenClassVincolata<T> where T:A,new()
        {
            private T? element;

            public MyGenClassVincolata()
            {
                element=new T();
            }

            public void Stampa()
            {
                if(element!=null)
                {
                    Console.WriteLine($"element.Numero={element.Numero}");
                }else{
                    Console.WriteLine("NULLLLLLL");
                }
            }
        }

        //interfaccia generica
        public interface IMyInterface<T>
        {
            T m(T x);
        }

        public class MyClassA<T>: IMyInterface<T>
        {
            public T m(T x)
            {
                return  x;
            }
        }

        public class MyClassB: IMyInterface<string>
        {
            public string m(string x)
            {
                return  x;
            }
        }

        //struct generica
        struct MyStruct<T> where T: struct
        {
            public T a;
        }

    }
}
