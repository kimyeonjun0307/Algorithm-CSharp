namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            string input = "";
            for (int i = N; i > 0; i -= 4)
            {
                input = input + "long ";
            }
            Console.WriteLine(input + "int");
        }
    }
}
