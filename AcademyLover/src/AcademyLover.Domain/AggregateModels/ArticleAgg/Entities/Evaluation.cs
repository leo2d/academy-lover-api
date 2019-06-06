using AcademyLover.Domain.AggregateModels.EventAgg;
using AcademyLover.Domain.AggregateModels.UserAgg;
using AcademyLover.Domain.Enums;
using AcademyLover.Domain.SharedKernel.Entities;

namespace AcademyLover.Domain.AggregateModels.ArticleAgg.Entities
{
    public class Evaluation : BaseEntity<Evaluation>
    {
        //public int EventId { get; set; }
        public int ArticleId { get; set; }
        public int UserId { get; set; }
        public ArticleRate Rate{ get; set; }
        public string Comment { get; set; }

        public Article Article { get; set; }
        //public Event Event { get; set; }
        public Person Person { get; set; }
    }
}
