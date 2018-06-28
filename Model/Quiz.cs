using System;
using System.Collections.Generic;

namespace GeeksId.Quiz.Model
{
    public class Quiz
    {
        // TODO will store the detail about the exam, score etc. 

        private IList<Question> listOfQuestions;
        public Guid Id { get; set; }
        public Question CurrentQuestion { get { return listOfQuestions[_currentQuestionIndex]; } }

        public QuestionOnly CurrentQuestionOnly
        {
            get
            {
                var question = CurrentQuestion;
                return new QuestionOnly { Title = question.Title, Body = question.Body, Choices = question.Choices };
            }
        }

        private int _currentQuestionIndex = 0;

        public Quiz(IList<Question> listOfQuestions)
        {
            this.listOfQuestions = listOfQuestions;

            Id = Guid.NewGuid();
        }

        internal void NextQuestion()
        {
            _currentQuestionIndex++;
        }

        internal bool Answer(int answer)
        {
            return CurrentQuestion.Answer == answer;
        }
    }
}
