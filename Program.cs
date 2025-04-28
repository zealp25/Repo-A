using System;
using SharedLibrary;

namespace ProjectA
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Project A says: " + MyLibraryClass.GetMessage());
        }
    }
}
