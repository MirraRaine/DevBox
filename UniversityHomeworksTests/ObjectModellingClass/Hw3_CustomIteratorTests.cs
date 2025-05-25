using UniversityHomeworks.ObjectModellingClass.Hw3_Iterator;

namespace UniversityHomeworksTests.ObjectModellingClass
{
    /// <summary>
    /// Test class to validate functionality of the <see cref="Node"/> and <see cref="ICustomIterator"/> classes.
    /// </summary>
    [TestClass]
    public class Hw3_CustomIteratorTests
    {
        [TestMethod]
        public void NodePreorderIterator_Test()
        {
            // Create a simple binary tree
            var root = GetTree();

            // Expected in-order traversal sequence
            var expectedSequence = new List<int> { 7, 1, 0, 3, 2, 5, 4, 6, 9, 8, 10 };

            // Collect actual traversal sequence using HasNext and Next methods
            var actualSequence = new List<int>();
            var iterator = root.PreorderIterator();
            while (iterator.HasNext())
            {
                var node = iterator.Next();
                actualSequence.Add(node);
            }

            // Assert that the actual sequence matches the expected sequence
            CollectionAssert.AreEqual(expectedSequence, actualSequence);
        }

        [TestMethod]
        public void NodeInorderIterator_Test()
        {
            // Create a simple binary tree
            var root = GetTree();

            // Expected in-order traversal sequence
            var expectedSequence = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            // Create an iterator for the tree
            var iterator = root.InorderIterator();

            // Collect actual traversal sequence using HasNext and Next methods
            var actualSequence = new List<int>();
            while (iterator.HasNext())
            {
                var node = iterator.Next();
                actualSequence.Add(node);
            }

            // Assert that the actual sequence matches the expected sequence
            CollectionAssert.AreEqual(expectedSequence, actualSequence);
        }

        [TestMethod]
        public void NodePostorderIterator_Test()
        {
            // Create a simple binary tree
            var root = GetTree();

            // Expected in-order traversal sequence
            var expectedSequence = new List<int> { 0, 2, 4, 6, 5, 3, 1, 8, 10, 9, 7 };

            // Create an iterator for the tree
            var iterator = root.PostorderIterator();

            // Collect actual traversal sequence using HasNext and Next methods
            var actualSequence = new List<int>();
            while (iterator.HasNext())
            {
                var node = iterator.Next();
                actualSequence.Add(node);
            }

            // Assert that the actual sequence matches the expected sequence
            CollectionAssert.AreEqual(expectedSequence, actualSequence);
        }


        private Node GetTree()
        {
            Node n1 = new Node(1);
            Node n0 = new Node(0);
            Node n3 = new Node(3);
            Node n2 = new Node(2);
            Node n4 = new Node(4);
            Node n5 = new Node(5);
            Node n6 = new Node(6);
            Node root = new Node(7);
            Node n8 = new Node(8);
            Node n9 = new Node(9);
            Node n10 = new Node(10);

            root.Left = n1;
            root.Right = n9;

            n1.Left = n0;
            n1.Right = n3;

            n3.Left = n2;
            n3.Right = n5;

            n5.Left = n4;
            n5.Right = n6;

            n9.Left = n8;
            n9.Right = n10;

            return root;
        }

        public void Test()
        {
        }
        /*
        public static void main(string[] args)
        {
            //Node nod11 = new Node(11,null,null);

            //        Node nod10 = new Node(10, null, null);
            //        Node nod8 = new Node(8, null, null);
            //        
            //        
            //        Node nod5 = new Node(5, null, null);
            //        Node nod3 = new Node(3, null, null);
            Node nod2 = new Node(2, null, null);
            Node nod4 = new Node(4, null, null);
            //        Node nod1 = new Node(1, nod2, nod3);
            Node nod0 = new Node(0, nod4, null);

            //        Node nod3 = new Node(3, nod2, nod5);
            Node nod1 = new Node(0, nod2, nod0);
            //        
            //        Node nod7 = new Node(7, nod1, nod9);
            //         
            //        
            //        CustomIterator iterPre = nod7.preorderIterator();
            //        System.out.print("Preorder: ");
            //        while (iterPre.hasNext()) {
            //          
            //            System.out.print(iterPre.next() + " ");
            //        }
            //        System.out.println(" ");
            //        
            //        
            //         CustomIterator iterIn = nod7.inorderIterator();
            //         System.out.print("Inorder: ");
            //        while (iterIn.hasNext()) {
            //           
            //            System.out.print(iterIn.next() + " ");
            //        }
            //        System.out.println(" ");
            //        
            CustomIterator iterPost = nod1.postorderIterator();
            System.out.print("Postorder: ");
            while (iterPost.hasNext())
            {
                //           
                System.out.print(iterPost.next() + " ");
            }
            //            
            //            N3 n = new N3();
            //           // CustomIterator iterIn = nod7.inorderIterator();
            //         System.out.print("Inorder: ");
            //        while (n.hasNext()) {
            //           
            //            System.out.print(iterIn.next() + " ");
            //        }
        }
        */
    }
}
