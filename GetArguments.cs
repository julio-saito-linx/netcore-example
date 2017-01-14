using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
public class Tools
{
    public static IEnumerable<string> GetArguments(string[] args)
    {
        List<String> arguments = new List<String>(args);
        
        // check if all items are numeric
        // add here
        var allNumeric = true;
        var numberList = new List<double>();
        
        arguments.ForEach(x => {
            double n;
            bool isNumeric = double.TryParse(
                x,
                NumberStyles.Integer | NumberStyles.AllowDecimalPoint,
                new CultureInfo("en-US"), 
                out n);

            if (!isNumeric) {
                allNumeric = false;
                return;
            } else {
                numberList.Add(n);
            }
        });

        if (allNumeric) {
            numberList.Sort();
            return numberList.Select(x => x.ToString()).ToList();
        } else {
            arguments.Sort();
            return arguments;
        }
    }
}
