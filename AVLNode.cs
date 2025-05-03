using System;

namespace ADS103_Grishma_A00177960_Assignment3
{
    // Represents a node in an AVL Tree, which is a self-balancing Binary Search Tree
    public class AVLNode : BSTNode
    {
        // Height of the node, used to calculate balance factors during rebalancing
        public int Height;

        // Constructor: initializes an AVLNode with a given value
        // and sets the default height to 1 (leaf nodes start with height 1)
        public AVLNode(int value) : base(value)
        {
            Height = 1;
        }
    }
}
