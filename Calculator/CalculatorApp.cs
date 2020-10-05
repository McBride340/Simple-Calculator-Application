using System;

namespace Calculator
{
    public class CalculatorApp
    {
        ///Add your code for application here
        ///Write a method for Subtraction, Multiplication, Division
        
        public int Add(int a, int b)
        {
            return a + b;
        }
        
        public int Subtract(int a, int b)
        {
            return a - b;
        }

        public int Multiply(int a, int b)
        {
            return a * b;
        }

        public int Divide(int a, int b)
        {
            return a / b;
        }
        
        public float AddFloat(float a, float b)
        {
        	return a + b;
        }

        public float SubtractFloat(float a, float b)
        {
        	return a - b;
        }

       	public float MultiplyFloat(float a, float b)
       	{
       		return a * b;
       	}

       	public float DivideFloat(float a, float b)
       	{
       		return a / b;
       	}

    }
}
