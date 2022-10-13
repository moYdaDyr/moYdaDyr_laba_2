namespace ConsoleApp3
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            double f = 0;
            for (int i = 33; i >= 1; i--)
            {
               // f += Math.Sqrt(i+3);
                f += i*3;
                f=Math.Sqrt(f);
            }
            Console.WriteLine("                       _________________________");
            Console.WriteLine("                      /    ___________________  │");
            Console.WriteLine("                     /    /    _____________  │");
            Console.WriteLine("                    /    /    /          __ │");
            Console.WriteLine("Значение выражения √3 + √6 + √9 + ... + √99      = " + f );
            Console.ResetColor();
        }
    }
}