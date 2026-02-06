namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            int A = int.Parse(input[0]);
            int B = int.Parse(input[1]);

            B -= 45;
            if (B < 0)
            {
                B += 60;
                A = (A == 0) ? 23 : A - 1;
            }
            Console.WriteLine($"{A} {B}");

        }
    }
}