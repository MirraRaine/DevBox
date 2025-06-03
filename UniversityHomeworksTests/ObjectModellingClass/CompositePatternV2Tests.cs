using UniversityHomeworks.ObjectModellingClass.Patterns.CompositeV2;

namespace UniversityHomeworksTests.ObjectModellingClass
{
    [TestClass]
    public class CompositePatternV2Tests
    {
        [TestMethod]
        public void Circle_Draw_ReturnsExpectedString()
        {
            // Arrange
            var circle = new Circle();

            // Act
            var result = circle.Draw("Red");

            // Assert
            Assert.AreEqual("Drawing Circle with color Red", result);
        }

        [TestMethod]
        public void Triangle_Draw_ReturnsExpectedString()
        {
            // Arrange
            var triangle = new Triangle();

            // Act
            var result = triangle.Draw("Blue");

            // Assert
            Assert.AreEqual("Drawing Triangle with color Blue", result);
        }

        [TestMethod]
        public void Drawing_Draw_CompositeWithMultipleShapes_ReturnsCombinedOutput()
        {
            // Arrange
            var drawing = new Drawing();
            drawing.Add(new Circle());
            drawing.Add(new Triangle());

            // Act
            var result = drawing.Draw("Green");

            // Assert
            string expected =
                "Drawing composite with color: Green" + Environment.NewLine +
                "Drawing Circle with color Green" + Environment.NewLine +
                "Drawing Triangle with color Green";

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Drawing_Clear_RemovesAllShapes()
        {
            // Arrange
            var drawing = new Drawing();
            drawing.Add(new Circle());
            drawing.Add(new Triangle());

            // Act
            drawing.Clear();
            var result = drawing.Draw("Black");

            // Assert
            Assert.AreEqual("Drawing composite with color: Black", result);
        }

        [TestMethod]
        public void Drawing_Remove_SpecificShape_RemovedFromOutput()
        {
            // Arrange
            var drawing = new Drawing();
            var circle = new Circle();
            var triangle = new Triangle();
            drawing.Add(circle);
            drawing.Add(triangle);

            // Act
            drawing.Remove(circle);
            var result = drawing.Draw("Yellow");

            // Assert
            string expected =
                "Drawing composite with color: Yellow" + Environment.NewLine +
                "Drawing Triangle with color Yellow";

            Assert.AreEqual(expected, result);
        }
    }
}
