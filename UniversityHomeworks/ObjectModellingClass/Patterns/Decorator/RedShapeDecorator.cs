namespace UniversityHomeworks.ObjectModellingClass.Patterns.Decorator
{
    public class RedShapeDecorator : ShapeDecorator
    {
        public RedShapeDecorator(IShape decoratedShape) : base(decoratedShape)
        {
        }

        public void Draw()
        {
            decoratedShape.Draw();
            SetRedBorder(decoratedShape);//этот метод ниже описан, можно просто добавить соут(красный цвет)
            Console.WriteLine("Border Color: Red");
        }

        private void SetRedBorder(IShape decoratedShape)
        {
            Console.WriteLine("Border Color: Red");
        }
    }
}
