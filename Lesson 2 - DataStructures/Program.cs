using System;

namespace Lesson2DataStructures {
    class Program {
        static void Main(string[] args) {
            var list = new LinkedList<Deck>();
            list.Add(new Deck(1, "Control Deck"));
            list.Add(new Deck(2, "Sweet Burn Deck"));
            list.Add(new Deck(3, "White Weenie"));
            list.Add(new Deck(4, "Green Stompy"));
            list.Add(new Deck(5, "Ernam Burn'em"));
            list.Add(new Deck(6, "Another"));
            
            var currentNode = list.GetFirst();
            while (true) {
                Console.WriteLine(currentNode);
                if (currentNode.Next == null)
                    break;
                currentNode = currentNode.Next; // moves to the next item in the list
            }

            currentNode = list.GetLast();
            while (true) {
                Console.WriteLine(currentNode);
                if (currentNode.Prev == null)
                    break;
                currentNode = currentNode.Prev; // moves to the prev item in the list
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
