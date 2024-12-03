namespace Lesson3Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            bool p, q;

            Console.Write("Enter value \"p\" (true or false): ");
            while (!bool.TryParse(Console.ReadLine(), out p))
            {
                Console.WriteLine("The entered value isn't \"true\" or \"false\"");
                Console.Write("Enter value \"p\" (true or false): ");
            }

            Console.Write("Enter value \"q\" (true or false): ");
            while (!bool.TryParse(Console.ReadLine(), out q))
            {
                Console.WriteLine("The entered value isn't \"true\" or \"false\"");
                Console.Write("Enter value \"q\" (true or false): ");
            }

            Console.WriteLine("______________________________________________________________\n");
            Console.WriteLine("p        q        p & q        p | q        p ^ q        !p");
            Console.WriteLine("______________________________________________________________");
            Console.WriteLine($"{p}   {q}     {p && q}         {p || q}         {p ^ q}        {!p}");
            Console.WriteLine("______________________________________________________________");

        }
    }
}
