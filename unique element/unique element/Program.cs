using System;
public class Exercise6
{
    public static void Main()
    {
        int ctr = 0;
        int[] arr1 = new int[5] { 1, 1, 2, 3, 4 };
        int i, j, k;
       
        for (i = 0; i < 5; i++)
        {
            ctr = 0;
           
            for (j = 0; j < i - 1; j++)
            {
               
                if (arr1[i] == arr1[j])
                {
                    ctr++;
                }
            }
           
            for (k = i + 1; k < 5; k++)
            {
               
                if (arr1[i] == arr1[k])
                {
                    ctr++;
                }
               
                if (arr1[i] == arr1[i + 1])
                {
                    i++;
                }
            }
           
            if (ctr == 0)
            {
                Console.Write("{0} ", arr1[i]);
            }
        }
        Console.Write("\n\n");
    }
}