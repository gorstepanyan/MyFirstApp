namespace MyFirstApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Press Enter to start working");
            if (Console.ReadKey().Key == ConsoleKey.Enter)
                Console.WriteLine("Starting my console exersise...");
            else
                return;

            Console.Write("Pleace, type your Name: ");
            string s = Console.ReadLine();
            Console.WriteLine($"Your name is {s}");

            Console.Write("Press 1 to print 'Hello World' or 2 to print 'Hello People' : ");
            char r = (char)Console.Read();
            switch (r)
            {
                case '1':
                    Console.WriteLine("Hello World");
                    break;
                case '2':
                    Console.WriteLine("Hello People");
                    break;
                default:
                    Console.WriteLine("Bye!!!");
                    break;
            };
        }
    }
}