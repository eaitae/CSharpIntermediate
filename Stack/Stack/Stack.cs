using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    internal class Stack
    {
        private readonly List<object> StackList = new List<object>();

        public void Push(object obj)
        {
            if (obj == null)
            {
                throw new InvalidOperationException("Cannot store null refereces in the stack");
            }

            StackList.Add(obj);
        }

        public object Pop()
        {

            if (StackList.Count == 0)
            {
                throw new InvalidOperationException("Cannot pop from an empty stack");
            }

            object Return = StackList[StackList.Count - 1];

            StackList.RemoveAt(StackList.Count - 1);

            return Return;
        }

        public void Clear()
        {
            if (StackList != null)
                StackList.Clear();
        }
    }
}
