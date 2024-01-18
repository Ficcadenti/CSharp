namespace Lambda
{

    class Program
    {
        private static string? nome;

        static string Nome{
            get => nome.ToUpper();
            set => nome=value;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Lambda expression !!!");

            Func<string> saluto = () => "Ciao";
            Func<string,string> saluto2 = (string nome) => $"Ciao {nome}";
            Func<string,string> saluto3 = nome => $"Ciao {nome}";
            Console.WriteLine(saluto());
            Console.WriteLine(saluto2("Gabriele"));
            Console.WriteLine(saluto3("Sofia"));

            Action saluto4 = () => Console.WriteLine("Ciao");
            Action<string> saluto5 = nome => Console.WriteLine($"Ciao {nome}");
            
            saluto4();
            saluto5("Maria");

            Action<int, int> somma=(x,y)=> {
                int z=x+y;
                Console.WriteLine($"{x} + {y} = {z}");
            };
            somma(10,20);

            Nome="Valeria";
            Console.WriteLine(Nome);

            MyClass c=new MyClass("Famiglia");
            Console.WriteLine(c.Nome);


        }

        public class MyClass
        {
            private string? nome;

            public string Nome{
                get => this.nome.ToUpper();
                set => this.nome=value;
            }

            public MyClass(string valore) => this.nome=valore;
        }

    }
}
