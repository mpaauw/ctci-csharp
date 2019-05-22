using System;
using System.Collections.Generic;
using System.Text;

namespace Stacks_Queues
{
    public class StackMin : Stack<int>
    {
        private Stack<MinWrapper<int>> minStack;

        public StackMin()
        {
           this.minStack = new Stack<MinWrapper<int>>();
        }

        public void Push(int data)
        {
            if(data <= Min())
            {
                this.minStack.Push(new MinWrapper<int> {
                    Data = data,
                    Count = 1
                });
            }
            this.Push(data);
        }

        public int Pop()
        {
            int poppedVal = this.Pop();
            MinWrapper<int> peekedVal = this.minStack.Peek();
            if(poppedVal == peekedVal.Data)
            {
                if(peekedVal.Count > 1)
                {
                    peekedVal.Count--;
                    this.minStack.Pop();
                    this.minStack.Push(peekedVal);
                }
                else
                {
                    this.minStack.Pop();
                }
            }
            return poppedVal;
        }

        public int Min()
        {
            if(this.minStack.Count < 1)
            {
                throw new InvalidOperationException("Stack is empty.");
            }
            return this.minStack.Peek().Data;
        }

        // Use this class to account for duplicate min values:
        public class MinWrapper<T>
        {
            public T Data { get; set; }

            public int Count { get; set; }
        }
    }
}
