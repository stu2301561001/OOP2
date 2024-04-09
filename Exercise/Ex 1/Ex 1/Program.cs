namespace Ex_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World 2!");
            // задача 1
            //      Console.WriteLine("Въведете цяло число N:");
            //      int N = int.Parse(Console.ReadLine());
            //      int sum = 0;
            //      for(int i = 1; i<= N; i++)
            //      {
            //          sum += i;
            //      }
            //      Console.WriteLine("Сумата на всички цели числа от 1 до {0} e: {1}" , N, sum);
            //Задача 2
            Console.WriteLine("Enter number");
            var number = int.Parse(Console.ReadLine());
            var isPrime = true;
            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    isPrime = false; break;
                

                if (isPrime)

                    Console.WriteLine("true");

                else

                    Console.WriteLine("false");
                }
            }


        }
    }
} 
