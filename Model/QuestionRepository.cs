using System;
using System.Collections.Generic;

namespace GeeksId.Quiz.Model
{
    public class QuestionRepository
    {
        private IList<Question> questions = new List<Question>();
        internal IList<Question> GetAll()
        {
            return questions;
        }

        internal void Save(Question soal)
        {
            questions.Add(soal);
        }
    }
}