namespace triangleOutputExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            bool isNumValid = false;

            while (!isNumValid)
            {
                Console.WriteLine("Enter a number:");
                if(int.TryParse(Console.ReadLine(), out num) && num > 0)
                {
                    isNumValid = true;
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Invalid input!");
                    Console.WriteLine("Please enter valid positive integers for number.");
                    Console.WriteLine("--------------------------------------------------------");
                }
            }

            int width = 0;
            while (true)
            {
                Console.WriteLine("Please enter a width");
                if (int.TryParse(Console.ReadLine(),out width) && width > 0)
                {
                    Triangle triangle = new Triangle(num, width);
                    triangle.GetTriangle();
                    break;
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Invalid input!");
                    Console.WriteLine("Please enter valid positive integers for width.");
                    Console.WriteLine("--------------------------------------------------------");
                }
            }

            Console.ReadKey();
        }
    }
    class Triangle
    {
        public int Num { get; set; }
        public int Width { get; set; }

        private int _height;
        public Triangle(int num, int width)
        {
            Num = num;
            Width = width;
            _height = width;
        }

        public void GetTriangle()
        {
            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine();
            for (int row = 0; row < _height; row++)
            {
                for (int col = Width; col > row; col--)
                {
                    Console.Write(Num);
                }
                Console.WriteLine();
            }
        }
    }
}


