using System.Text;
namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            string[] firstline = Console.ReadLine().Split(' ');
            int basket = int.Parse(firstline[0]);
            int receive = int.Parse(firstline[1]);
            int[] basketchange = new int[basket];
            for (int k = 0; k < basket; k++)
            {
                basketchange[k] = k + 1;
            }

            for (int i = 0; i < receive; i++)
            {
                string[] numberchange = Console.ReadLine().Split(' ');
                int A = (int.Parse(numberchange[0]) - 1);
                int B = (int.Parse(numberchange[1]) - 1);

                int temp = basketchange[A];
                basketchange[A] = basketchange[B];
                basketchange[B] = temp;
            }
            for (int j = 0; j < basket; j++)
            {
                sb.Append(basketchange[j]);
                if (j < basket - 1)
                {
                    sb.Append(' ');
                }
            }
            Console.WriteLine(sb);

        }
    }
}


