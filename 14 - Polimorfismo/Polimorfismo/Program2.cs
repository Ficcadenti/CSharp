using System.ComponentModel;
using System.Dynamic;
using System.IO.Compression;

namespace Esercitazione;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Polimorfismo !!!");
        string s1="ciao";
        string s2="ciao";


        string st1=new string("1ciaone");
        string st2=new string("ciao");

        Console.WriteLine(s1==s2);

        Console.WriteLine(st1==st2);


        Console.WriteLine($"st2={st2} è contenuta in st1={st1} = {CustomContains(st1,st2)}");
    }

    static bool CustomContains(string s1, string s2)
    {
        // dò oer scontato che s2 sia contenuta in s1
        bool bRet=true;

        // controllo che s2 non sia più lunga di s1
        if(s2.Length>s1.Length)
            bRet=false;

        // comparo carattere per caratter
        int idx=s1.IndexOf(s2[0]);
        if(idx<=0)
            bRet=false;
        else{
            for(int i=0;i<s2.Length;i++)
            {
                if(s1[idx+i]!=s2[i])
                {
                    bRet=false;
                    break;
                }
            }
        }

        return bRet;

    }
}
