using System;

class DataTypes
{
    //data types:
    //byte 0-255
    //short 
    //int           uint
    //long          ulong
    //float
    //double
    //decimal
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

        uint salary1 = 464737394;// uint range 0 to 2* 2^32 -1
        Console.WriteLine("Type uint salary1: "+salary1);

        long latitude = 389339383939399999;// -2^64 to 2^64 - 1
        Console.WriteLine("Type Long Latitude: "+latitude);
    }
}

