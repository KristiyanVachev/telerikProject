using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizArena.Models
{
    public class Question
    {
        private ICollection<Answer> inCorrectAnswer;
        public Question()
        {
            this.inCorrectAnswer = new HashSet<Answer>();
        }

        public int Id { get; set; }

        public string Condition { get; set; }

        public Answer CorrectAnswer { get; set; }

        public virtual ICollection<Answer> InCorrectAnswers
        {
            get
            {
                return this.inCorrectAnswer;
            }
            set
            {
                this.inCorrectAnswer = value;
            }
        }

        public string Description { get; set; }

        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }

        //statistics for every question
        public int CorrectAnswersCount { get; set; }
        public int IncorrectAnswerCount { get; set; }

        //TO-DO - Category (dictionary, hash...)
    }
}
