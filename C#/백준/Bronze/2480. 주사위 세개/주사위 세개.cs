namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            int A = int.Parse(input[0]);
            int B = int.Parse(input[1]);
            int C = int.Parse(input[2]);

            if (A == B && B == C)
            {
                Console.WriteLine(10000 + (A * 1000));
            }
            else if (A == B || B == C || C == A)
            {
                if (A == B)
                {
                    Console.WriteLine(1000 + (A * 100));
                }
                else
                {
                    int D = (B == C) ? D= B :D= C;
                    Console.WriteLine(1000 + (D * 100));
                }
            }
            else
            {
                if (A == 6 || B == 6 || C == 6)
                {
                    Console.WriteLine(600);
                }
                else if (A == 5 || B == 5 || C == 5)
                {
                    Console.WriteLine(500);
                }
                else if (A == 4 || B == 4 || C == 4)
                {
                    Console.WriteLine(400);
                }
                else if (A == 3 || B == 3 || C == 3)
                {
                    Console.WriteLine(300);
                }
                else if (A == 2 || B == 2 || C == 2)
                {
                    Console.WriteLine(200);
                }
                else 
                {
                    Console.WriteLine(100);
                }
            }
        }
    }
}
