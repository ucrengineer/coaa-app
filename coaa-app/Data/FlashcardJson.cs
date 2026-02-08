using System.Collections.Generic;

namespace coaa_app.Data
{
    public class FlashcardJson
    {
        public List<FlashcardActivityJson> Flashcards { get; set; }
    }

    public class FlashcardActivityJson
    {
        public string Activity { get; set; }
        public List<FlashcardJsonItem> Cards { get; set; }
    }

    public class FlashcardJsonItem
    {
        public string Question { get; set; }
        public string Answer { get; set; }
        public string Term { get; set; }
        public string Definition { get; set; }
        public string Details { get; set; }
        public List<string> Tags { get; set; }
    }
}
