namespace LineComparison
{
    internal class Program
    {
        public double usingCertesianSystem()
        {
            Console.Write("Enter the value of X1: ");
            double x1=Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the value of X2: ");
            double x2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the value of Y1: ");
            double Y1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the value of Y2: ");
            double Y2 = Convert.ToDouble(Console.ReadLine());

            double Length_Of_Line = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Sqrt(Math.Pow(Y2 - Y1, 2)));
            Console.WriteLine("Length Of Line: " + Length_Of_Line);
            return Length_Of_Line;
        }
        static void Main(string[] args)
        {
            Program program = new Program();
            program.usingCertesianSystem();
        }
    }
}