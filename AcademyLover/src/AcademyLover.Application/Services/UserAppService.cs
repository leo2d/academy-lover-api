using AcademyLover.Application.Interfaces;
using AcademyLover.Domain.AggregateModels.UserAgg;
using AcademyLover.Domain.AggregateModels.UserAgg.Entities;
using AcademyLover.Domain.AggregateModels.UserAgg.Interfaces.Repositories;
using AcademyLover.Models.ViewModels;
using AutoMapper;
using System;
using System.Threading.Tasks;

namespace AcademyLover.Application.Services
{
    public class UserAppService : IUserAppService
    {
        private readonly IMapper _mapper;
        private readonly IPersonRepository _personRepository;
        public UserAppService(IPersonRepository personRepository, IMapper mapper)
        {
            _personRepository = personRepository;
            _mapper = mapper;
        }

        public async Task CreateNewUser(UserViewModel userViewModel)
        {
            try
            {
                var user = _mapper.Map<Person>(userViewModel);

                await _personRepository.Create(user);
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public async Task<Token> DoLogin(LoginViewModel loginViewModel)
        {
            try
            {
                //var user = new Person() { Name="teste" , Login = "teste", Password = "teste", Profile = Enums.UserProfile.SIMPLE };

                var user = await _personRepository.GetByLogin(loginViewModel.Login, loginViewModel.Password);

                if (null != user)
                {
                    var token = Token.Generate(user);

                    user.Tokens.Add(token);
                    await _personRepository.Update(user);

                    return token;
                }

                return null;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public async Task DoLogout(string token)
        {
            try
            {
                var tokenDb = await _personRepository.GetValidToken(token);

                if (null != token)
                {
                    await _personRepository.DeleteToken(tokenDb);
                }
            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}
