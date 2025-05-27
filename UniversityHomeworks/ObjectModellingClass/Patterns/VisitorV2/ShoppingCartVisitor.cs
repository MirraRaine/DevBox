namespace UniversityHomeworks.ObjectModellingClass.Patterns.VisitorV2
{
    public interface ShoppingCartVisitor
    {
        int Visit(Book book);
        int Visit(Fruit fruit);
    }
}
