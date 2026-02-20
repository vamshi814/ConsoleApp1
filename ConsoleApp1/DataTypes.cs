using System;

class DataTypes
{
    //data types:
    //byte 0-255
    //short 
    //int           uint means only positive starts with 0
    //long          ulong
    //folating numbers: float, double , decimal
    static void Main()
    {
        byte age = 25; //byte ranges from 0-255
        Console.WriteLine(age);

        short Assembly_constituencies = 175;//short -32,768 to 32,767
        short Loksaba_constituencies = 25;

        Console.WriteLine("Total Assembly constituencies in AP: "+Assembly_constituencies);
        Console.WriteLine("Total Loksaba Constituencies in AP: " + Loksaba_constituencies);

        ushort totalPopulation = 65535; //ushort range 0-65536
        Console.WriteLine(totalPopulation);

        int salary = 250000000; //int range -2^31 to 2^32 - 1   ..  32 bits or 4bytes
        Console.WriteLine("Type uint salary1: "+salary);

        uint salary1 = 464737394U;// uint range 0 to 2* 2^32 -1
        Console.WriteLine("Type uint salary1: "+salary1);

        long latitude = 389339383939399999L;// -2^64 to 2^64 - 1
        Console.WriteLine("Type Long Latitude: "+latitude);

        ulong worldPopulation = 46433889999999UL; // u unsigned l means long
        Console.WriteLine("Total World Population: "+worldPopulation);


        //string interpolation $" ........."
        //byte.MaxValue, MaxValue is a property in byte
        Console.WriteLine($"-----------------------------------------");
        Console.WriteLine($"Byte Max value is: {byte.MaxValue} and Min Value is: {byte.MinValue}");
        Console.WriteLine($"short Max value is: {short.MaxValue} and Min Value is: {short.MinValue}");
        Console.WriteLine($"ushort Max value is: {ushort.MaxValue} and Min Value is: {ushort.MinValue}");
        Console.WriteLine($"int Max value is: {int.MaxValue} and Min Value is: {int.MinValue}");
        Console.WriteLine($"uint Max value is: {uint.MaxValue} and Min Value is: {uint.MinValue}");
        Console.WriteLine($"long Max value is: {long.MaxValue} and Min Value is: {long.MinValue}");
        Console.WriteLine($"ulong Max value is: {ulong.MaxValue} and Min Value is: {ulong.MinValue}");
        Console.WriteLine($"float Max value is: {float.MaxValue} and Min Value is: {float.MinValue}");
        Console.WriteLine($"double Max value is: {double.MaxValue} and Min Value is: {double.MinValue}");
        Console.WriteLine($"decimal Max value is: {decimal.MaxValue} and Min Value is: {decimal.MinValue}");
        Console.WriteLine($"-----------------------------------------------");

        //var and dynamic used for implicit declaration
        var id = 44;
        Console.WriteLine($"id is {id} and type is {id.GetType()}");
        //id = "hlo"; cause error
        dynamic dNumber;//it works even if u dont initialize but cause error while accessing
        dNumber = 155;
        Console.WriteLine($"dNumber is {dNumber} and type is {dNumber.GetType()}");
        dNumber = false;
        Console.WriteLine($"dNumber is {dNumber} and type is {dNumber.GetType()}");

        Console.WriteLine($"-----------------------------------------");
    }
}

