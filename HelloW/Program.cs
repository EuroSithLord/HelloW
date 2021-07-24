using System;

namespace HelloW
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            SendToConsole("Hello Epa ... I mean, Hello World!!!");
        }

        public static void SendToConsole(String message)
        {
            Console.WriteLine(message);
        }
    }
}
