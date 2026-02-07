using System.Text;
namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;
            StringBuilder sb = new StringBuilder();
            while(( input = Console.ReadLine()) != null)
                {
                string[] sum = input.Split(' ');
                int a = int.Parse(sum[0]);
                int b = int.Parse(sum[1]);
                sb.AppendLine((a + b).ToString());
                }
            
            Console.Write(sb);
            
        }
    }
}


