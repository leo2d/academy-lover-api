using System;
using System.Collections.Generic;
using System.Text;

namespace AcademyLover.Models.ViewModels
{
    public class EvaluationViewModel
    {
        public int ArticleId { get; set; }
        public int UserId { get; set; }
        public int Rate { get; set; }
        public string Comment { get; set; }

        public string User { get; set; }
    }
}
