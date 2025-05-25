namespace UniversityHomeworks.ObjectModellingClass.Patterns.AbstractFactory
{
    public interface IAbstractFactory
    {
        IColor GetColor();
        IShape GetShape();
    }
}
