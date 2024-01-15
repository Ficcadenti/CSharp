namespace Modificatori{

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Modificatori ref, out, in !!!");
            int x=5;
            Console.WriteLine($"x={x}");
            MyFunc(x);
            Console.WriteLine($"x={x}");

            MyClass c=new MyClass();
            Console.WriteLine($"c.x={c.x}");
            MyMethod(c);
            Console.WriteLine($"c.x={c.x}");


        }

        static void MyFunc(int val)
        {
            val=10;
        }
        static void MyMethod(MyClass c)
        {
            c.x=20;
        }

        public class MyClass
        {
            public int x=5;
        }
    }
}
