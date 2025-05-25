
using UniversityHomeworks.ObjectModellingClass.Hw13_CompositePattern;

namespace UniversityHomeworksTests.ObjectModellingClass
{
    /// <summary>
    /// Test class to validate functionality of the <see cref="Hw13_CompositePattern"/>
    /// <see cref="CompositeGraphic"/>
    /// </summary>
    [TestClass]
    public class Hw13_CompositePatternTests
    {
        [TestMethod]
        public void Client_PrintFourElipses_Test()
        {
            // Arrange
            // initialize four ellipses
            Ellipse ellipse1 = new Ellipse();
            Ellipse ellipse2 = new Ellipse();
            Ellipse ellipse3 = new Ellipse();
            Ellipse ellipse4 = new Ellipse();

            // initialize three composite graphics
            CompositeGraphic graphic = new CompositeGraphic();

            CompositeGraphic graphic1 = new CompositeGraphic();

            // composes the graphics
            graphic1.Add(ellipse1); // 1
            graphic1.Add(ellipse2); // 2
            graphic1.Add(ellipse3); // 3

            CompositeGraphic graphic2 = new CompositeGraphic();
            graphic2.Add(ellipse4);

            graphic.Add(graphic1); // elipses: 1 2 3
            graphic.Add(graphic2); // elipses: 4

            // Act: Prints the complete graphic (four times the string "Ellipse").
            graphic.Print();
        }
    }
}
