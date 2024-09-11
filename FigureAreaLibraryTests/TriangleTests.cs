
namespace FigureArea.Tests
{
    [TestClass()]
    public class TriangleTests
    {
        [TestMethod()]
        public void TriangleTest()
        {
            Assert.ThrowsException<ArgumentException>(() => { var triangle = new Triangle(-1, 10, 11); });
            Assert.ThrowsException<ArgumentException>(() => { var triangle = new Triangle(0, 10, 11); });
            Assert.ThrowsException<ArgumentException>(() => { var triangle = new Triangle(1, -10, 11); });
            Assert.ThrowsException<ArgumentException>(() => { var triangle = new Triangle(1, 0, 11); });
            Assert.ThrowsException<ArgumentException>(() => { var triangle = new Triangle(1, 5, -11); });
            Assert.ThrowsException<ArgumentException>(() => { var triangle = new Triangle(1, 5, 0); });
            Assert.ThrowsException<ArgumentException>(() => { var triangle = new Triangle(1, 5, 10); });
            Assert.ThrowsException<ArgumentException>(() => { var triangle = new Triangle(5, 1, 6); });

            var triangle = new Triangle(5, 5, 9);

            Assert.IsNotNull(triangle);
            Assert.IsInstanceOfType<Figure>(triangle);
        }
    }
}