using System;
using System.Runtime.InteropServices;

[AttributeUsage(AttributeTargets.Struct |
AttributeTargets.Class | AttributeTargets.Interface,
AllowMultiple = true)]
public class VersionAttribute : System.Attribute
{
    public string Version { get; private set; }

    public VersionAttribute(string V)
    {
        this.Version = V; 
    }
}
[Version("2.11")]
[Version("3.11")]
[Version("4.11")]
[Version("5.11")]
class VersionTest
{
    static void Main(string[] args)
    {
        Type t = typeof(VersionTest);
        object[] allAtributes = t.GetCustomAttributes(false);
        foreach (VersionAttribute verAttribute in allAtributes)
        {
            Console.WriteLine("This class in version : " + verAttribute.Version);
        }
    }
}

