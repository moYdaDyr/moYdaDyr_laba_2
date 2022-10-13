namespace ConsoleApp2
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
            int number=0, maxNumber = Int32.MinValue, minNumber = Int32.MaxValue;
            string s;
            bool flag = false;

            do
            {
                if (flag)
                {
                    WriteError("Ой! Была введена пустая последовательность");
                    flag = false;
                }

                Console.WriteLine("Введите не пустую последовательность из целых чисел, оканчивающуюся нулём:");

                do
                {

                    s = Console.ReadLine();
                    while (!Int32.TryParse(s, out number))
                    {
                        WriteError("Ой! \"" + s + "\" не похоже на целое число. Пожалуйста, введите целое число:");
                        s = Console.ReadLine();
                    }
                    if (number > maxNumber && number != 0)
                    {
                        maxNumber = number;
                    }
                    if (number < minNumber && number != 0)
                    {
                        minNumber = number;
                    }
                } while (number != 0);
                flag = true;
            } while (maxNumber == Int32.MinValue && minNumber == Int32.MaxValue) ;

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Разность между максимальным и минимальным числами в программе составляет "+(maxNumber-minNumber));
            Console.ResetColor();

        }
    }
}