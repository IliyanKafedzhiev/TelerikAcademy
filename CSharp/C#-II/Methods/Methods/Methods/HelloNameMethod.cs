//Write a method that asks the user for his name and prints “Hello, <name>” (for example, “Hello, Peter!”). Write a program to test this method.


using System;

class HelloNameMethod
{
    static void PrintName(string name)
    {
        Console.WriteLine("Hello "+name+" !");
    }
    static void Main(string[] args)
    {
        string name = Console.ReadLine();
        PrintName(name);
    }
}

