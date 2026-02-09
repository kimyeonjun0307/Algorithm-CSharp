using System.Text;
namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            string[] input = Console.ReadLine().Split(' ');
            int A = int.Parse(input[0]);
            int B = int.Parse(input[1]);
            string[] input2 = Console.ReadLine().Split(' ');

            for (int i = 0; i < A; i++)
            {
                if (int.Parse(input2[i]) < B)
                {
                    sb.Append(input2[i]+' ');
                }
            }
            Console.WriteLine(sb);
            
        }
    }
}


