using System;
using System.Collections.Generic;
using System.Text;

namespace AcademyLover.Models.ViewModels
{
    public class EventViewModel
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Date { get; set; }
        public string State { get; set; }
        public string Local { get; set; }
        public string Responsible { get; set; }
        public string Situation { get; set; }

        public List<ArticleViewModel> Articles { get; set; }

        //public ICollection<Article> Articles { get; set; }
        //public ICollection<EventPerson> Subscribers { get; set; }
        //public Cancellation Cancellation { get; set; }
    }
}
