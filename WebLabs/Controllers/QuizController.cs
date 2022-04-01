using Microsoft.AspNetCore.Mvc;
using System;
using WebLabs.Models;

namespace WebLabs.Controllers
{
    public class QuizController : Controller
    {
        private static Quiz quiz = new Quiz();
        private static QuizQuestion curQuizQuestion;

        [HttpGet]
        public IActionResult Game()
        {
            quiz = new Quiz();
            curQuizQuestion = new QuizQuestion();

            return View(curQuizQuestion);
        }

        [HttpPost]
        public IActionResult Game(QuizQuestion quizQuestion)
        {
            curQuizQuestion.UserAns = quizQuestion.UserAns;
            quiz.QuizQuestion.Add(curQuizQuestion);

            if (quizQuestion.LastQuestion)
            {
                return RedirectToAction("Result");
            }
            else
            {
                curQuizQuestion = new QuizQuestion();
                return View(curQuizQuestion);
            }
            
        }

        [HttpGet]
        public IActionResult Result()
        {
            return View(quiz);
        }

    }
}
