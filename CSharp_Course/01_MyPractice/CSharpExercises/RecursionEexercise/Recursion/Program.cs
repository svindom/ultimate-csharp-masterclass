namespace Recursion
{
    internal class Program
    {
        // Recursion occurs whe a method is called within itself
        // Factorial-5 = 5*4*3*2*1
        static void Main(string[] args)
        {
            int valueInt = 3;
            int factorialResult = Factoraial(valueInt);
            Console.WriteLine($"Factorial answer of {valueInt} is: {factorialResult}");

            Console.WriteLine();

            float valueFloat = 2f;
            int powerOf = 4;
            float powerResult = Power(valueFloat, powerOf);
            Console.WriteLine($"Power answer of {valueFloat} is: {powerResult}");



            Console.ReadKey();
        }

        private static int Factoraial(int factorialNum)
        {
            // EXIT CONDITION HERE
            if (factorialNum == 1)   
            {
                return 1;
            }
            return factorialNum * Factoraial(factorialNum - 1);
        }

        private static float Power(float num, int powerOf)
        {
            // EXIT CONDITION HERE
            if (powerOf == 1)
            {
                return num;
            }

            return num * Power(num, powerOf - 1);
        }
    }
}