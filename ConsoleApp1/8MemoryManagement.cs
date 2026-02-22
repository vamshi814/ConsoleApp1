using System;


//Memory management in C# is fundamentally different from languages like C or C++.
//It is largely automatic, managed by the .NET runtime,
//specifically the Common Language Runtime (CLR) and its Garbage Collector (GC).

//Stack:------------structs in stack, func in stack frames
//Stores value types
//Stores references to heap objects
//Stores method call in stack frames
//Very fast
//Automatically managed (LIFO structure)

//Managed Heap:------------------
//Stores objects (reference types)
//Managed by the Garbage Collector
//Slower than stack
//Automatically cleaned
class MemoryManagement
    {
    static void Main()
    {
        int x = 1;               //stack
        double y = 2.000D;      //stack
        Something();            //stack - stack frame

    }
    static void Something()
    {
        int x = 2;              //stack only but in inside stack frame of Something()
        byte y = 0;
        DoAnotherWork();    //creates another stack frame for functions
        return;             //once returned this stack frame is deleted
    }
    static void DoAnotherWork()
    {
        int x = 3;
        return;      // once returned this stack frame is deleted
    }

    var person = new Person(); // person in stack (pointer)
                    // new Keyword means in heap

    }

class Person
{
    string text;       // text reference in heap area inside Person object  
    int x = 4;          //inside person object
    public Person() {
        text = "hi c#";
    }
}