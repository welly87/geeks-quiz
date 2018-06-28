using System.Collections.Generic;

namespace GeeksId.Quiz.Controllers
{
    public class NewQuestionCommand
    {
        public string Title { get; set; }
        public string Body { get; set; }
        public List<string> Choices { get; set; }
        public int Answer { get; set; }
        public int Level { get; set; }
    }
}