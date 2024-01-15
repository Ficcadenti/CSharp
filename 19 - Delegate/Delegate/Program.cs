namespace Delegate{

    public delegate bool ConfrontoDelegate(int x,int y);
    public delegate void MC_ConfrontoDelegate(int x,int y);

    public delegate bool ConfrontoDelegate<T>(T x,T y);

    public delegate void Action<T1,T2>(T1 arg1,T2 arg2);

    public delegate TRet Func<T1,T2, TRet>(T1 arg1,T2 arg2);

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("I Delegate !!!");
            
            Program p=new Program();
            //notazione complessa
            ConfrontoDelegate cd=new ConfrontoDelegate(p.MaggioreDi);
            //notazione compatta
            //ConfrontoDelegate cd=p.MaggioreDi;

            Console.WriteLine("MaggiorDi");
            Console.WriteLine(cd(10,4));
            Console.WriteLine(cd(10,40));

            cd=p.MinoreDi;
            Console.WriteLine("MinoreDi");
            Console.WriteLine(cd(10,4));
            Console.WriteLine(cd(10,40));


            //chiamata alternativa al delegate
            cd=p.UgualeA;
            Console.WriteLine("UgualeA");
            Console.WriteLine(cd.Invoke(10,10));
            Console.WriteLine(cd.Invoke(10,20));

            //delegate multicast
            MC_ConfrontoDelegate cd_mc=p.MC_MaggioreDi;
            cd_mc+=p.MC_MinoreDi;
            cd_mc+=p.MC_UgualeA;

            cd_mc(10,4);
            cd_mc(10,40);
            cd_mc(10,10);

            //delegate generics
            ConfrontoDelegate<int> cd1_g=p.MaggioreDi_G;
            ConfrontoDelegate<double> cd2_g=p.MaggioreDi_G;

            Console.WriteLine(cd1_g(10,4));
            Console.WriteLine(cd2_g(3.4d,2.3d));

            //delegate action
            Action<int,string> MyAction=p.MyFunc;
            MyAction(10,"Gabriele");

             //delegate function
            Func<int,string,String> Func=p.MyFuncRet;
            Console.WriteLine(Func(10,"Gabriele"));

        }

        //delegate
        public bool MaggioreDi(int x,int y)
        {
            Console.WriteLine($"x={x} > y={y} ?");
            return (x>y)?true:false;
        }

        public bool MinoreDi(int x,int y)
        {
            Console.WriteLine($"x={x} < y={y} ?");
            return (x<y)?true:false;
        }

        public bool UgualeA(int x,int y)
        {
            Console.WriteLine($"x={x} == y={y} ?");
            return (x==y)?true:false;
        }

        //delegate multicast
        public void MC_MaggioreDi(int x,int y)
        {
            bool b=(x>y)?true:false;
            Console.WriteLine($"x={x} > y={y} ? {b}");
        }

        public void MC_MinoreDi(int x,int y)
        {
            bool b=(x<y)?true:false;
            Console.WriteLine($"x={x} < y={y} ? {b}");
        }

        public void MC_UgualeA(int x,int y)
        {
            bool b=(x==y)?true:false;
            Console.WriteLine($"x={x} == y={y} ? {b}");
        }

        //delegate generics
        public bool MaggioreDi_G(int x,int y)
        {
            Console.WriteLine($"(int) x={x} > y={y} ?");
            return (x>y)?true:false;
        }

        public bool MaggioreDi_G(double x,double y)
        {
            Console.WriteLine($"(double) x={x} > y={y} ?");
            return (x>y)?true:false;
        }

        //delegate action
        void MyFunc(int x,string y)
        {
             Console.WriteLine($"Action => x={x};y={y}");
        }

        //delegate action
        string MyFuncRet(int x,string y)
        {
             return $"Func => x={x};y={y}";
        }

    }
}
