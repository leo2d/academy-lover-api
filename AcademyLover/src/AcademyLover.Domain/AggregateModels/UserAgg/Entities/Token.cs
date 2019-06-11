using AcademyLover.Domain.SharedKernel.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace AcademyLover.Domain.AggregateModels.UserAgg.Entities
{
    public class Token : BaseEntity<Token>
    {
        public string Value { get; set; }
        public DateTime LoginDate { get; set; }
        public DateTime ExpirationDate { get; set; }
        public int UserId { get; set; }

        public Person User { get; set; }

        public static Token Generate(Person user)
        {
            return new Token()
            {
                LoginDate = DateTime.Now,
                ExpirationDate = DateTime.Now.AddHours(2),
                Value = Guid.NewGuid().ToString(),
                UserId = user.Id,
                User = user
            };
        }
    }
}
