namespace CodignforAEC1
{
    class Program

    {
        static void Main(string[] arg)

        {

            double a = 5;
            double b = 10;
            double c = 3.5973;
            double d = 359;

            double area = a * b;
            double perimeter = (a + b) * 2;

            double AreaCalculator (double dim1, double dim2)
            {
                double result = dim1 * dim2;
                Console.WriteLine("Área = " + result);
                return result ;



            }
            Console.WriteLine("Please enter the first dimension");
            string string1 = Console.ReadLine();
            Console.WriteLine("Please enter the second dimension");
            string string2 = Console.ReadLine();

            double e = Convert.ToDouble(string1);
            double f = Convert.ToDouble(string2);

            AreaCalculator(e, f);



            //double area1 = AreaCalculator (a, b);   
            //double area2 = AreaCalculator (c, b);
            //double area3 = AreaCalculator(d, 269);



            //Console.WriteLine("Perimetro = " + perimeter);
        }

         



    }



}

