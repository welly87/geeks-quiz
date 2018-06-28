using System;
using System.Collections.Generic;

namespace GeeksId.Quiz.Model
{
    public class Question
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        public List<string> Choices { get; set; }
        public int Answer { get; set; }
        public int Level { get; set; }
    }
}