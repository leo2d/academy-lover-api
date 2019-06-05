using System;

namespace AcademyLover.Domain.SharedKernel.Filter
{
    public class EventFilter
    {
        public string State { get; set; }
        public int? Situation { get; set; }
        public DateTime? InitalDate { get; set; }
        public DateTime? FinalDate { get; set; }
    }
}
