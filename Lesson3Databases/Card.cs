using ServiceStack.DataAnnotations;

namespace Lesson3Databases {
    public class Card {
        [AutoIncrement]
        public int Id { get; set; }

        public string Title { get; set; }
        public string Type { get; set; }
        public int? Power { get; set; }
        public int? Toughness { get; set; }
        public string Body { get; set; }
    }
}
