namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int A = int.Parse(Console.ReadLine());
            for (int i = 0; A > i; i++)
            {
                for (int j = 0; i >= j; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}