namespace UniversityHomeworks.ObjectModellingClass.Hw2_SetOperations
{
    /// <summary>
    /// Class representing the union of two sets: A ∪ B.
    /// </summary>
    public class OMOSetUnion : IOMOSetView
    {
        /// <summary>
        /// Reference to the first set (A).
        /// </summary>
        private readonly IOMOSetView setA;

        /// <summary>
        /// Reference to the second set (B).
        /// </summary>
        private readonly IOMOSetView setB;

        /// <summary>
        /// Constructor for the class, initializes with two sets.
        /// </summary>
        /// <param name="setA">The first set.</param>
        /// <param name="setB">The second set.</param>
        public OMOSetUnion(IOMOSetView setA, IOMOSetView setB)
        {
            this.setA = setA;
            this.setB = setB;
        }

        /// <summary>
        /// Method that checks if the union contains a specific element.
        /// </summary>
        /// <param name="element">The element to check for presence in the union.</param>
        /// <returns>True if the element is present in either of the sets; false otherwise.</returns>
        public bool Contains(int? element)
        {
            return Union().Contains(element);
        }

        /// <summary>
        /// Method that returns an array containing all elements of the union.
        /// </summary>
        /// <returns>An array of elements from the union set.</returns>
        public int?[] ToArray()
        {
            return Union().ToArray();
        }

        /// <summary>
        /// Method that returns a copy of the union set.
        /// </summary>
        /// <returns>A new instance representing the same union set.</returns>
        public IOMOSetView Copy()
        {
            return new OMOSetUnion(this.setA.Copy(), this.setB.Copy());
        }

        /// <summary>
        /// Method that computes and returns a new set containing all elements from both sets.
        /// </summary>
        /// <returns>A new OMOSet representing the union.</returns>
        public IOMOSetView Union()
        {
            OMOSet setC = new OMOSet();
            int?[] A = this.setA.ToArray();
            int?[] B = this.setB.ToArray();

            foreach (int? a in A)
            {
                setC.Add(a);
            }

            foreach (int? b in B)
            {
                setC.Add(b);
            }

            return setC;
        }
    }
}