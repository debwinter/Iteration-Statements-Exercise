namespace IterationStatements
{
    public class Program
    {
        //LukeWarm Section: Create methods below
        //Write a method that will print to the console all numbers 1000 through - 1000
        public static void Thousand()
        {
            for (int t = 1000; t >= -1000; t--)
            {
                Console.WriteLine(t);
            }
        }

        //Write a method that will print to the console numbers 3 through 999 by 3 each time
        public static void ByThree()
        {
            for (int t = 3; t < 1000; t+=3)
            {
                Console.WriteLine(t);
            }
        }

        //Write a method to accept two integers as parameterss and check whether they are equal or not
        public static bool AreEqual(int x, int y)
        {
            return x == y;
        }

        //Write a method to check whether a given number is even or odd
        public static bool IsEven(int x)
        {
            return x % 2 == 0;
        }

        public static string EvenOrOdd(int x)
        {
            return (x % 2 == 0) ? "Even" : "Odd";
        }

        //Write a method to check whether a given number is positive or negative
        public static bool IsPositive(int x)
        {
            return x > 0;
        }

        public static string PositiveOrNegative(int x)
        {
            return (x > 0) ? "Positive" : (x < 0) ? "Negative" : "0";
        }

        //Write a method to read the age of a candidate and determine whether they can vote.
        //Hint: Use Parse or the safer TryParse() for an extra challenge
        //Parse()
        //TryParse()
        public static string VotingAge()
        {
            Console.WriteLine("How old are you?");
            var userAge = Console.ReadLine();
            int.TryParse(userAge, out int age);
            
            return (age < 18) ? "Too young to vote!"
                : (age >= 18) ? "Pokemon-GO to the polls!"
                : "Politics is broken and so is this formula";
        }

        //Heatin Up Section:
        //Write a method to check if an integer(from the user) is in the range -10 to 10
        public static bool CheckRange()
        {
            Console.Write("Enter a whole number: ");
            var userInput = Console.ReadLine();
            int.TryParse(userInput, out int number);

            return number >= -10 && number <= 10;
        }

        //Write a method to display the multiplication table(from 1 to 12) of a given integer
        public static string MultTable(int x)
        {
            return $"{x} x 1 = {x}\n" +
                $"{x} x 2 = {x*2}\n" +
                $"{x} x 3 = {x*3}\n" +
                $"{x} x 4 = {x*4}\n" +
                $"{x} x 5 = {x*5}\n" +
                $"{x} x 6 = {x*6}\n" +
                $"{x} x 7 = {x*7}\n" +
                $"{x} x 8 = {x*8}\n" +
                $"{x} x 9 = {x*9}\n" +
                $"{x} x 10 = {x*10}\n" +
                $"{x} x 11 = {x*11}\n" +
                $"{x} x 12 = {x*12}\n";
        }

        //Call the methods to test them in the Main method below
        static void Main(string[] args)
        {
            Thousand();
            ByThree();

            int a = 7;
            int b = -7;

            Console.WriteLine($"Are {a} and {b} equal? " + (AreEqual(a,b) ? "Yes" : "No"));

            Console.WriteLine($"Is {a} even? " + (IsEven(a) ? "Yes" : "No"));
            Console.WriteLine($"Is {a} even or odd? " + EvenOrOdd(a));

            Console.WriteLine($"Is {b} positive? " + (IsPositive(b) ? "Yes" : "No"));
            Console.WriteLine($"Is {b} positive or negative? " + PositiveOrNegative(b));

            Console.WriteLine(VotingAge());

            bool inRange = CheckRange();
            Console.WriteLine("Is it in range? " + (inRange?"Yes":"No"));

            Console.WriteLine(MultTable(a));
        }
    }
}
