﻿using System;
namespace CalculatorLogic
{
	public class Logic
	{
		public static double Addition(double num1, double num2)
		{
			return num1 + num2;
		}



		public static double Subtraction(double num1, double num2)
		{
			return num1 - num2;
		}



		public static double Multiplication(double num1, double num2)
		{
			return num1 * num2;
		}



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

