namespace DevExercises
{
    /// <summary>
    /// Represents an expression tree that can construct a binary tree from postfix expressions and
    /// perform inorder traversal to get infix notation.
    /// </summary>
    public class ExpressionTree
    {
        public Node ConstructTree(char[] postfix)
        {
            Stack<Node> stack = new Stack<Node>();

            // Traverse through every character of input postfix expression
            for (int i = 0; i < postfix.Length; i++)
            {
                // If operand, simply push into stack
                if (IsOperator(postfix[i]))
                {
                    // Pop two top nodes
                    Node operand1 = stack.Pop();
                    Node operand2 = stack.Pop();

                    Node operatorChar = new Node(postfix[i]);

                    // Make them children of the operator node
                    operatorChar.Right = operand1;
                    operatorChar.Left = operand2;

                    // Add this subexpression to the stack
                    stack.Push(operatorChar);
                }
                else
                {
                    Node operandNode = new Node(postfix[i]);
                    stack.Push(operandNode);
                }
            }

            // Only one element will be in stack now, which is the root of the expression tree
            Node rootOfInfixNotation = stack.Pop();
            return rootOfInfixNotation;
        }

        // This function performs infix traversal of the tree and adds parentheses when necessary
        public string InfixTraversal(Node? node)
        {
            if (node == null)
            {
                return "";
            }

            // If the node is a leaf (operand), return its value
            if (node.Left == null && node.Right == null)
            {
                return node.Value.ToString();
            }

            // Recursively get the infix for left and right subtrees
            string leftInfix = InfixTraversal(node?.Left);
            string rightInfix = InfixTraversal(node?.Right);

            // If the node is an operator, we need to check if parentheses are necessary
            if (node?.Left != null && node.Right != null)
            {
                // If both left and right operands are operators with lower precedence, we need parentheses
                if (GetPrecedence(node.Value) > GetPrecedence(node.Left.Value) ||
                    GetPrecedence(node.Value) > GetPrecedence(node.Right.Value))
                {
                    return "(" + leftInfix + node.Value + rightInfix + ")";
                }
            }

            // Return the infix expression
            return leftInfix + node?.Value + rightInfix;
        }

        /// <summary>
        /// This method provides the output without first building a tree
        /// but builds the infix expression as it traverses through postfix expression
        /// </summary>
        public static string GetInfixDirectly(string postfix)
        {
            if (postfix == null)
            {
                return "";
            }

            Stack<NodeStr> stack = new Stack<NodeStr>();

            for (int i = 0; i < postfix.Length; i++)
            {
                NodeStr node = new NodeStr(postfix[i] + "");
                // Push operands
                if (IsOperator(postfix[i]))
                {
                    NodeStr operand1 = stack.Pop();
                    NodeStr operand2 = stack.Pop();
                    // If the node is a leaf (operand), return its value
                    if (operand1 == null && operand2 == null)
                    {
                        return node.Value;
                    }

                    // If the node is an operator, we need to check if parentheses are necessary
                    if (operand1 != null && operand2 != null)
                    {
                        // If both left and right operands are operators with lower precedence, we need parentheses
                        if (GetPrecedence(node.Value.ToCharArray()[0]) > GetPrecedence(operand1.Value.ToCharArray()[0]) ||
                        GetPrecedence(node.Value.ToCharArray()[0]) > GetPrecedence(operand2.Value.ToCharArray()[0]))
                        {
                            string result = "(" + operand2.Value + node.Value + operand1.Value + ")";
                            NodeStr n = new NodeStr(result);
                            stack.Push(n);
                        }
                        else
                        {
                            NodeStr n = new NodeStr(operand2.Value + node.Value + operand1.Value);
                            stack.Push(n);
                        }
                    }
                }
                else
                {
                    NodeStr n = new NodeStr(postfix[i] + "");
                    stack.Push(n);
                }
            }

            // There must be a single element in stack now which is the required infix.
            return stack.Peek().Value;
        }

        /// <summary>
        /// Determines whether the specified character is an operator.
        /// </summary>
        /// <param name="c">The character to check.</param>
        /// <returns><c>true</c> if the character is an operator; otherwise, <c>false</c>.</returns>
        private static bool IsOperator(char character)
        {
            return character switch
            {
                '+' or '-' or '*' or '/' or '^' => true,
                _ => false
            };
        }

        // This method returns the precedence of the operator
        private static int GetPrecedence(char op)
        {
            if (op == '+' || op == '-') return 1;
            if (op == '*' || op == '/') return 2;
            if (op == '^') return 3;
            return 0;
        }
    }
    public class NodeStr
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Node"/> class with a specified value.
        /// </summary>
        /// <param name="value">The value to store in the node.</param>
        public NodeStr(string value)
        {
            Value = value;
            Left = Right = null;
        }

        /// <summary>
        /// Gets or sets the value of the node.
        /// </summary>
        public string Value { get; set; }

        /// <summary>
        /// Gets or sets the left child of the node.
        /// </summary>
        public NodeStr? Left { get; set; }

        /// <summary>
        /// Gets or sets the right child of the node.
        /// </summary>
        public NodeStr? Right { get; set; }
    }

    public class Node
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Node"/> class with a specified value.
        /// </summary>
        /// <param name="value">The value to store in the node.</param>
        public Node(char value)
        {
            Value = value;
            Left = Right = null;
        }

        /// <summary>
        /// Gets or sets the value of the node.
        /// </summary>
        public char Value { get; set; }

        /// <summary>
        /// Gets or sets the left child of the node.
        /// </summary>
        public Node? Left { get; set; }

        /// <summary>
        /// Gets or sets the right child of the node.
        /// </summary>
        public Node? Right { get; set; }
    }
}
