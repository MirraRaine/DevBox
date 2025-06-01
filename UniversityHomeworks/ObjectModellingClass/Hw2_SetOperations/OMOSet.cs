namespace UniversityHomeworks.ObjectModellingClass.Hw2_SetOperations
{
    /// <summary>
    /// Class representing a general set, defines methods for adding and removing elements.
    /// </summary>
    public class OMOSet : IOMOSetView
    {
        /// <summary>
        /// HashSet storing the elements of the set. Elements are nullable integers (int?).
        /// </summary>
        public HashSet<int?> hashStorage;

        /// <summary>
        /// Constructor for the class, initializes an empty HashSet to store elements.
        /// </summary>
        public OMOSet()
        {
            this.hashStorage = new HashSet<int?>();
        }

        /// <summary>
        /// Method for adding an element to the set.
        /// </summary>
        /// <param name="element">The element to be added.</param>
        public void Add(int? element)
        {
            this.hashStorage.Add(element);
        }

        /// <summary>
        /// Method for removing an element from the set.
        /// </summary>
        /// <param name="element">The element to be removed.</param>
        public void Remove(int? element)
        {
            this.hashStorage.Remove(element);
        }

        /// <summary>
        /// Method that checks if the set contains a specific element.
        /// </summary>
        /// <param name="element">The element to check for presence in the set.</param>
        /// <returns>True if the element is present in the set; false otherwise.</returns>
        public bool Contains(int? element)
        {
            return this.hashStorage.Contains(element);
        }

        /// <summary>
        /// Method that returns a copy of the set.
        /// </summary>
        /// <returns>A copy of the current set.</returns>
        public IOMOSetView Copy()
        {
            OMOSet omoCopy = new OMOSet();
            foreach (int? elementHash in this.hashStorage)
            {
                omoCopy.Add(elementHash);
            }
            return omoCopy;
        }

        /// <summary>
        /// Method that returns an array containing all elements of the set.
        /// </summary>
        /// <returns>An array of elements from the set.</returns>
        public int?[] ToArray()
        {
            int?[] arrayInteger = new int?[this.hashStorage.Count];
            int i = 0;
            foreach (int? value in this.hashStorage)
            {
                arrayInteger[i++] = value;
            }
            return arrayInteger;
        }
    }
}