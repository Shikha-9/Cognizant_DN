using System;

namespace SingletonPatternDemo
{
    // Singleton class
    public class Singleton
    {
        private static Singleton _instance;
        private static readonly object _lock = new object();

        // Private constructor ensures no outside instantiation
        private Singleton() { }

        public static Singleton GetInstance()
        {
            if (_instance == null)
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new Singleton();
                    }
                }
            }
            return _instance;
        }

        public void ShowMessage()
        {
            Console.WriteLine("Hello from Singleton Pattern!");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Singleton obj1 = Singleton.GetInstance();
            Singleton obj2 = Singleton.GetInstance();

            obj1.ShowMessage();

            // Check if both references point to the same object
            Console.WriteLine($"Are both instances same? {obj1 == obj2}");
            Console.ReadLine(); // Keeps console open
        }
    }
}
