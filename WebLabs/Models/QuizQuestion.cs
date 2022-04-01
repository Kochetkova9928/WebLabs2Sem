using System;
using System.ComponentModel.DataAnnotations;

namespace WebLabs.Models
{
    public class QuizQuestion
    {
        public string Question { get; set; }
        public int CorrectAns { get; set; }

        public bool LastQuestion { get; set; }

        [Required]
        public int UserAns { get; set; }

        public QuizQuestion()
        {
            var rand = new Random();
            var first = rand.Next() % 11;
            var second = rand.Next() % 11;
            var operation = (Operation)(rand.Next() % 2);
            
            Question = operation switch
            {
                Operation.Plus => $"{first} + {second} =",
                Operation.Minus => $"{first} - {second} =",
                _ => string.Empty
            };

            CorrectAns = operation switch
            {
                Operation.Plus => first + second,
                Operation.Minus => first - second,
                _ => 0
            };

            UserAns = 0;

            LastQuestion = false;
        }
    }
}
