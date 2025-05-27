namespace UniversityHomeworks.ObjectModellingClass.Patterns.VisitorV2
{
    public interface ItemElement
    {
        public int Accept(ShoppingCartVisitor visitor);
    }
}
