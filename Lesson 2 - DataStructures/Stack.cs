using System.Collections.Generic;

namespace Lesson2DataStructures {
    interface IStack<T> : IEnumerable<T> {
        void Push(T item);
        T Pop();
    }

    class Stack<T> : LinkedListBase<T>, IStack<T> where T : class {
        public void Push(T item) {
            Append(item);
        }

        public T Pop() {
            return RemoveLast();
        }
    }
}
