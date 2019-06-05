using AcademyLover.Domain.Enums;
using AcademyLover.Domain.SharedKernel.Entities;

namespace AcademyLover.Domain.AggregateModels.ArticleAgg.Entities
{
    public class Evaluation : BaseEntity<Evaluation>
    {
        public int EventId { get; set; }
        public int ArticleId { get; set; }
        public int UserId { get; set; }
        public ArticleRate Rate{ get; set; }
    }
}
