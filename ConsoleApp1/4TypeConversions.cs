using System;
using System.Net.NetworkInformation;

class DataTypeConversions
{
    static void Main()
    {
        //Implicit conversion placing small type in large type
        byte n = 10;
        int n1 = n;
        Console.WriteLine($"Large container: {n1}");

        //Explicit conversion small type holding large type
        //errors might occur,data loss might occurs
        int employees = 256;
        byte employeesByte = (byte)employees;//suppose if 256 -> 0 or (number % 256)
        Console.WriteLine("Lower holder : " + employeesByte);


        double price = 87.877;
        int Iprice = (int)price;
        Console.WriteLine("(int)Iprice: " + Iprice);
        string stringValue = Iprice.ToString();
        Console.WriteLine("StringVlaue-- .ToString()------ used  : "+stringValue);

        string s6 = "89";
        int Ivalue = int.Parse(s6);

        Console.WriteLine("IVale int.Parse(\"89\")======"+Ivalue);
        //boxing & unboxing
        Console.WriteLine("Boxing & Unboxing: " +
            "\nprocess of converting value type to reference type(object)." +
            "\nUnboxing is reverse boxed value to original (through Explicit)possible.");
        int n11= 44;
        object obj = n11;//boxing
        Console.WriteLine("boxing obj :   " + obj + " " + obj.GetType());
        object obj1 = 333;
        int n22 = (int)obj1;
        Console.WriteLine("unboxing int :   " + n22 + " " + n22.GetType());


    }
}
