namespace OperatorExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            var a = 17;
            var b = 4;
            var quotient = a/b;
            var remainder = a % b;
            if (a == 17 && b == 4)
            {
                Console.WriteLine(a + "/" + b + " is " + quotient + " remainder " + remainder);
            }

            Console.WriteLine("Enter the radius of a circle");
            var radius = double.Parse(Console.ReadLine());

            Console.WriteLine(AreaOfCircle(radius));
        }

        public static double AreaOfCircle(double radius)
        {
            var area = Math.PI * Math.Pow(radius, 2);
            return area;
        }
    }

}
