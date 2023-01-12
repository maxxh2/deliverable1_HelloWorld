namespace deliverable1_HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("Solution (1):Hello, World!");

            string stg = "Solution (2): Hello, World! (2)";
            Console.WriteLine("Solution (2):" + stg);
            Console.WriteLine(" ");

            Console.WriteLine("Enter a Username");
            string userName = Console.ReadLine();
            Console.WriteLine("The user's name is: " + userName);
            Console.WriteLine(" ");

            Console.WriteLine("Enter the user's age: " );
            int age =int.Parse(Console.ReadLine());
            Console.WriteLine("The user's age is: " + age);



        }
    }
}