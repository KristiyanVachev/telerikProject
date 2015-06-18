using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizArena.Models
{
    public class Category
    {  //private ICollection<Question> questions;

        //public Category()
        //{
        //    this.questions = new HashSet<Question>();
        //}
        public int Id { get; set; }
        public string Name { get; set; }

        //public virtual ICollection<Question> Questions
        //{ 
        //    get
        //    {
        //        return this.questions;
        //    }
        //    set
        //    {
        //        this.questions = value;
        //    }
        //}
    }
}
