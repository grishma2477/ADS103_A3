using System;

namespace ADS103_Grishma_A00177960_Assignment3
{
    // AVLTree inherits from BST but uses AVLNode and adds balancing logic
    public class AVLTree : BST
    {
        // Redefine the root to be of type AVLNode
        protected new AVLNode Root;

        // Public insert method that starts the recursive insertion and balancing
        public override void Insert(int value)
        {
            Root = InsertRec(Root, value);
        }

        // Returns the height of the given node or 0 if null
        private int Height(AVLNode node) => node?.Height ?? 0;

        // Returns the balance factor (left height - right height) of a node
        private int GetBalance(AVLNode node) =>
            node == null ? 0 : Height((AVLNode)node.Left) - Height((AVLNode)node.Right);

        // Right rotation to rebalance the tree when left-heavy
        private AVLNode RotateRight(AVLNode y)
        {
            AVLNode x = (AVLNode)y.Left;
            AVLNode T2 = (AVLNode)x.Right;

            // Perform rotation
            x.Right = y;
            y.Left = T2;

            // Update heights
            y.Height = Math.Max(Height((AVLNode)y.Left), Height((AVLNode)y.Right)) + 1;
            x.Height = Math.Max(Height((AVLNode)x.Left), Height((AVLNode)x.Right)) + 1;

            // Return new root
            return x;
        }

        // Left rotation to rebalance the tree when right-heavy
        private AVLNode RotateLeft(AVLNode x)
        {
            AVLNode y = (AVLNode)x.Right;
            AVLNode T2 = (AVLNode)y.Left;

            // Perform rotation
            y.Left = x;
            x.Right = T2;

            // Update heights
            x.Height = Math.Max(Height((AVLNode)x.Left), Height((AVLNode)x.Right)) + 1;
            y.Height = Math.Max(Height((AVLNode)y.Left), Height((AVLNode)y.Right)) + 1;

            // Return new root
            return y;
        }

        // Recursive insert function that also rebalances the tree
        private AVLNode InsertRec(AVLNode node, int value)
        {
            // Standard BST insertion
            if (node == null) return new AVLNode(value);

            if (value < node.Value)
                node.Left = InsertRec((AVLNode)node.Left, value);
            else if (value > node.Value)
                node.Right = InsertRec((AVLNode)node.Right, value);
            else
                return node; // Duplicate values are not inserted

            // Update this node's height
            node.Height = 1 + Math.Max(Height((AVLNode)node.Left), Height((AVLNode)node.Right));

            // Get the balance factor to check if rebalancing is needed
            int balance = GetBalance(node);

            // Perform appropriate rotations based on balance

            // Left Left Case
            if (balance > 1 && value < node.Left.Value)
                return RotateRight(node);

            // Right Right Case
            if (balance < -1 && value > node.Right.Value)
                return RotateLeft(node);

            // Left Right Case
            if (balance > 1 && value > node.Left.Value)
            {
                node.Left = RotateLeft((AVLNode)node.Left);
                return RotateRight(node);
            }

            // Right Left Case
            if (balance < -1 && value < node.Right.Value)
            {
                node.Right = RotateRight((AVLNode)node.Right);
                return RotateLeft(node);
            }

            // Return the unchanged node pointer
            return node;
        }

        // Public method to search for a value in the AVL Tree
        public bool Search(int value)
        {
            return SearchRec(Root, value);
        }

        // Recursive search function
        private bool SearchRec(AVLNode node, int value)
        {
            if (node == null) return false;
            if (node.Value == value) return true;

            return value < node.Value
                ? SearchRec((AVLNode)node.Left, value)
                : SearchRec((AVLNode)node.Right, value);
        }
    }
}
