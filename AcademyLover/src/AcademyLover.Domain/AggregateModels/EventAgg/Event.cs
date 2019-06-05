using AcademyLover.Domain.AggregateModels.ArticleAgg;
using AcademyLover.Domain.AggregateModels.UserAgg;
using AcademyLover.Domain.Enums;
using AcademyLover.Domain.SharedKernel.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AcademyLover.Domain.AggregateModels.EventAgg
{
    public class Event : BaseEntity<Event>
    {
        public Event()
        {
            Articles = new HashSet<Article>();
            Subscribers = new HashSet<Person>();
        }

        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public string State { get; set; }
        public string Local { get; set; }
        public string Responsible { get; set; }
        public EventSituation Situation { get; set; }

        public ICollection<Article> Articles { get; set; }
        public ICollection<Person> Subscribers { get; set; }

        public Dictionary<int, Article> GenarateRanking()
        {
            var result = new Dictionary<int, Article>();

            var sortedArticles = Articles
                .OrderByDescending(x => x.GetTotalRate())
                .ToArray();

            for (int i = 1; i < sortedArticles.Count(); i++)
            {
                result.Add(i, sortedArticles[i]);
            }

            return result;
        }
    }
}
