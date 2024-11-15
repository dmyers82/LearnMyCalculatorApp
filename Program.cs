namespace LearnMyCalculatorApp
{

    internal class Program
    {
        static void Main(string[] args)
        {
            var calc = new Calculator();
            Console.WriteLine("Add: " + calc.Add(1, 1));
            Console.WriteLine("Subtract: " + calc.Subtract(100, 10));
            Console.WriteLine("Multiply: " + calc.Multiply(5, 5));
            Console.WriteLine("Divide: " + calc.Divide(400, 20));
            Console.ReadLine();
        }
    }
}
