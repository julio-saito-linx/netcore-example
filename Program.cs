using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        List<String> arguments = new List<String>(args);
        var allNumeric = true;
        var numberList = new List<double>();
        arguments.ForEach(x => {
            int n;
            bool isNumeric = int.TryParse(x, out n);
            if (!isNumeric) {
                allNumeric = false;
                return;
            } else {
                numberList.Add(n);
            }
        });

        if (allNumeric) {
            var sum = numberList.Sum();
            numberList.Sort((x, y) => (int)x - (int)y);
        } else {
            arguments.Sort();
        }

        Console.WriteLine(arguments.Aggregate((i, j) => i + ", " + j));
    }
}
