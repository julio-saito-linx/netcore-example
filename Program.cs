using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        var arguments = (List<string>)Tools.GetArguments(args);
        Console.WriteLine(arguments.Aggregate((i, j) => i + "\n" + j));
    }
}
