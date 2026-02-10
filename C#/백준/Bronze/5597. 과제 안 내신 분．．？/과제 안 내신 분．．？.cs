using System.Text;
namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[28];
            for (int i = 0; i < 28; i++)
            {
                int A = int.Parse(Console.ReadLine());
                numbers[i] = A;
            }
            bool a = false;
            Array.Sort(numbers);
            for (int j = 0; j < 28; j++)
            {
                if (numbers[j] != (j+1)) 
                {
                    a = true;
                    Console.WriteLine(j+1);
                    for (int k = j; k < 28; k++)
                    {
                        if (numbers[k] != (k+2))
                        {
                            
                            Console.WriteLine(k+2);
                            return;
                        }
                        
                    }
                    Console.WriteLine(30);
                    return;
                }
            }
            if (!a)
            {
                Console.WriteLine(29);
                Console.WriteLine(30);
            }
        }
    }
}


