using NUnit.Framework;

namespace GoodBadCode
{
    public class FittedCarpetTests
    {
        [Test]
        public void PriceOfRectangularCarpet()
        {
            Assert.AreEqual(1200.0, FittedCarpet.Price(10.0,
                Shape.Rectangle,
                10.0,
                12.0,
                0.0,
                0,
                0,
                0,
                0));
        }
        
        [Test]
        public void PriceOfCircularCarpet()
        {
            Assert.AreEqual(785.40, FittedCarpet.Price(10.0,
                Shape.Circle,
                0.0,
                0.0,
                5.0,
                0,
                0,
                0,
                0));
        }

        [Test] public void PriceOfEquilateralTriangleCarpet()
        {
            Assert.AreEqual(108.25, FittedCarpet.Price(10.0,
                Shape.EquilateralTriangle,
                0.0,
                0.0,
                0.0,
                5.0,
                0,
                0,
                0), 0.01);
        }
        
        [Test] public void PriceOfTrapezoidCarpet()
        {
            Assert.AreEqual(180.0, FittedCarpet.Price(10.0,
                Shape.Trapezium,
                0.0,
                0.0,
                0.0,
                5.0,
                4.0,
                8.0,
                3.0), 0.01);
        }
    }
}