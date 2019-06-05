using AcademyLover.Domain.AggregateModels.ArticleAgg.Entities;
using AcademyLover.Domain.AggregateModels.EventAgg;
using AcademyLover.Domain.AggregateModels.UserAgg;
using AcademyLover.Domain.SharedKernel.Entities;
using System.Collections.Generic;
using System.Linq;

namespace AcademyLover.Domain.AggregateModels.ArticleAgg
{
    public class Article : BaseEntity<Article>
    {
        public Article()
        {
            Evaluations = new HashSet<Evaluation>();
        }

        public string Title { get; set; }
        public string Description { get; set; }
        public string Authors { get; set; }

        public int PersonId { get; set; }
        public Person Student { get; set; }

        public int EventId { get; set; }
        public Event Event { get; set; }

        public ICollection<Evaluation> Evaluations { get; set; }

        public int GetTotalRate()
        {
            return Evaluations.Sum(x => (int)x.Rate);
        }

        public int GetRankingPosition()
        {
            var position = Event.GenarateRanking()
                .FirstOrDefault(x => x.Value.Id == Id)
                .Key;

            return position;
        }
    }
}
