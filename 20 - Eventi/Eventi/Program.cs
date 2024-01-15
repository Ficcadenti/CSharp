using System;

namespace Eventi{

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Gli Eventi !!!");

            //emettitore di messaggi
            Emitter e=new Emitter();

            //ascoltatori dei messaggi emessi dall'emitter
            Listener l1=new Listener();
            Listener l2=new Listener();

            e.NewMessage +=l1.MessageHandler;
            e.NewMessage +=l2.MessageHandler;

            e.Message="Primo messaggio !!!";
            e.Message="Secondo messaggio !!!";
        }
    }

    public class Emitter
    {
        private string? message;

        public string Message { 
            get{return message;} 
            set{message=value; OnNewMessage(message);} 
        }

        public event Action<string>? NewMessage;

        public void OnNewMessage(string msg)
        {
            if(NewMessage!=null)
            {
                NewMessage(msg);
            }
        }
    }

    public class Listener
    {
        public void MessageHandler(string msg)
        {
            Console.WriteLine($"Ho ricevuto il messaggio {msg} !!!");
        }
    }
}
