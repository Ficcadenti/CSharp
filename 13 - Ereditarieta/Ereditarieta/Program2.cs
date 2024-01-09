using System.Runtime.CompilerServices;

namespace EreditarietaCs{
    class ProgramCs
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ereditarietà e costruttori !!!");   
            BClass b=new BClass(10,20);
            Console.WriteLine(b);
        }
    }

    public class AClass
    {
        protected int aVar;

        public AClass(int aVar)
        {
            this.aVar=aVar;
        }
    }

    public class BClass: AClass
    {
        private int bVar;

        public BClass(int bVar,int aVar): base(aVar)
        {
            this.bVar=bVar;
        }

        public override string ToString()
        {
            return $"AClass : bVar={bVar} aVar={aVar}";
        }
    }
}
