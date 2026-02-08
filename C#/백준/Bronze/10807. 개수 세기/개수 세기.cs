using System.Text;
namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int A = int.Parse(Console.ReadLine());
            string[] input = Console.ReadLine().Split(' ');
            int B = int.Parse(Console.ReadLine());
            for (int i = 0; i < A; i++)
            {
                int C = int.Parse(input[i]);
                if (C == B) 
                {
                    sum += 1;
                }
            }
            Console.WriteLine(sum);
            
        }
    }
}


