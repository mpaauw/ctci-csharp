using System;
using System.Collections.Generic;
using System.Text;

namespace Stacks_Queues
{
    /// <summary>
    /// Maintains a collection of stacks, each with 'heights' relative to a supplied threshold.
    /// </summary>
    /// <typeparam name="T">Type of data to be stored within each stack.</typeparam>
    public class SetOfStacks<T>
    {
        /// <summary>
        /// Collection of Stacks.
        /// </summary>
        private readonly IList<Stack<T>> stacks;

        /// <summary>
        /// Maximum number of elements any stack in the collection may hold.
        /// </summary>
        private readonly int threshold;

        /// <summary>
        /// Simple pointer to the current stack in our list with which we should perform operations.
        /// </summary>
        private int current = 0;

        public SetOfStacks(int threshold)
        {
            this.threshold = threshold;
            this.stacks = new List<Stack<T>>();
        }

        /// <summary>
        /// Push a value onto the current stack.
        /// </summary>
        /// <param name="value">Value to push onto the stack.</param>
        public void Push(T value)
        {
            if(stacks[current].Count == this.threshold)
            {
                stacks.Add(new Stack<T>());
                this.current += 1;
            }
            stacks[current].Push(value);
        }
        
        /// <summary>
        /// Push a value onto a specified stack.
        /// </summary>
        /// <param name="index">Index of the stack to push onto.</param>
        /// <param name="value">Value to push onto the stack.</param>
        public void PushAt(int index, T value)
        {
            if(stacks[index].Count == this.threshold)
            {
                stacks.Add(new Stack<T>());
                index += 1;
            }
            stacks[index].Push(value);
        }

        /// <summary>
        /// Return and remove the top value from the current stack.
        /// If no elements can be found in any stack, an InvalidOperationException is thrown.
        /// </summary>
        /// <returns>Value returned from the top of the current stack.</returns>
        public T Pop()
        {
            if(stacks[current].Count == 0)
            {
                stacks.RemoveAt(current);
                current -= 1;
                if(current < 0)
                {
                    throw new InvalidOperationException("All stacks empty.");
                }
            }
            return stacks[current].Pop();
        }

        /// <summary>
        /// Return and remove the top value from a specified stack.
        /// If no elements can be found in the given stack, an InvalidOperationException is thrown.
        /// </summary>
        /// <param name="index">Index of the stack to pop from.</param>
        /// <returns>Value returned from the top of the specified stack.</returns>
        public T PopAt(int index)
        {
            if(stacks[index].Count == 0)
            {
                throw new InvalidOperationException($"Stack at index {index} is empty.");
            }
            return stacks[index].Pop();
        }

        /// <summary>
        /// Return the top value from the current stack.
        /// </summary>
        /// <returns>Value from the top of the current stack.</returns>
        public T Peek()
        {
            if(stacks[current].Count == 0)
            {
                stacks.RemoveAt(current);
                current -= 1;
                if(current < 0)
                {
                    throw new InvalidOperationException("All stacks empty.");
                }
            }
            return stacks[current].Peek();
        }
    }
}
