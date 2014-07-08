using System;

namespace Lesson2DataStructures {
    class Program {
        static void Main(string[] args) {
            //var list = new LinkedList<Deck>();
            //list.Add(new Deck(1, "Control Deck"));
            //list.Add(new Deck(2, "Sweet Burn Deck"));
            //list.Add(new Deck(3, "White Weenie"));
            //list.Add(new Deck(4, "Green Stompy"));
            //list.Add(new Deck(5, "Ernam Burn'em"));
            //list.Add(new Deck(6, "Another"));

            //foreach (var node in list) {
            //    Console.WriteLine(node);
            //}

            //var queue = new Queue<Deck>();
            //queue.Enqueue(new Deck(1, "Control Deck"));
            //queue.Enqueue(new Deck(2, "Sweet Burn Deck"));
            //queue.Enqueue(new Deck(3, "White Weenie"));
            //queue.Enqueue(new Deck(4, "Green Stompy"));
            //queue.Enqueue(new Deck(5, "Ernam Burn'em"));
            //queue.Enqueue(new Deck(6, "Another"));

            //var firstOut = queue.Dequeue();
            //Console.WriteLine("First out = " + firstOut);

            //Console.WriteLine("Current state:");
            //foreach (var node in queue) {
            //    Console.WriteLine(node);
            //}

            //Console.WriteLine("Next out = " + queue.Dequeue());

            //queue.Enqueue(new Deck(10, "A latecomer"));

            //Console.WriteLine("Current state:");
            //foreach (var node in queue) {
            //    Console.WriteLine(node);
            //}

            var stack = new Stack<Deck>();
            stack.Push(new Deck(1, "Control Deck"));
            stack.Push(new Deck(2, "Sweet Burn Deck"));
            stack.Push(new Deck(3, "White Weenie"));
            stack.Push(new Deck(4, "Green Stompy"));
            stack.Push(new Deck(5, "Ernam Burn'em"));
            stack.Push(new Deck(6, "Another"));

            Console.WriteLine("The STACK:");
            foreach (var node in stack) {
                Console.WriteLine(node);
            }

            Console.WriteLine("It's poppin' off = " + stack.Pop());
            Console.WriteLine("It's poppin' off = " + stack.Pop());

            Console.WriteLine("reSTACKED:");
            foreach (var node in stack) {
                Console.WriteLine(node);
            }
            
            Console.Read();
        }
    }

    class Deck {
        public string Title;
        public int Id;

        public Deck(int id, string title) {
            Id = id;
            Title = title;
        }

        public override string ToString() {
            return string.Format("{0}: {1}", Id, Title);
        }
    }

    class Card {
        
    }
}
