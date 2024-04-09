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
            //          Console.WriteLine("Enter number");
            //           var number = int.Parse(Console.ReadLine());
            //           var isPrime = true;
            //          for (int i = 2; i <= Math.Sqrt(number); i++)
            //          {
            //              if (number % i == 0)
            //              {
            //                  isPrime = false;
            //                  break;
            //               }
            //
            //               if (isPrime)
            //
            //                   Console.WriteLine("true");

            //                else

            //                   Console.WriteLine("false");

            //           }

            //Здадача 3
            //       Console.WriteLine("Enter array");
            //       string[] input = Console.ReadLine().Split(",");
            //        decimal result = 0;
            //        for(int i = 0; i < input.Length; i++)
            //        {
            //            result += Decimal.Parse(input[i]);
            //        }
            //         Console.WriteLine( "The sum is " + result);
            //Задача 4 
            Console.WriteLine("enter euro array");
            var euroInput = Console.ReadLine().Split(",");

            Console.WriteLine("enter usd array");
            var usdInput = Console.ReadLine().Split(",");

            var euroToLv = new decimal[euroInput.Length];
            var usdToLv = new decimal[usdInput.Length];
             for(int i = 0; i < euroInput.Length; i++)
            {
                euroToLv[i]= Decimal.Parse(euroInput[i]) * 1.95m;
            }
             for(int i = 0; i < usdInput.Length; i++)
            {
                usdToLv[i] = Decimal.Parse(usdInput[i]) * 1.8m;
            }
            var areEqual = true;
            if(euroToLv.Length == usdToLv.Length)
            {
                for (int i = 0;i < euroToLv.Length; i++)
                {
                    if (euroToLv[i] != usdToLv[i])
                    {
                        areEqual = false;
                        break;
                    }
                
                else
                    
                areEqual=false;
                }
                Console.WriteLine( "Equal: " + areEqual);
            }
        }
    }
} 
