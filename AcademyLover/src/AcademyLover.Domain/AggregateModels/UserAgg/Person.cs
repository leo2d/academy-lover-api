using AcademyLover.Domain.AggregateModels.ArticleAgg;
using AcademyLover.Domain.AggregateModels.EventAgg;
using AcademyLover.Domain.Enums;
using AcademyLover.Domain.SharedKernel.Entities;
using AcademyLover.Domain.SharedKernel.Interfaces;
using System;
using System.Collections.Generic;

namespace AcademyLover.Domain.AggregateModels.UserAgg
{
    public class Person : BaseEntity<Person>, IUser
    {
        public Person()
        {
           // Events = new HashSet<Event>();
            Articles = new HashSet<Article>();
        }

        public string Password { get; set; }
        public string Login { get; set; }
        public UserProfile Profile { get; set; }

        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public string Nationality { get; set; }
        public string Adress { get; set; }
        public string School { get; set; }

        public ICollection<Article> Articles { get; set; }
        //public ICollection<Event> Events { get; set; }
    }
}
