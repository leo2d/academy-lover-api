using AcademyLover.Domain.AggregateModels.ArticleAgg;
using AcademyLover.Domain.AggregateModels.ArticleAgg.Entities;
using AcademyLover.Domain.AggregateModels.EventAgg;
using AcademyLover.Domain.AggregateModels.EventAgg.Entities;
using AcademyLover.Domain.AggregateModels.UserAgg.Entities;
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
            Events = new HashSet<EventPerson>();
            Articles = new HashSet<Article>();
            Evaluations = new HashSet<Evaluation>();
            Tokens = new HashSet<Token>();
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
        public ICollection<Evaluation> Evaluations { get; set; }
        public ICollection<EventPerson> Events { get; set; }


        public ICollection<Token> Tokens { get; set; }
    }
}
