using System;

namespace HelloW
{
    /// <summary>
    ///     Application starting point.
    /// </summary>
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            SendToConsole("Hello Epa ... I mean, Hello World!!!");
        }
        /// <summary>
        ///     Takes <paramref name="message"/> and outputs it to console.
        /// </summary>
        public static void SendToConsole(String message)
        {
            Console.WriteLine(message);
        }
    }
}
