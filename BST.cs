using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADS103_Grishma_A00177960_Assignment3
{
    public class BST
    {
        protected BSTNode Root;

        public virtual void Insert(int value)
        {
            Root = InsertRec(Root, value);
        }

        protected BSTNode InsertRec(BSTNode node, int value)
        {
            if (node == null) return new BSTNode(value);
            if (value < node.Value) node.Left = InsertRec(node.Left, value);
            else node.Right = InsertRec(node.Right, value);
            return node;
        }

        public bool Search(int value)
        {
            return SearchRec(Root, value);
        }

        protected bool SearchRec(BSTNode node, int value)
        {
            if (node == null) return false;
            if (node.Value == value) return true;
            return value < node.Value ? SearchRec(node.Left, value) : SearchRec(node.Right, value);
        }
    }
}
