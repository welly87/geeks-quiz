using System;

namespace GeeksId.Quiz.Controllers
{
    public class AnswerQuestionCommand
    {
        public Guid Id { get; set; }

        public int Answer { get; set; }
    }
}