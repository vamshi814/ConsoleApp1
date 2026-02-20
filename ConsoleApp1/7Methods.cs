using System;
using System.Runtime.InteropServices;


//->>>Method is a reusable block of code to perform a specific task.
//Features: Reusability, Modularity, Readability
//File contains only one Main() method
//Methods only declared inside class 
//they can call from any methods inside the class

class Methods
{
    static void Main()
    {
        //Method1 is calling;
        //Method1();
        Method2();
        CallMethod1();
        Console.WriteLine("Method string: "+MethodString());
        int id = MethodInt();
        Console.WriteLine("Method Int : " + id);
        int a=10,b=20;
        Console.WriteLine(string.Format("Additon of {0} and {1} is : {2}",a,b,CallInt(a,b)));

    }
    //Non-return type methods:
    //Method1 Declaration
    static void Method1()
    {
        Console.WriteLine("Method1 is called !!! ");
    }

    //Method2 Declaration
    static void Method2()
    {
        Console.WriteLine("Method2 is called !!! ");
    }

    static void CallMethod1()
    {
        //Inside CallMethod() we are calling Method1()
        Method1();
    }
    //Return Type methods
    static string MethodString()
    {
        return "John";
    }

    static int MethodInt() {
        return 99;
    }
    //Methods with Params
    static int CallInt(int a, int b) { 
        return a + b;
    }
}