using System;
class Program
{
    static void Main()
    {
        int[] arr = new int[10] { 1, 1, 1, 2, 2, 4, 4, 6, 7, 8 };
        int i, j, count = 0;

       
        
        for (i = 0; i < 10; i++)
        {
            for (j = i + 1; j < 10; j++)
            {
               
                if (arr[i] == arr[j])
                {
                    count++;
                    break;
                }
            }
        }

        Console.WriteLine("\n Total number of duplicate elements found in array:" + count);
        Console.ReadLine();
    }

}