namespace UniversityHomeworks.ObjectModellingClass.Patterns.VisitorV2
{
    public interface ItemElement
    {
        public int Accept(IShoppingCartVisitor visitor);
    }
}
