using System;

namespace Delegates
{
    class Program
    {
        public delegate void CalculateDelagate(int x, int y);
        static void Main(string[] args)
        {
            UseActionDelegate(Void.AdditionConsole, 1,2);
            var UseFuncDelegateResult = UseFuncDelegate(Return.Multiplication, 3,7);
            var UseFuncDelegateResultLambda = UseFuncDelegate((x, y) => x + y, 4,5);
            
            Console.WriteLine($"The Func result = {UseFuncDelegateResult}");
            Console.WriteLine($"The Func resultLambda = {UseFuncDelegateResultLambda}");
        }


        static void UseActionDelegate(Action<int, int> method, int x, int y) => method(x,y);
        static int UseFuncDelegate(Func<int, int, int> method, int x, int y) => method(x,y);
        
        
        static void CheckCustomDelegate()
        {
            CalculateDelagate voidDelegate = Void.AdditionConsole;
            voidDelegate(10,5);

            CalculateDelagate voidLambdadelegate = (int x, int y) => Console.WriteLine($"The result of lambda delegate: {x+y}");
            voidLambdadelegate(20,7);

            Console.ReadKey();
        }
        
    }
    
    
    public static class Void
    {
        public static void AdditionConsole(int x, int y) =>  Console.WriteLine($"The Addition of {x} and {y}: {x+y}");
        public static void SubtractionConsole(int x, int y) => Console.WriteLine($"The Subtraction of {x} and {y}: {x-y}");
        public static void MultiplicationConsole(int x, int y) => Console.WriteLine($"The Multiplication of {x} and {y}: {x*y}");
        public static void DivisionConsole(int x, int y) => Console.WriteLine($"The Division of {x} and {y}: {x/y}");
    }

    public static class Return
    {
        public static int Addition(int x, int y) => x + y;
        public static int Subtraction(int x, int y) => x - y;
        public static int Multiplication(int x, int y) => x * y;
        public static int Division(int x, int y) => x/y;
    }
}