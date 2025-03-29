using DevExercises;

namespace DevExercisesTests
{
    /// <summary>
    /// Test class to validate functionality of the <see cref="ExpressionTree"/> class.
    /// </summary>
    [TestClass]
    public class ExpressionTreeTests
    {
        private ExpressionTree? tree;

        [TestInitialize]
        public void SetUp()
        {
            this.tree = new ExpressionTree();
        }

        [TestMethod]
        public void Test1()
        {
            // Arrange
            this.tree = new ExpressionTree();
            string postfix = "ab+c*";
            Node root = this.tree.ConstructTree(postfix.ToCharArray());

            // Act
            string infixWithTree = this.tree.InfixTraversal(root);
            string infixAsItGoes = ExpressionTree.GetInfixDirectly(postfix);

            // Assert
            Assert.AreEqual("((a+b)*c)", infixWithTree);
            Assert.AreEqual(infixAsItGoes, infixWithTree);
        }

        [TestMethod]
        public void Test2()
        {
            // Arrange
            string postfix = "ab*c+";
            this.tree = new ExpressionTree();
            Node root = this.tree.ConstructTree(postfix.ToCharArray());

            // Act
            string infixWithTree = this.tree.InfixTraversal(root);
            string infixAsItGoes = ExpressionTree.GetInfixDirectly(postfix);

            // Assert
            Assert.AreEqual("((a*b)+c)", infixWithTree);
            Assert.AreEqual(infixAsItGoes, infixWithTree);
        }

        [TestMethod]
        public void Test3()
        {
            // Arrange
            string postfix = "abc++";
            this.tree = new ExpressionTree();
            Node root = this.tree.ConstructTree(postfix.ToCharArray());

            // Act
            string infixWithTree = this.tree.InfixTraversal(root);
            string infixAsItGoes = ExpressionTree.GetInfixDirectly(postfix);

            // Assert
            Assert.AreEqual("(a+(b+c))", infixWithTree);
            Assert.AreEqual(infixAsItGoes, infixWithTree);

        }

        [TestMethod]
        public void Test4()
        {
            // Arrange
            this.tree = new ExpressionTree();
            string postfix = "abc+*d/";
            Node root = this.tree.ConstructTree(postfix.ToCharArray());

            // Act
            string infixWithTree = this.tree.InfixTraversal(root);
            string infixAsItGoes = ExpressionTree.GetInfixDirectly(postfix);

            // Assert
            Assert.AreEqual("((a*(b+c))/d)", infixWithTree);
            Assert.AreEqual(infixAsItGoes, infixWithTree);
        }

        [TestMethod]
        public void Test5()
        {
            // Arrange
            this.tree = new ExpressionTree();
            string postfix = "ab+cd+*";
            Node root = this.tree.ConstructTree(postfix.ToCharArray());

            // Act
            string infixWithTree = this.tree.InfixTraversal(root);
            string infixAsItGoes = ExpressionTree.GetInfixDirectly(postfix);

            // Assert
            Assert.AreEqual("((a+b)*(c+d))", infixWithTree);
            Assert.AreEqual(infixWithTree, infixAsItGoes);
        }

        [TestMethod]
        public void Test6()
        {
            this.tree = new ExpressionTree();
            string postfix = "abcd/*-";  // Sample postfix expression
            Node root = this.tree.ConstructTree(postfix.ToCharArray());

            // Act
            string infixWithTree = this.tree.InfixTraversal(root);
            string infixAsItGoes = ExpressionTree.GetInfixDirectly(postfix);

            // Assert
            Assert.AreEqual("(a-(b*(c/d)))", infixWithTree);
            Assert.AreEqual(infixAsItGoes, infixWithTree);
        }

        [TestMethod]
        public void Test7()
        {
            // Arrange
            this.tree = new ExpressionTree();
            string postfix = "ab*c+de/-";
            Node root = this.tree.ConstructTree(postfix.ToCharArray());

            // Act
            string infixWithTree = this.tree.InfixTraversal(root);
            string infixAsItGoes = ExpressionTree.GetInfixDirectly(postfix);

            Assert.AreEqual("((a*b)+c)-(d/e)", infixWithTree);
            Assert.AreEqual("(((a*b)+c)-(d/e))", infixAsItGoes);
        }

        [TestMethod]
        public void Test8()
        {
            // Arrange
            string postfix = "ab+cd-*";
            this.tree = new ExpressionTree();
            Node root = this.tree.ConstructTree(postfix.ToCharArray());

            // Act
            string infixWithTree = this.tree.InfixTraversal(root);
            string infixAsItGoes = ExpressionTree.GetInfixDirectly(postfix);

            // Assert
            Assert.AreEqual("((a+b)*(c-d))", infixWithTree);
            Assert.AreEqual(infixWithTree, infixAsItGoes);
        }
    }
}
