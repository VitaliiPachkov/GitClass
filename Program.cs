namespace GitClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle();
            square square = new square();
            Rectangle rectangle = new Rectangle();


            Console.WriteLine("Введите радиус окружности: ");
            double  R = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите сторону квадрата: ");
            double A = Convert.ToDouble(Console.ReadLine());


            Console.WriteLine("Введите первую сторону прямоугольника: ");
            double x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите вторую сторону прямоугольника: ");
            double y = Convert.ToDouble(Console.ReadLine());


            Console.WriteLine($"Площадь окружности -  {circle.CalculateAreaCircle(R)}"); ;
            Console.WriteLine($"Периметр окружности -  {circle.CalculatePerimetrCircle(R)}") ;

            Console.WriteLine($"Площадь квадрата -  {square.CalculateAreaSquare(A)}"); ;
            Console.WriteLine($"Периметр квадрата -  {square.CalculatePerimetrSquare(A)}");

            Console.WriteLine($"Площадь прямоугольника -  {rectangle.CalculateAreaRectangle(x, y)}"); ;
            Console.WriteLine($"Периметр прямоугольника -  {rectangle.CalculatePerimetrRectangle(x, y)}");
        }
    }
}