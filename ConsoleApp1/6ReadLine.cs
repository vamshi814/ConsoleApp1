using System;

class ReadLine
{
    static void Main()
    {
        Console.WriteLine("Enter your name : ");
        string name = Console.ReadLine();
        Console.WriteLine("Enter ID: ");
        int Id = int.Parse(Console.ReadLine());

        Console.WriteLine("Name is : " + name + " Id is : " + Id);
        Console.WriteLine(string.Format("\nHI {0} Confirm your ID {1}", name, Id));
        
    }
}
