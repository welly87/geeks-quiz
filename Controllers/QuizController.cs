using System;
using GeeksId.Quiz.Model;
using GeeksId.Quiz.Models;
using Microsoft.AspNetCore.Mvc;

namespace GeeksId.Quiz.Controllers
{
    [Route("api/[controller]/[action]")]
    public class QuizController : Controller
    {
        public QuizController(QuizGenerator quiz)
        {
            QuizGenerator = quiz;
        }

        public QuizGenerator QuizGenerator { get; }

        // POST api/values
        [HttpPost]
        [ActionName("newquiz")]
        public Guid Post([FromBody]NewQuizCommand value)
        {
            var quiz = QuizGenerator.CreateNew();

            return quiz.Id;
        }

        [HttpPost]
        [ActionName("nextquest")]
        public QuestionOnly Post([FromBody]NextQuestionCommand next)
        {
            var quiz = QuizGenerator.GetQuiz(next.Id);

            quiz.NextQuestion();

            return quiz.CurrentQuestionOnly;
        }

        [HttpPost]
        [ActionName("answer")]
        public bool Post([FromBody]AnswerQuestionCommand next)
        {
            var quiz = QuizGenerator.GetQuiz(next.Id);

            return quiz.Answer(next.Answer);
        }

    }
}
