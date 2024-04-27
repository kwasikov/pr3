namespace pr3krasikov
{
    internal class Program
    {
        static int a, b;
        static void Main(string[] args)
        {
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            
            string operation = Console.ReadLine();
            switch (operation)
            {
                case "+":
                    Console.WriteLine($"Ответ: {a + b}");
                    break;

                case "-":
                    Console.WriteLine($"Ответ: {a - b}");
                    break;

                case "*":
                    Console.WriteLine($"Ответ: {a * b}");
                    break;

                case "/":
                    Console.WriteLine($"Ответ: {a / b}");
                    break;
            }
        }
        
        
        
        
        
    }
}
