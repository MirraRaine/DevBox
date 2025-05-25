using UniversityHomeworks.ObjectModellingClass.Patterns.CompositeV2;

namespace UniversityHomeworksTests.ObjectModellingClass
{
    [TestClass]
    public class CompositePatternV2Tests
    {
        [TestMethod]
        public void Client_Test()
        {
            ShapeComponent tri = new TriangleLeaf();
            ShapeComponent tri1 = new TriangleLeaf();
            ShapeComponent cir = new CircleLeaf();

            Drawing drawing = new Drawing();
            drawing.Add(tri1);
            drawing.Add(tri1);
            drawing.Add(cir);

            drawing.Draw("Red");

            drawing.Clear();

            drawing.Add(tri);
            drawing.Add(cir);
            drawing.Draw("Green");
        }
    }
}
