using System.Text;
namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int A = int.Parse(Console.ReadLine());
            string[] input2 = Console.ReadLine().Split(' ');
            
            
            int C = int.Parse(input2[0]);
            int D = int.Parse(input2[0]);
            for (int i = 1; i < A; i++)
            {
                if ( C > int.Parse(input2[i]))
                {
                    C = int.Parse(input2[i]);  
                }
                if (D < int.Parse(input2[i]))
                {
                    D = int.Parse(input2[i]);
                }

            }
            Console.WriteLine($"{C} {D}");
            
        }
    }
}


