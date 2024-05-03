namespace MethodOverloadingDemoCSharp_47
{
    internal class Program
    {
        static void Main(string[] args)
        {           

            var addedInts = Add(2, 2);
            Console.WriteLine(addedInts);

            var addedDoubles = Add(3.0, 3.0);

            Greet("Seth");
            Greet("Mack", "McCall", 24);
        }

        public static int Add(int numOne, int numTwo)
        {
            return numOne + numTwo;
        }

        public static double Add(double numOne, double numTwo)
        {
            return numOne + numTwo;
        }

        public static decimal Add(decimal numOne, decimal numTwo)
        {
            return numOne + numTwo;
        }

        public static void Greet(string firstName)
        {
            Console.WriteLine($"Hello, {firstName}!");
        }

        public static void Greet(string firstName, string lastName)
        {
            Console.WriteLine($"Hello, {firstName} {lastName}!");
        }

        public static void Greet(string firstName, string lastName, int age)
        {
            Console.WriteLine($"Hey {firstName} {lastName} {age}");
        }
    }
}
