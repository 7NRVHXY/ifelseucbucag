namespace ifelseucbucag
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int side1 = 5;
            int side2 = 8;
            int side3 = 13;
            if (side1 + side2 >side3 && side1+side3 >side2 && side2+side3 >side1) 
            {
                Console.WriteLine("duzgun ucbucagdir");
            }
            else
            {
                Console.WriteLine("duzgun ucbucag deyil");
            }
        }
    }
}