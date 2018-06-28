using System;
using System.Collections.Generic;

namespace GeeksId.Quiz.Model
{
    public class QuizRepository
    {
        private IDictionary<Guid, Quiz> _quizes = new Dictionary<Guid, Quiz>();

        internal void Save(Quiz newQuiz)
        {
            _quizes.Add(newQuiz.Id, newQuiz);
        }

        internal Quiz Get(Guid id)
        {
            return _quizes[id];
        }
    }
}