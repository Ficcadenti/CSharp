namespace ValoreRiferimento;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Valore e riferimento!");

        //tipi valore memorizzato nello stack
        int val=120;

        //tipi riferimento memorizzato nello heap il contenuto "Ciao" e nello stack il riferimento s,s1,arr
        string s="Ciao"; 
        string[] s1= new []{"primo","secondo"};
        int[] arr=new [] {10,20};

        //semantica tipi valore
        int a=100;
        int b=a;
        a=50;
        Console.WriteLine($"a={a}, b={b}");

        //semantica tipi riferimento
        int[] arr1=new []{5,10};
        int[] arr2=arr1;

        arr2[0]=100;

        foreach(int v in arr1)
        {
            Console.WriteLine($"{v}");
        }

        foreach(int v in arr2)
        {
            Console.WriteLine($"{v}");
        }



        
    }
}
