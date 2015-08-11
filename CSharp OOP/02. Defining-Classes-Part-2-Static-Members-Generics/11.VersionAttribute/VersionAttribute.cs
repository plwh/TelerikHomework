// Problem 11: Create a [Version] attribute that can be applied to structures, classes, interfaces, enumerations and methods and holds a version in the format major.minor
// (e.g. 2.11). Apply the version attribute to a sample class and display its version at runtime.

using System;

namespace _11.VersionAttribute
{
    [AttributeUsage(AttributeTargets.Struct |  
                    AttributeTargets.Class | 
                    AttributeTargets.Interface|
                    AttributeTargets.Method, AllowMultiple = false)
    ]
    public class VersionAttribute : System.Attribute
    {
        public string Version { get; private set; }
        public VersionAttribute(string version)
        {
            this.Version = version;
        }
    }

    [Version("1.14")]
    class VersionAttributeDemo
    {
        static void Main()
        {
            Type type = typeof(VersionAttributeDemo);
            object[] allAttributes = type.GetCustomAttributes(false);
            foreach (VersionAttribute ver in allAttributes)
            {
                Console.WriteLine("This class has version: {0}.", ver.Version);
            }            
        }
    }
}
