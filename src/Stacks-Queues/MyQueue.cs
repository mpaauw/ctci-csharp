using System;
using System.Collections.Generic;
using System.Text;

namespace Stacks_Queues
{
    public class MyQueue<T>
    {
        private Stack<T> inStack; // stack used primarily for Enqueue operations

        private Stack<T> outStack; // stack used primarily for Dequeue operations

        public MyQueue()
        {
            this.inStack = new Stack<T>();
            this.outStack = new Stack<T>();
        }

        public void Enqueue(T value)
        {
            this.inStack.Push(value);
        }

        public T Dequeue()
        {
            MoveOut();

            var result = this.outStack.Pop();

            MoveIn();

            return result;
        }

        public T Peek()
        {
            MoveOut();

            var result = this.outStack.Peek();

            MoveIn();

            return result;
        }

        private void MoveIn()
        {
            while(this.outStack.Count > 0)
            {
                this.inStack.Push(this.outStack.Pop());
            }
        }

        private void MoveOut()
        {
            while(this.inStack.Count > 0)
            {
                this.outStack.Push(this.inStack.Pop());
            }
        }
    }
}
