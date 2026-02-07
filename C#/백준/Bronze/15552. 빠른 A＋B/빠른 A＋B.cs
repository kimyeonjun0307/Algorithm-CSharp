using System.Text;
namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int A = int.Parse(Console.ReadLine());
            StringBuilder sb = new StringBuilder();
            
            for (int i = A; i > 0; i--)
            {
                string[] input = Console.ReadLine().Split(' ');
                int B = int.Parse(input[0]);
                int C = int.Parse(input[1]);
                sb.AppendLine((B + C).ToString());
            }

            Console.Write(sb);
        }
    }
}



