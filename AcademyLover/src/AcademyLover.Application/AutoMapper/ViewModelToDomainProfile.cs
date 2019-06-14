using AcademyLover.Domain.AggregateModels.UserAgg;
using AcademyLover.Models.ViewModels;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace AcademyLover.Application.AutoMapper
{
    public class ViewModelToDomainProfile : Profile
    {
        public ViewModelToDomainProfile()
        {
            CreateMap<UserViewModel, Person>();
        }
    }
}
