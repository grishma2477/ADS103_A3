using System;

namespace ADS103_Grishma_A00177960_Assignment3
{
    // Represents a node in a Binary Search Tree
    public class BSTNode
    {
        // The value stored in the node
        public int Value;

        // Reference to the left child node
        public BSTNode Left;

        // Reference to the right child node
        public BSTNode Right;

        // Constructor to initialize the node with a value
        public BSTNode(int value)
        {
            Value = value;
        }
    }
}
