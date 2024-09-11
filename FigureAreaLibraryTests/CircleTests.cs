namespace FigureArea.Tests
{
    [TestClass()]
    public class CircleTests
    {
        [TestMethod()]
        public void CircleTest()
        {
            Assert.ThrowsException<ArgumentException>(() => { var circle = new Circle(-10); });
            Assert.ThrowsException<ArgumentException>(() => { var circle = new Circle(0); });
            var circle = new Circle(50);
            Assert.IsNotNull(circle);
            Assert.IsInstanceOfType<Figure>(circle);
        }
    }
}