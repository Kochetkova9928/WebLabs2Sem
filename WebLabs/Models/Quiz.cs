using System.Collections.Generic;

namespace WebLabs.Models
{
    public class Quiz
    {
        public IList<QuizQuestion> QuizQuestion { get; set; }

        public Quiz()
        {
            QuizQuestion = new List<QuizQuestion>();
        }
    }
}
