using UniversityHomeworks.ObjectModellingClass.Hw2_SetOperations;

namespace UniversityHomeworksTests.ObjectModellingClass
{
    /// <summary>
    /// Test class to validate functionality of the <see cref="Hw2_SetOperations"/> folder classes.
    /// </summary>
    [TestClass]
    public sealed class Hw2_SetOperations_Tests
    {
        [TestMethod]
        public void TestAddAndContains()
        {
            OMOSet set = new OMOSet();
            set.Add(1);
            set.Add(2);

            Assert.IsTrue(set.Contains(1));
            Assert.IsTrue(set.Contains(2));
            Assert.IsFalse(set.Contains(3));
        }

        [TestMethod]
        public void TestRemove()
        {
            OMOSet set = new OMOSet();
            set.Add(1);
            set.Add(2);
            set.Remove(1);

            Assert.IsFalse(set.Contains(1));
            Assert.IsTrue(set.Contains(2));
        }

        [TestMethod]
        public void TestCopy()
        {
            OMOSet original = new OMOSet();
            original.Add(1);
            original.Add(2);
            OMOSetView copy = original.Copy();

            Assert.IsTrue(copy.Contains(1));
            Assert.IsTrue(copy.Contains(2));

            // Modify the original set and ensure it does not affect the copy
            original.Remove(1);

            Assert.IsFalse(original.Contains(1));
            Assert.IsTrue(copy.Contains(1));
        }

        [TestMethod]
        public void TestToArray()
        {
            OMOSet set = new OMOSet();
            set.Add(1);
            set.Add(2);
            int?[] array = set.ToArray();

            CollectionAssert.AreEqual(new int?[] { 1, 2 }, array);
        }

        [TestMethod]
        public void TestUnion()
        {
            OMOSet A = new OMOSet();
            A.Add(1);
            A.Add(2);

            OMOSet B = new OMOSet();
            B.Add(2);
            B.Add(3);

            OMOSetUnion union = new OMOSetUnion(A, B);
            int?[] result = union.ToArray();

            CollectionAssert.AreEquivalent(new int?[] { 1, 2, 3 }, result);
        }

        [TestMethod]
        public void TestIntersection()
        {
            OMOSet A = new OMOSet();
            A.Add(1);
            A.Add(2);

            OMOSet B = new OMOSet();
            B.Add(2);
            B.Add(3);

            OMOSetIntersection intersection = new OMOSetIntersection(A, B);
            int?[] result = intersection.ToArray();
            CollectionAssert.AreEquivalent(new int?[] { 2 }, result);
        }

        [TestMethod]
        public void TestComplement()
        {
            OMOSet A = new OMOSet();
            A.Add(1);
            A.Add(2);

            OMOSet B = new OMOSet();
            B.Add(2);
            B.Add(3);

            OMOSetComplement complement = new OMOSetComplement(A, B);
            int?[] result = complement.ToArray();

            CollectionAssert.AreEquivalent(new int?[] { 1 }, result);
        }

        [TestMethod]
        public void TestEvenNumbers()
        {
            OMOSet A = new OMOSet();
            A.Add(1);
            A.Add(2);
            A.Add(3);
            A.Add(4);

            OMOSetEven evenSet = new OMOSetEven(A);
            int?[] result = evenSet.ToArray();

            CollectionAssert.AreEquivalent(new int?[] { 2, 4 }, result);
        }

        [TestMethod]
        public void TestUnionContains()
        {
            OMOSet A = new OMOSet();
            A.Add(1);
            A.Add(2);

            OMOSet B = new OMOSet();
            B.Add(2);
            B.Add(3);

            OMOSetUnion union = new OMOSetUnion(A, B);

            Assert.IsTrue(union.Contains(1));
            Assert.IsTrue(union.Contains(2));
            Assert.IsTrue(union.Contains(3));
        }

        [TestMethod]
        public void TestIntersectionContains()
        {
            OMOSet A = new OMOSet();
            A.Add(1);
            A.Add(2);

            OMOSet B = new OMOSet();
            B.Add(2);
            B.Add(3);

            OMOSetIntersection intersection = new OMOSetIntersection(A, B);

            Assert.IsFalse(intersection.Contains(1));
            Assert.IsTrue(intersection.Contains(2));
            Assert.IsFalse(intersection.Contains(3));
        }

        [TestMethod]
        public void TestComplementContains()
        {
            OMOSet A = new OMOSet();
            A.Add(1);
            A.Add(2);

            OMOSet B = new OMOSet();
            B.Add(2);
            B.Add(3);

            OMOSetComplement complement = new OMOSetComplement(A, B);

            Assert.IsTrue(complement.Contains(1));
            Assert.IsFalse(complement.Contains(2));
        }

        [TestMethod]
        public void TestEvenNumbersContains()
        {
            OMOSet A = new OMOSet();
            A.Add(1);
            A.Add(2);
            A.Add(3);
            A.Add(4);

            OMOSetEven evenSet = new OMOSetEven(A);

            Assert.IsFalse(evenSet.Contains(1));
            Assert.IsTrue(evenSet.Contains(2));
            Assert.IsFalse(evenSet.Contains(3));
            Assert.IsTrue(evenSet.Contains(4));
        }

        [TestMethod]
        public void TestUnionCopy()
        {
            OMOSet A = new OMOSet();
            A.Add(1);
            A.Add(2);

            OMOSet B = new OMOSet();
            B.Add(2);
            B.Add(3);

            OMOSetUnion union = new OMOSetUnion(A, B);
            OMOSetView copy = union.Copy();

            Assert.IsTrue(copy.Contains(1));
            Assert.IsTrue(copy.Contains(2));
            Assert.IsTrue(copy.Contains(3));

            // Modify the original sets and ensure it does not affect the copy
            A.Remove(1);

            Assert.IsFalse(A.Contains(1));
            Assert.IsTrue(B.Contains(2));
            Assert.IsTrue(copy.Contains(1));
        }

        [TestMethod]
        public void TestIntersectionCopy()
        {
            OMOSet A = new OMOSet();
            A.Add(1);
            A.Add(2);

            OMOSet B = new OMOSet();
            B.Add(2);
            B.Add(3);

            OMOSetIntersection intersection = new OMOSetIntersection(A, B);
            OMOSetView copy = intersection.Copy();

            Assert.IsFalse(copy.Contains(1));
            Assert.IsTrue(copy.Contains(2));
            Assert.IsFalse(copy.Contains(3));

            // Modify the original sets and ensure it does not affect the copy
            A.Remove(2);

            Assert.IsFalse(A.Contains(2));
            Assert.IsTrue(B.Contains(2));
            Assert.IsTrue(copy.Contains(2));
        }

        [TestMethod]
        public void TestComplementCopy()
        {
            OMOSet A = new OMOSet();
            A.Add(1);
            A.Add(2);

            OMOSet B = new OMOSet();
            B.Add(2);
            B.Add(3);

            OMOSetComplement complement = new OMOSetComplement(A, B);
            OMOSetView copy = complement.Copy();

            Assert.IsTrue(copy.Contains(1));
            Assert.IsFalse(copy.Contains(2));

            // Modify the original sets and ensure it does not affect the copy
            A.Remove(1);

            Assert.IsFalse(A.Contains(1));
            Assert.IsTrue(B.Contains(2));
            Assert.IsTrue(copy.Contains(1));
        }
    }
}
