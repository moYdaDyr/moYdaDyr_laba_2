namespace ConsoleApp1
{
    internal class Program
    {
        static void WriteError(string s)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(s);
            Console.ResetColor();
        }
        static void Main(string[] args)
        {
            int length, number, placeOfMax=1;
            int maxNumber = Int32.MinValue;
            string s;
            Console.WriteLine("Введите длину последовательности в виде положительного целого числа:");
            s=Console.ReadLine();
            while(!Int32.TryParse(s, out length) || length == 0)
            {
                WriteError("Ой! \"" + s+ "\" не похоже на положительное целое число. Пожалуйста, введите целое число:");
                s = Console.ReadLine();
            }
            Console.WriteLine("Введите через Enter последовательность из целых чисел:");
            for(int i = 0; i < length; i++)
            {
                s = Console.ReadLine();
                while (!Int32.TryParse(s, out number))
                {
                    WriteError("Ой! \""+s+"\" не похоже на целое число. Пожалуйста, введите целое число:");
                    s = Console.ReadLine();
                }
                if (maxNumber<number)
                {
                    maxNumber = number;
                    placeOfMax = i + 1;
                }
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Максимальный элемент в последовательности находится на позиции № "+ placeOfMax);
            Console.ResetColor();
        }
    }
}