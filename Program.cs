namespace pr3krasikov
{
    internal class Program
    {
        static int a, b;
        static void Main(string[] args)
        {
            vvod();
            string operation = Console.ReadLine();
            switch (operation)
            {

                case "*":
                    Console.WriteLine($"{a * b}");
                    break;


            }
        }
        static void vvod()
        {
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            
        }
        
        
        
    }
}
