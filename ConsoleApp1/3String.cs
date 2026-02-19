using System;
using System.Security.Cryptography;


class String
{
    static void Main()
    {
        /*
         * String is one kind of class in C#
         * Contains members like
         * Property:describes about characteristcs (name ,id, ..)
         * Method: nothing but actions performed(cooking, driving, earning ..)
         * 
         * */
        string s = "this is a string";
        var textLength = s.Length;
        Console.WriteLine($"Text Length is: {textLength}");

        string upperS = s.ToUpper();
        Console.WriteLine($"Upper Text is: {upperS}");

        string s1 = "      trimmmmm     ";
        Console.WriteLine(s1.Trim());
        string s2 = "*********trtrrrtrtrtr************";
        Console.WriteLine("Removed stars from starting and ending: " + s2.Trim('*'));
        string s3 = "demon";
        Console.WriteLine(s3 +" pad left " + s3.PadLeft(10,'~')+"\n-------------------------------");


        //string comparison

        string password = "Hello123";
        bool isEqual = password.Equals("HelloWorld");
        Console.WriteLine("bool value is: " + isEqual);

        string s5 = "the quick brown fox jumps over a lazy dog";
        string substring5 = s5.Substring(4);
        Console.WriteLine("substring from 4: " + substring5);
        string substring54 = s5.Substring(4, 5);
        Console.WriteLine("Substring from 4 to length 5: " + substring54);
        string stringReplaced = s5.Replace("brown", "black");
        Console.WriteLine("String Replaced: " + stringReplaced);
        Console.WriteLine("String format----------------------");
        int quantity = 5;
        double price = 1800.75;
        string rcpt = string.Format("You ordered {0} items for total price {1}", quantity, price);
        Console.WriteLine(rcpt);

    }

}

