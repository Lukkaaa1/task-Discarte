namespace Prefect_number
{
    class Prefect {
        static void Main()
        {
            int num1, num2;
            Console.Write("\n\n");
            Console.Write("Find perfect numbers within a given number of range:\n");
            Console.Write("------------------------------------------------------");
            Console.Write("\n\n");
            
            Console.WriteLine("Enter num1: ");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter num2: ");
            num2 = int.Parse(Console.ReadLine());
            Console.WriteLine($"\nPrfect numbers between {num1} and {num2} are: ");
            
            for(int n=num1;n<=num2;n++)
            {
               int i=1;
               int  sum = 0;
                while(i<n)
                {
                    if(n%i==0)
                        sum=sum+i;
                    i++;
                }
                if(sum==n)
                    Console.Write("{0} ",n);
            }
            Console.Write("\n");
        }  
   
    }
}