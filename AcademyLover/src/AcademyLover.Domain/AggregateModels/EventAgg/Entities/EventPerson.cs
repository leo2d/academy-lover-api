using AcademyLover.Domain.AggregateModels.UserAgg;
using AcademyLover.Domain.SharedKernel.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace AcademyLover.Domain.AggregateModels.EventAgg.Entities
{
    public class EventPerson : BaseEntity<EventPerson>
    {
        public int EventId { get; set; }
        public int UserId { get; set; }
        public DateTime SubscribeDate { get; set; }

        public Event Event { get; set; }
        public Person Person { get; set; }
    }
}
