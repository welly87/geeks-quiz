using System;
using System.Collections.Generic;
using GeeksId.Quiz.Model;
using Microsoft.AspNetCore.Mvc;

namespace GeeksId.Quiz.Controllers
{
    [Route("api/[controller]")]
    public class QuestionController : Controller
    {
        public QuestionController(QuestionRepository questionRepository)
        {
            QuestionRepository = questionRepository;
        }

        public QuestionRepository QuestionRepository { get; }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]NewQuestionCommand value)
        {
            var soal = new Question
            {
                Id = Guid.NewGuid(), 
                Body = value.Body, 
                Choices = value.Choices, 
                Answer = value.Answer, 
                Level = value.Level, 
                Title = value.Title
            };

            QuestionRepository.Save(soal);
        }

        [HttpGet]
        public IList<Question> Get()
        {
            return QuestionRepository.GetAll();
        }
    }
}
