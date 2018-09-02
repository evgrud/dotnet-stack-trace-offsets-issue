using System;

namespace ILOffset
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Press enter to crash");
            Console.ReadKey();
            new Crasher().Crash();
        }
    }

    public class Crasher
    {
        private NullReturner NullReturner { get; } = new NullReturner();

        public void Crash()
        {
            Console.WriteLine("In Crash");
            int c = 0;
            for (int i = 0; i < 100; i++)
            {
                c += i;
            }
            for (int i = 0; i < 200; i++)
            {
                c += i;
            }
            for (int i = 0; i < 300; i++)
            {
                c += i;
            }
            Console.WriteLine(NullReturner.ReturnNull("nevermind").Length);
        }
    }    

    public class NullReturner
    {
        public string ReturnNull(string s)
        {
            return s.Length > 100 ? "vvv" : null;
        }
    }
}
