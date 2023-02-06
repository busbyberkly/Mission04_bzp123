using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Mission04_bzp123.Models
{
    public class GradecalculatorModel
    {
        [Required(ErrorMessage ="a value in Assignments is required to calculate a grade.")]
        [Range(0,100,ErrorMessage ="Assignments grade value must be between 0 and 100.")]
        public double Assignments { get; set; }

        [Required(ErrorMessage = "a value in Group Projects is required to calculate a grade.")]
        [Range(0, 100, ErrorMessage = "Group Projects grade value must be between 0 and 100.")]
        public double GroupProjects { get; set; }

        [Required(ErrorMessage = "a value in Quizzes is required to calculate a grade.")]
        [Range(0, 100, ErrorMessage = "Quizzes grade value must be between 0 and 100.")]
        public double Quizzes { get; set; }

        [Required(ErrorMessage = "a value in Midterm is required to calculate a grade.")]
        [Range(0, 100, ErrorMessage = "Midterm grade value must be between 0 and 100.")]
        public double MidtermExam { get; set; }
        
        [Required(ErrorMessage = "a value in Final is required to calculate a grade.")]
        [Range(0, 100, ErrorMessage = "Final grade value must be between 0 and 100.")]
        public double FinalExam { get; set; }
        
        [Required(ErrorMessage = "a value in INTEX is required to calculate a grade.")]
        [Range(0, 100, ErrorMessage = "INTEX grade value must be between 0 and 100.")]
        public double INTEX { get; set; }
    }
}
