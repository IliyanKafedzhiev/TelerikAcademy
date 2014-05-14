using System;
class Exersize
{
    public struct Company
    {
        public string name;
        public string address;
        public string phoneNumber;
        public string faxNumber;
        public string webSite;
        public Manager man; 
    }
    public struct Manager
    {
        public string firstName;
        public string lastName;
        public byte age;
        public string phoneNumber;
    }
    static void Main()
    {
        Company ExampleComany=new Company();
        Console.WriteLine("Input the name of Company");
        ExampleComany.name = Console.ReadLine();
        Console.WriteLine("Input the address of Company");
        ExampleComany.address = Console.ReadLine();
        Console.WriteLine("Input the phone number of Company");
        ExampleComany.phoneNumber = Console.ReadLine();
        Console.WriteLine("Input the fax number of Company");
        ExampleComany.faxNumber = Console.ReadLine();
        Console.WriteLine("Input the web site of Company");
        ExampleComany.webSite = Console.ReadLine();
        Console.WriteLine("Input the first name of the Manager");
        ExampleComany.man.firstName = Console.ReadLine();
        Console.WriteLine("Input the  last name of the Manager");
        ExampleComany.man.lastName = Console.ReadLine();
        Console.WriteLine("Input the age of the Manager");
        ExampleComany.man.age = byte.Parse(Console.ReadLine());
        Console.WriteLine("Input the phone number of the Manager");
        ExampleComany.man.phoneNumber = Console.ReadLine();
        Console.WriteLine("The name of company is {0} \nThe addres of company is {1} \nThe phone number of company is{2}\nThe fax number of company is{3}\nThe website of the company is {4}\n"
            ,ExampleComany.name,ExampleComany.address,ExampleComany.phoneNumber,ExampleComany.faxNumber,ExampleComany.webSite);
        Console.WriteLine("The first name of manager is{0}\nThe last name of manager is {1}\nThe Manager is {2} years old \nThe phone number of the manager is{3}"
            ,ExampleComany.man.firstName,ExampleComany.man.lastName,ExampleComany.man.age,ExampleComany.man.phoneNumber);

        
    }
}
