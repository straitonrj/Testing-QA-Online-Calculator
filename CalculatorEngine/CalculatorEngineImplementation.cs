namespace CalculatorEngine;
using System;

public class CalculatorEngineImplementation
{
    public static float Add(float inputA, float inputB)
    {
        //preq-Engine-3
        return inputA + inputB;
    }

    public static float Subtract(float inputA, float inputB)
    {
        //preq-Engine-4
        return inputA - inputB;
    }

    public static float Multiply(float inputA, float inputB)
    {
        //preq-Engine-5
        return inputA * inputB;
    }
    
    public static float Divide(float inputA, float inputB)
    {
        //preq-Engine-7
        if (inputB == 0)
        {
            throw new DivideByZeroException("Cannot Divide by zero");
        }
        else
        {
            return inputA / inputB;
        }
    }
    
    //preq-Engine-8 Equals must go here
    
    public static float Exponent(float inputA, float inputB)
    {
        //preq-Engine-9
        return (float)Math.Pow(inputA,inputB);
    }
    //Need to put root method here, should root use exponent? Add inputB by itself until it reaches one?

    public static float Log(float inputA, float inputB)
    {
        //preq-Engine-10
        return (float)Math.Log(inputA, inputB);
    }
    //A only Methods are as follows:
    
    //Tested in separate application, works
    public static float Factorial(float inputA)
    {
        //preq-Engine-12
        if (inputA % 1 != 0)
        {
            inputA = (float)Math.Ceiling(inputA);
            //Factorial(inputA);
        }
        if (inputA <= 1)
        {
            return 1;
        }
        else
        {
            inputA = inputA * Factorial(inputA - 1);
            return inputA;
        }
    }

    public static float Sin(float inputA)
    {
        //preq-Engine-13
        return (float)Math.Sin(inputA);
    }

    public static float Cos(float inputA)
    {
        //preq-Engine-14
        return (float)Math.Cos(inputA);
    }

    public static float Tan(float inputA)
    {
        //preq-Engine-15
        //Tan uses Radians
        //Tan is undefined at these angles
        
        if (inputA == (float)Math.PI/2 || inputA == (float)Math.PI/2 * 3)
        {
            throw new DivideByZeroException("Undefined");
        }
        else
        {
            return (float)Math.Tan(inputA);
        }
    }

    public static float Reciprocal(float inputA)
    {
        //preq-Engine-16
        if (inputA == 0)
        {
            throw new DivideByZeroException("Undefined");
        }
        else
        {
            return 1 / inputA;
        }
    }
    
    
    
}