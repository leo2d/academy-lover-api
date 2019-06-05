using AcademyLover.Domain.SharedKernel.Entities;
using System;

namespace AcademyLover.Domain.AggregateModels.EventAgg.Entities
{
    public class Cancellation : BaseEntity<Cancellation>
    {
        public DateTime CancellationDate { get; set; }
        public string Reason { get; set; }
        public int EventId { get; set; }

        public Event Event { get; set; }
    }
}
