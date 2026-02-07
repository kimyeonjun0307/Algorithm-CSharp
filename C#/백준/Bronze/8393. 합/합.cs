namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int A = int.Parse(Console.ReadLine());
            int B = 0;
            for (int i= A ; i > 0; i--) 
            {                
                B = B + i;
            }
            Console.WriteLine(B);
        }
    }
}
