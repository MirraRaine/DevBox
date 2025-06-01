namespace UniversityHomeworks.ObjectModellingClass.Hw2_SetOperations
{
    /// <summary>
    /// Class representing A\B: the complement of set B relative to set A. 
    /// The result contains all elements that are in set A but not in set B.
    /// </summary>
    public class OMOSetComplement : IOMOSetView
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
        public OMOSetComplement(IOMOSetView setA, IOMOSetView setB)
        {
            this.setA = setA;
            this.setB = setB;
        }

        /// <summary>
        /// Method that checks if the set contains a specific element.
        /// </summary>
        /// <param name="element">The element to check for presence in the complement.</param>
        /// <returns>True if the element is present in the complement; false otherwise.</returns>
        public bool Contains(int? element)
        {
            return Complement().Contains(element);
        }

        /// <summary>
        /// Method that returns a copy of the set.
        /// </summary>
        /// <returns>A new instance representing the complement of the copied sets.</returns>
        public IOMOSetView Copy()
        {
            return new OMOSetComplement(this.setA.Copy(), this.setB.Copy());
        }

        /// <summary>
        /// Method that returns an array containing all elements of the set.
        /// </summary>
        /// <returns>An array of elements from the complement.</returns>
        public int?[] ToArray()
        {
            return Complement().ToArray();
        }

        /// <summary>
        /// Method that computes and returns the complement of set B relative to set A.
        /// </summary>
        /// <returns>A new OMOSet representing the complement.</returns>
        private IOMOSetView Complement()
        {
            OMOSet setC = new OMOSet();
            foreach (int? a in this.setA.ToArray())
            {
                setC.Add(a);
            }

            OMOSet setD = new OMOSet();
            foreach (int? b in this.setB.ToArray())
            {
                setD.Add(b);
            }

            setC.hashStorage.ExceptWith(setD.hashStorage);
            return setC;
        }
    }
}