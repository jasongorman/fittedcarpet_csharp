using System;

namespace GoodBadCode
{
    public static class FittedCarpet
    {
        public static double Price(
            double pricePerSqrMtr,
            Shape shape,
            double length,
            double width,
            double radius,
            double side, 
            double a, 
            double b, 
            double height)
        {
            double area = 0.0;
                
            switch (shape)
            {
                case Shape.Rectangle:
                    area = length * width;
                    break;
                case Shape.Circle:
                    area = Math.PI * radius * radius;
                    break;
                case Shape.EquilateralTriangle:
                    area = side * side * (Math.Sqrt(3) / 4);
                    break;
                case Shape.Trapezium:
                    area = height * ((a + b) / 2);
                    break;
            }

            return Math.Round(area * pricePerSqrMtr, 2);
        }
    }
}