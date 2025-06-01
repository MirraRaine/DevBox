namespace UniversityHomeworks.ObjectModellingClass.Hw2_SetOperations
{
    /// <summary>
    /// Class representing the intersection of two sets: A ∩ B.
    /// </summary>
    public class OMOSetIntersection : IOMOSetView
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
        public OMOSetIntersection(IOMOSetView setA, IOMOSetView setB)
        {
            this.setA = setA;
            this.setB = setB;
        }

        /// <summary>
        /// Method that checks if the intersection contains a specific element.
        /// </summary>
        /// <param name="element">The element to check for presence in the intersection.</param>
        /// <returns>True if the element is present in both sets; false otherwise.</returns>
        public bool Contains(int? element)
        {
            return Intersection().Contains(element);
        }

        /// <summary>
        /// Method that returns an array containing all elements of the intersection.
        /// </summary>
        /// <returns>An array of elements from the intersection set.</returns>
        public int?[] ToArray()
        {
            return Intersection().ToArray();
        }

        /// <summary>
        /// Method that returns a copy of the intersection set.
        /// </summary>
        /// <returns>A new instance representing the same intersection set.</returns>
        public IOMOSetView Copy()
        {
            return new OMOSetIntersection(this.setA.Copy(), this.setB.Copy());
        }

        /// <summary>
        /// Method that computes and returns a new set containing elements common to both sets.
        /// </summary>
        /// <returns>A new OMOSet representing the intersection.</returns>
        private IOMOSetView Intersection()
        {
            var arrayA = this.setA.ToArray();
            var arrayB = this.setB.ToArray();

            var intersectedElements = new HashSet<int?>(arrayA).Intersect(arrayB);

            var finalSet = new OMOSet();
            foreach (int? element in intersectedElements)
            {
                finalSet.Add(element);
            }

            return finalSet;
        }
    }
}