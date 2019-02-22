using System;
using System.Collections.Generic;
using System.Text;

namespace Stacks_Queues
{
    public class ThreeInOne
    {
        private const int NumStacks = 3;

        private readonly int[] stackArray;
        private StackInfo stack1;
        private StackInfo stack2;
        private StackInfo stack3;

        public ThreeInOne(int arraySize = 128)
        {
            this.stackArray = new int[arraySize];
            int stackSize = this.stackArray.Length / 3;
            this.stack1 = new StackInfo
            {
                StackNumber = 1,
                LowerBound = 0,
                UpperBound = stackSize,
                Top = this.stack1.LowerBound
            };
            this.stack2 = new StackInfo
            {
                StackNumber = 2,
                LowerBound = stackSize + 1,
                UpperBound = stackSize * 2,
                Top = this.stack2.LowerBound
            };
            this.stack3 = new StackInfo
            {
                StackNumber = 3,
                LowerBound = (stackSize * 2) + 1,
                UpperBound = this.stackArray.Length - 1,
                Top = this.stack3.LowerBound
            };
        }

        public void Push(int stackNumber, int data)
        {
            var stack = SelectStack(stackNumber);
            if(stack.Top == stack.UpperBound)
            {
                throw new ArgumentException("Stack full.");
            }
            stack.Top += 1;
            this.stackArray[stack.Top] = data;
            WriteStack(stack);
        }

        public int Pop(int stackNumber)
        {
            var stack = SelectStack(stackNumber);
            if(stack.Top < stack.LowerBound)
            {
                throw new ArgumentException("Stack empty.");
            }
            int result = this.stackArray[stack.Top];
            this.stackArray[stack.Top] = 0;
            stack.Top -= 1;
            WriteStack(stack);
            return result;
        }

        public int Peek(int stackNumber)
        {
            var stack = SelectStack(stackNumber);
            if(stack.Top < stack.LowerBound)
            {
                throw new ArgumentException("Stack empty.");
            }
            return this.stackArray[stack.Top];
        }

        public bool IsFull(int stackNumber)
        {
            var stack = SelectStack(stackNumber);
            return (stack.Top == stack.UpperBound) ? true : false;
        }

        public bool IsEmpty(int stackNumber)
        {
            var stack = SelectStack(stackNumber);
            return (stack.Top < stack.LowerBound) ? true : false;
        }

        private StackInfo SelectStack(int stackNumber)
        {
            if(stackNumber == 1)
            {
                return this.stack1;
            }
            else if(stackNumber == 2)
            {
                return this.stack2;
            }
            else if(stackNumber == 3)
            {
                return this.stack3;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Invalid stack specified.");
            }
        }

        private void WriteStack(StackInfo stack)
        {
            if(stack.StackNumber == 1)
            {
                this.stack1 = stack;
            }
            else if(stack.StackNumber == 2)
            {
                this.stack2 = stack;
            }
            else if(stack.StackNumber == 3)
            {
                this.stack3 = stack;
            }
        }
    }

    public class StackInfo
    {
        public int StackNumber { get; set; }

        public int LowerBound { get; set; }

        public int UpperBound { get; set; }

        public int Top { get; set; }
    }
}
