using System;
public class Exercise4
{
    public static void Main()
    {
        int[] arr1 = new int[5] { 1, 2, 3, 4, 5 };
        int[] arr2 = new int[5];
        int i;

        for (i = 0; i < 5; i++)
        {
            arr2[i] = arr1[i];
        }

       
        Console.Write("\nThe elements stored in the first array are :\n");
        for (i = 0; i < 5; i++)
        {
            Console.Write("{0}  ", arr1[i]);
        }

        
        Console.Write("\n\nThe elements copied into the second array are :\n");
        for (i = 0; i < 5; i++)
        {
            Console.Write("{0}  ", arr2[i]);
        }
        Console.Write("\n\n");
    }
}