using System;

namespace Classi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Le classi !!!");

            MyClass c=new MyClass();

            c.setS("Ciao");
            Console.WriteLine($"s={c.getS()}");
            MyClass.si=11;

            Console.WriteLine($"si={MyClass.si}");
            Console.WriteLine($"si={c.getSi()}");

            Persona p=new Persona("Gabriele","Ficcadenti");
            Persona p2=new Persona();
            Persona? p3=null;

            Console.WriteLine($"p={p3}");

            MyClass c2=new MyClass();
            c2.setI(-1);
            c2.MyMethod();
            Console.WriteLine($"c2.i={c2.getI()}");
        }
    }

    class Persona
    {
        private string? nome;
        private string? cognome;

        public Persona(string nome, string cognome)
        {
            if(nome.ToUpper().Equals("Raffaele"))
            {
                Console.WriteLine($"Ciao Rafo");
            }else
            {
  
                string s=$"Ciao {nome} !!!";
                Console.WriteLine(s);
            }

            //this
            this.nome=nome;
            this.cognome=cognome;
        }

        public Persona()
        {
            this.nome=null;
            this.cognome=null;
        }

        public Persona(string cognome):this("Mario",cognome){}
       
    }

    internal class MyClass
    {
        private string s;
        private int i;
        public static int si;

        public void MyMethod()
        {
            //Name hiding
            int i=100;
            Console.WriteLine($"i={i}");
        }
        public int getSi()
        {
            return si;
        }

        public void setS(string s)
        {
            this.s=s;
        }

        public string getS()
        {
            return this.s;
        }

        public void setI(int i)
        {
            this.i=i;
        }

        public int getI()
        {
            return this.i;
        }

    }
}
