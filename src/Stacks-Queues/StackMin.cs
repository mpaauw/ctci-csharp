using System;
using System.Collections.Generic;
using System.Text;

namespace Stacks_Queues
{
    public class StackMin : Stack<int>
    {
        private Stack<int> minStack;

        public StackMin()
        {
            minStack = new Stack<int>();
        }

        public void Push(int data)
        {
            if(data <= Min())
            {
                minStack.Push(data);
            }
            this.Push(data);
        }

        public int Pop()
        {
            int poppedVal = this.Pop();
            if(poppedVal == this.minStack.Peek())
            {
                minStack.Pop();
            }
            return poppedVal;
        }

        public int Min()
        {
            if(this.minStack.Count < 1)
            {
                throw new InvalidOperationException("Stack is empty.");
            }
            return this.minStack.Peek();
        }
    }
}
