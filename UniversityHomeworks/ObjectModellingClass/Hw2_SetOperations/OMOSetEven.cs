namespace UniversityHomeworks.ObjectModellingClass.Hw2_SetOperations
{
    /// <summary>
    /// Class representing a set of even numbers.
    /// </summary>
    public class OMOSetEven : IOMOSetView
    {
        /// <summary>
        /// Reference to the underlying set from which even numbers are filtered.
        /// </summary>
        private readonly IOMOSetView setA;

        /// <summary>
        /// Constructor for the class, initializes with a given set.
        /// </summary>
        /// <param name="setA">The underlying set.</param>
        public OMOSetEven(IOMOSetView setA)
        {
            this.setA = setA;
        }

        /// <summary>
        /// Method that checks if the set contains a specific element.
        /// </summary>
        /// <param name="element">The element to check for presence in the even numbers set.</param>
        /// <returns>True if the element is present and even; false otherwise.</returns>
        public bool Contains(int? element)
        {
            return this.Even().Contains(element);
        }

        /// <summary>
        /// Method that returns a copy of the set.
        /// </summary>
        /// <returns>A new instance representing the same set of even numbers.</returns>
        public IOMOSetView Copy()
        {
            return new OMOSetEven(this.setA.Copy());
        }

        /// <summary>
        /// Method that returns an array containing all elements of the set.
        /// </summary>
        /// <returns>An array of even numbers from the underlying set.</returns>
        public int?[] ToArray()
        {
            return this.Even().ToArray();
        }

        /// <summary>
        /// Method that filters and returns a new set containing only even numbers from the underlying set.
        /// </summary>
        /// <returns>A new OMOSet representing the set of even numbers.</returns>
        private IOMOSetView Even()
        {
            OMOSet setC = new OMOSet();
            foreach (int? i in this.setA.ToArray())
            {
                if (i % 2 == 0)
                {
                    setC.Add(i);
                }
            }
            return setC;
        }
    }
}