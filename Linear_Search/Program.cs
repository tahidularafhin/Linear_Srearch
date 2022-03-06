using System;

namespace Linear_Search
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr ={ 10, 1, 12, 15, 19, 27 };

            Console.WriteLine("Enter your searching Number");
            int number = Convert.ToInt32(Console.ReadLine());

            int found = 0;

            for (int i = 0; i <arr.Length; i++)
            {
                if (arr[i] == number)
                {
                    Console.WriteLine("Number is found and location is {0}", i);
                    found++;
                    break;
                } 
                
            }

            if (found == 0)
            {
                Console.WriteLine("Number is not found");
            }

            Console.ReadLine();


        }
    }
}
