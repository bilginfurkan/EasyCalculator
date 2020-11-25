using NCalc;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Calculator
{
    public static (bool, double) Calculate(string expression)
    {
        if (string.IsNullOrEmpty(expression))
            return (false, 0);
 
        try
        {
            var ex = new Expression(expression);

            if (ex.HasErrors())
            {
                return (false, 0);
            }
            else
            {
                var result = ex.Evaluate();
                return (true, Convert.ToDouble(result));
            }
        }
        catch
        {
            return (false, 0);
        }
    }
}