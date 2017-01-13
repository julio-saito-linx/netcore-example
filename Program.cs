using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        List<String> arguments = new List<String>(args);
        // Map = Select | Enumerable.Range(1, 10).Select(x => x + 2);
        // Reduce = Aggregate | Enumerable.Range(1, 10).Aggregate(0, (acc, x) => acc + x);
        // Filter = Where | Enumerable.Range(1, 10).Where(x => x % 2 == 0);

        // Console.WriteLine("your args" + arguments.Join());

        Console.WriteLine(arguments.Aggregate((i, j) => i + ", " + j));        
    }
}
