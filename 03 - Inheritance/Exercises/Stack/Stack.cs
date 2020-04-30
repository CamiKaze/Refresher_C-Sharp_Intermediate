using System;
using System.Collections;

namespace Stack
{
    public class Stack
    {
        public ArrayList StackList = new ArrayList();
        public void Push(object obj)
        {
            if (obj is null)
            {
                throw new System.InvalidOperationException(nameof(obj));
            }

            StackList.Add(obj);
        }

        public object Pop()
        {
            if (StackList[0] == null)
                throw new System.InvalidOperationException("Stack is empty");

            var poppedValue = StackList[StackList.Count - 1].ToString();
            StackList.RemoveAt(StackList.Count - 1);
            return poppedValue;
        }

        public void Clear()
        {
            StackList.Clear();
        }
    }
}
