namespace Esercitazione{

   

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("I Delegate !!!");
            int x=-12;
            Controlla(x);
            int[] arr=new int[9];
            for(int i=0;i<9;i++)
            {
                arr[i]=i;
            }

            invertiArry(arr);
            
            foreach(int i in arr)
            {
                Console.WriteLine(i);
            }

        }

        static void Controlla(int x)
        {
            if((x&0x1)==1)
                Console.WriteLine("Dispari");
            else
                Console.WriteLine("Pari");
        }

        static void invertiArry(int[] array) {
            for (int i = 0; i < array.Length / 2; i++) {
                (array[array.Length - i - 1], array[i]) = (array[i], array[array.Length - i - 1]);
            }
        }
    }
}
