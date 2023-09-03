namespace LineComparison
{
    internal class Program
    {
        public void usingCertesianSystem()
        {
            Console.Write("Enter the value of x1: ");
            double x1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the value of y1: ");
            double y1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the value of x2: ");
            double x2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the value of y2: ");
            double y2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the value of a1: ");
            double a1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the value of b1: ");
            double b1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the value of a2: ");
            double a2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the value of b2: ");
            double b2 = Convert.ToDouble(Console.ReadLine());

            double Length_Of_Line_1 = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Sqrt(Math.Pow(y2 - y1, 2)));

            double Length_Of_Line_2 = Math.Sqrt(Math.Pow(a2 - a1, 2) + Math.Sqrt(Math.Pow(b2 - b1, 2)));

            if (Length_Of_Line_1 == Length_Of_Line_2)
            {
                Console.WriteLine("Two Lines are equal");
            }
            else if (Length_Of_Line_1 > Length_Of_Line_2)
            {
                Console.WriteLine("Line 1 is greater than line 2");
            }
            else
            {
                Console.WriteLine("Line 2 is greter than line 1");
            }
        
        }
        static void Main(string[] args)
        {
            Program program = new Program();
            program.usingCertesianSystem();
        }
    }
}