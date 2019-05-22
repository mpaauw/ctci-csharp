using System;
using System.Collections.Generic;
using System.Text;

namespace Stacks_Queues
{
    public class TwoStacksQueue
    {
        private Stack<int> inStack;
        private Stack<int> outStack;

        public TwoStacksQueue()
        {
            this.inStack = new Stack<int>();
            this.outStack = new Stack<int>();
        }

        public void Push(int x)
        {
            if (inStack.Count == 0 && outStack.Count > 0)
            {
                Transfer(outStack, inStack);
            }
            this.inStack.Push(x);
        }

        public int Pop()
        {
            if (Empty())
            {
                throw new ArgumentException("Queue is empty!");
            }
            else if (outStack.Count == 0 && inStack.Count > 0)
            {
                Transfer(inStack, outStack);
            }
            return outStack.Pop();
        }

        public int Peek()
        {
            if (Empty())
            {
                throw new ArgumentException("Queue is empty!");
            }
            else if (outStack.Count == 0 && inStack.Count > 0)
            {
                Transfer(inStack, outStack);
            }
            return outStack.Peek();
        }

        public bool Empty()
        {
            return inStack.Count == 0 && outStack.Count == 0;
        }

        private void Transfer(Stack<int> source, Stack<int> destination)
        {
            while (source.Count > 0)
            {
                destination.Push(source.Pop());
            }
        }
    }
}
