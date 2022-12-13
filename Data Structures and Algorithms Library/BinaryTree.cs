using System;
using System.Collections.Generic;
using System.Text;

namespace data_structures_algorithms_library
{
    // edited to for String rather than int, implemented IComparable<T>

    class BinaryTree<T> where T : IComparable<T>
    {
        public Node Root { get; set; }

        //public bool Add(int value)
        public bool Add(String value)
        {
            Node before = null, after = this.Root;

            while (after != null)
            {
                before = after;
                if (value.CompareTo(after.Data) < 0)
                //if (value < after.Data)
                    after = after.LeftNode;
                else if (value.CompareTo(after) > 0)
                //else if (value > after.Data)
                    after = after.RightNode;
                else
                {
                    //Exist same value
                    return false;
                }
            }

            Node newNode = new Node();
            newNode.Data = value;

            if (this.Root == null)
                this.Root = newNode;
            else
            {
                //if (value < before.Data)
                if (value.CompareTo(before.Data) < 0)
                    before.LeftNode = newNode;
                else
                    before.RightNode = newNode;
            }

            return true;
        }

        //public Node Find(int value)
        public Node Find(String value)
        {
            return this.Find(value, this.Root);
        }

        //public void Remove(int value)
        public void Remove(String value)
        {
            this.Root = Remove(this.Root, value);
        }

        //private Node Remove(Node parent, int key)
        private Node Remove(Node parent, String key)
        {
            if (parent == null) return parent;

            //if (key < parent.Data) parent.LeftNode = Remove(parent.LeftNode, key);
            if (key.CompareTo(parent.Data) < 0) parent.LeftNode = Remove(parent.LeftNode, key);
            //else if (key > parent.Data)
            else if (key.CompareTo(parent.Data) > 0)
                parent.RightNode = Remove(parent.RightNode, key);

            else
            {
                if (parent.LeftNode == null)
                    return parent.RightNode;
                else if (parent.RightNode == null)
                    return parent.LeftNode;

                parent.Data = MinValue(parent.RightNode);

                parent.RightNode = Remove(parent.RightNode, parent.Data);
            }

            return parent;
        }

        //private int MinValue(Node node)
        private String MinValue(Node node)
        {
            //int minv = node.Data;
            String minv = node.Data;

            while (node.LeftNode != null)
            {
                minv = node.LeftNode.Data;
                node = node.LeftNode;
            }

            return minv;
        }

        //private Node Find(int value, Node parent)
        private Node Find(String value, Node parent)
        {
            {
                if (parent != null)
                {
                    if (value == parent.Data) return parent;
                    if (value.CompareTo(parent.Data) < 0)
                        return Find(value, parent.LeftNode);
                    else
                        return Find(value, parent.RightNode);
                }
                return null;
            }
        }

        public int GetTreeDepth()
        {
            return this.GetTreeDepth(this.Root);
        }

        private int GetTreeDepth(Node parent)
        {
            return parent == null ? 0 : Math.Max(GetTreeDepth(parent.LeftNode), GetTreeDepth(parent.RightNode)) + 1;
        }

        public void TraversePreOrder(Node parent)
        {
            if (parent != null)
            {
                Console.Write(parent.Data + " ");
                TraversePreOrder(parent.LeftNode);
                TraversePreOrder(parent.RightNode);
            }
        }

        public void TraverseInOrder(Node parent)
        {
            if (parent != null)
            {
                TraverseInOrder(parent.LeftNode);
                Console.Write(parent.Data + " ");
                TraverseInOrder(parent.RightNode);
            }
        }

        public void TraversePostOrder(Node parent)
        {
            if (parent != null)
            {
                TraversePostOrder(parent.LeftNode);
                TraversePostOrder(parent.RightNode);
                Console.Write(parent.Data + " ");
            }
        }
    }


}
