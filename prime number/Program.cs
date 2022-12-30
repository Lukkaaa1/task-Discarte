
namespace prime_number 
{
    class Prime
    {
        static void Main(string[] args) // this function defines the entry point
        {
            int num1, num2;
            bool Prime = true;
            Console.WriteLine("Enter num1: ");
             num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter num2: ");
            num2 = int.Parse(Console.ReadLine());
            Console.WriteLine($"\nPrime numbers between {num1} and {num2} are: ");
            
            for (int a = num1; a <= num2; a++) //upper limit and lower limit are defined
            {
                for (int b = 2; b <= 100; b++)// base logic for the primality
                {
                    if (a != b && a % b == 0) //modulo operators employed
                    {
                        Prime = false;
                        break;
                    }
                }
                if (Prime)
                {
                    Console.Write("\t" + a); 
                }
                Prime = true;
            }
            Console.ReadKey(); 
        }
    }
}