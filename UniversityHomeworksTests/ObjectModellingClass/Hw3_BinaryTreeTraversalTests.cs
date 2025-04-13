using UniversityHomeworks.ObjectModellingClass.Hw3_Iterator;

namespace UniversityHomeworksTests.ObjectModellingClass
{
    /// <summary>
    /// Test class to validate functionality of the <see cref="BinaryTreeTraversal"/> folder classes.
    /// Tree example is taken from http://datastructuresnotes.blogspot.cz/2009/02/binary-tree-traversal-preorder-inorder.html
    /// </summary>
    [TestClass]
    public class Hw3_BinaryTreeTraversalTests
    {

        [TestMethod]
        public void PreOrder_Test()
        {
            Node root = GetTree();
            string tree = BinaryTreeTraversal.PreOrder(root);
            Assert.AreEqual("7 1 0 3 2 5 4 6 9 8 10 ", tree); //7 1 0 3 2 5 4 6 9 8 10 
        }

        [TestMethod]
        public void InOrder_Test()
        {
            Node root = GetTree();
            string tree = BinaryTreeTraversal.InOrder(root);
            Assert.AreEqual("0 1 2 3 4 5 6 7 8 9 10 ", tree);
        }

        [TestMethod]
        public void PostOrder_Test()
        {
            Node root = GetTree();
            string tree = BinaryTreeTraversal.PostOrder(root);
            Assert.AreEqual("0 2 4 6 5 3 1 8 10 9 7 ", tree);
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
    }
}
