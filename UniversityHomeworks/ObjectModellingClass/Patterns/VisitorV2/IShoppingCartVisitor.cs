namespace UniversityHomeworks.ObjectModellingClass.Patterns.VisitorV2
{
    public interface IShoppingCartVisitor
    {
        int Visit(Book book);
        int Visit(Fruit fruit);
    }
}
