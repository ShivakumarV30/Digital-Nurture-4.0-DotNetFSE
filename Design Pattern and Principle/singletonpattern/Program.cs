using System;

namespace SingletonPatternExample
{
    public class Logger
    {
        private static Logger? instance;  

        private Logger()
        {
            Console.WriteLine("Logger Instance Created");
        }

        public static Logger GetInstance()
        {
            if (instance == null)
            {
                instance = new Logger();
            }
            return instance;
        }

        public void Log(string message)
        {
            Console.WriteLine($"Log Entry: {message}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Logger logger1 = Logger.GetInstance();
            logger1.Log("This is the first log message.");

            Logger logger2 = Logger.GetInstance();
            logger2.Log("This is the second log message.");

            Console.WriteLine($"Are both logger instances the same? {ReferenceEquals(logger1, logger2)}");
        }
    }
}