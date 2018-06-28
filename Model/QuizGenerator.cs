using System;

namespace GeeksId.Quiz.Model
{
    public class QuizGenerator
    {

        public QuizGenerator(QuestionRepository questionRepository, QuizRepository quizRepository)
        {
            QuestionRepository = questionRepository;
            QuizRepository = quizRepository;
        }

        public QuestionRepository QuestionRepository { get; }
        public QuizRepository QuizRepository { get; }

        internal Quiz CreateNew()
        {
            var listOfQuestions = QuestionRepository.GetAll(); // get from repository

            var newQuiz = new Quiz(listOfQuestions);

            QuizRepository.Save(newQuiz);

            return newQuiz;
        }

        internal Quiz GetQuiz(Guid id)
        {
            return QuizRepository.Get(id);
        }
    }
}
