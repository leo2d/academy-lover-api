using System;
using System.Collections.Generic;
using System.Text;

namespace AcademyLover.Models.ViewModels
{
    public class ArticleViewModel
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Authors { get; set; }

        public int StudentId { get; set; }
        public string Student { get; set; }

        public int EventId { get; set; }
        public string Event { get; set; }

        public List<EvaluationViewModel> Evaluations { get; set; }
    }
}
