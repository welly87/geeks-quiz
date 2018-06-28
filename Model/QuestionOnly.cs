using System.Collections.Generic;

namespace GeeksId.Quiz.Model
{
    public class QuestionOnly
    {
        public string Title { get; set; }
        public string Body { get; set; }
        public List<string> Choices { get; set; }
    }
}
