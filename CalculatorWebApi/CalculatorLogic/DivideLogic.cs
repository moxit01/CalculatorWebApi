using System;
namespace CalculatorLogic
{
	public class DivideLogic
	{
		public static double Divide(double num1, double num2)
		{
            if (num2 == 0)
            {
                return -1;
            }
            else
            {
                return num1 / num2;
            }
        }
	}
}

