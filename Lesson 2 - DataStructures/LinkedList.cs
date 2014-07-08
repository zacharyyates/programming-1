using System;
using System.Collections;
using System.Collections.Generic;

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

    abstract class LinkedListBase<T> : IEnumerable<T> where T : class 
    {
        ListNode<T> _first = null;
        ListNode<T> _last = null;

        /// <summary>
        /// Inserts a node at the end of the list
        /// </summary>
        protected void Append(T item) {
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

        /// <summary>
        /// Inserts a node a the beginning of the list
        /// </summary>
        protected void Prepend(T item) {
            var node = new ListNode<T>(item);
            if (_last == null) {
                // there are no nodes in the list, insert this one
                _first = node;
                _last = node;
            } else {
                // add this node to the beginning
                _first.Prev = node;
                node.Next = _first;
                _first = node;
            }
        }

        protected T RemoveLast() {
            if (_last != null) {
                var node = _last;
                // only unlink the pointers if we are not at the first node in the list
                if (node.Prev != null) {
                    _last = node.Prev;
                    _last.Next = null;
                    node.Prev = null;
                    return node.Data;
                } else {
                    return null;
                }
            }

            throw new InvalidOperationException("There are no items in the list.");
        }

        public IEnumerator<T> GetEnumerator() {
            return new LinkedListForwardEnumerator<T>(_first);
        }

        IEnumerator IEnumerable.GetEnumerator() {
            return new LinkedListForwardEnumerator<T>(_first);
        }
    }

    class LinkedListForwardEnumerator<T> : IEnumerator<T> {
        ListNode<T> _current;
        ListNode<T> _first;

        public LinkedListForwardEnumerator(ListNode<T> first) {
            _current = null;
            _first = first;
        }

        public T Current {
            get { return _current.Data; }
        }

        object IEnumerator.Current {
            get { return _current.Data; }
        }

        public bool MoveNext() {
            // priming read
            if (_current == null && _first != null) {
                _current = _first;
                return true;
            }
            // rest of the loop
            if (_current.Next != null) {
                _current = _current.Next;
                return true;
                // end of the loop
            } else {
                return false;
            }
        }

        public void Reset() {
            _current = _first;
        }

        public void Dispose() {
            _current = null;
            _first = null;
        }
    }

    class LinkedList<T> : LinkedListBase<T> where T : class {
        public void Add(T item) {
            Append(item);
        }
    }
}
