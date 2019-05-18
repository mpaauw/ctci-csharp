using System;
using System.Collections.Generic;
using System.Text;

namespace Trees_Graphs
{
    public class CustomTreeNode
    {
        public int Data { get; private set; }
        private CustomTreeNode left;
        private CustomTreeNode right;
        public int Size { get; private set; }

        public CustomTreeNode(int data)
        {
            this.Data = data;
        }

        public void InsertInOrder(int data)
        {
            if(data < this.Data)
            {
                if(this.left == null)
                {
                    this.left = new CustomTreeNode(data);
                }
                else
                {
                    this.left.InsertInOrder(data);
                }
            }
            else
            {
                if(this.right == null)
                {
                    this.right = new CustomTreeNode(data);
                }
                else
                {
                    this.right = new CustomTreeNode(data);
                }
            }
            this.Size++;
        }

        public CustomTreeNode GetRandomNode()
        {
            int leftSize = (this.left == null) ? 0 : this.left.Size;
            var rand = new Random();
            var index = rand.Next(this.Size);
            if(index < leftSize)
            {
                return this.left.GetRandomNode();
            }
            else if(index == leftSize)
            {
                return this;
            }
            else
            {
                return this.right.GetRandomNode();
            }
        }

        public CustomTreeNode Find(int data)
        {
            if(data == this.Data)
            {
                return this;
            }
            else if(data <= this.Data)
            {
                return (this.left != null) ? this.left.Find(data) : null;
            }
            else
            {
                return (this.right != null) ? this.right.Find(data) : null;
            }
        }
    }
}
