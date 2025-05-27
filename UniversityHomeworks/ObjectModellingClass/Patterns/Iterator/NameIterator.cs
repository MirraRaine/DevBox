namespace UniversityHomeworks.ObjectModellingClass.Patterns.Iterator
{
    public class NameIterator : Iterator
    {

        int index;
        public string[] names = { "Robert", "John", "Julie", "Lora" };

        public bool HasNext()
        {
            if (index < names.Length)
            {
                return true;
            }
            return false;
        }

        public object Next()
        {

            if (this.HasNext())
            {
                return names[index++];
            }
            return null;
        }
    }
}
