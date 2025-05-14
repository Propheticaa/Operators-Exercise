namespace OperatorExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            int a = 17;
            int b = 4;
            int sum = a + b;
            int difference = a - b;
            int product = a * b;
            int quotient = a / b;
            int remainder = a % b;
            
            Console.WriteLine($"The sum of {a} + {b} is {sum}.");
            Console.WriteLine($"The difference of {a} - {b} is {difference}.");
            Console.WriteLine($"The product of {a} * {b} is {product}.");
            Console.WriteLine($"{a}/{b} is {quotient} remainder {remainder}.");
            
            Console.WriteLine("What is the radius of the circle you would like to calculate the area for?");
            double radius = double.Parse(Console.ReadLine());
            Console.WriteLine(AreaOfCircle(radius));
        }

        public static double AreaOfCircle(double radius)
        {
            return Math.PI * radius * radius;
        }
    }
}
