
namespace Lesson2DataStructures {
    /// <summary>
    /// First in first out collection
    /// </summary>
    interface IQueue<T> {
        void Enqueue(T item);
        T Dequeue();
    }

    class Queue<T> : LinkedListBase<T>, IQueue<T> where T : class {
        public void Enqueue(T item) {
            Prepend(item);
        }

        public T Dequeue() {
            return RemoveLast();
        }
    }
}
