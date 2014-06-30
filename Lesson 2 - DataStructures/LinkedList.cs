
namespace Lesson2DataStructures {
    class ListNode<T> {
        public ListNode(T data) {
            Data = data;
        }

        public T Data;
        public ListNode<T> Next;
        public ListNode<T> Prev;

        public override string ToString() {
            return Data != null
                ? Data.ToString()
                : null;
        }
    }

    class LinkedList<T> {
        ListNode<T> _first = null;
        ListNode<T> _last = null;

        public void Add(T item) {
            var node = new ListNode<T>(item);
            if (_first == null) { 
                // first node in the list, no other nodes to link to
                _first = node;
                _last = node;
            } else { 
                // for all other nodes in the list, we have to link them up to the last node
                _last.Next = node;
                node.Prev = _last;
                _last = node;
            }
        }

        public ListNode<T> GetLast() {
            return _last;
        }

        public ListNode<T> GetFirst() {
            return _first;
        }
    }
}
