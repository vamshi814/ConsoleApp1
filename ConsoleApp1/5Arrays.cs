using System;

class Arrays
{
    static void Main()
    {
        //Arrays. : container which holds collection of values of same datatype


        Console.WriteLine("Arrays::");
        int[] array1 = new int[] { 1, 2, 3 };
        string[] array2 = { "maths", "ps", "cs" };
        Console.WriteLine($"0th index of array1:{array1[0]}");
        Console.WriteLine($"Array1 : {array1}");
        int j = 1;
        foreach (int val in array1)
        {            
            Console.WriteLine($"Value of {j++} is : {val}");
        }
        for(int i = 0; i < array2.Length; i++)
        {
            Console.WriteLine(i + " " + array2[i]);
        }
    }
}
