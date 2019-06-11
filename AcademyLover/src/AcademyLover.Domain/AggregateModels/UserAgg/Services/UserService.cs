using AcademyLover.Domain.AggregateModels.UserAgg.Entities;
using AcademyLover.Domain.AggregateModels.UserAgg.Interfaces;
using AcademyLover.Domain.AggregateModels.UserAgg.Interfaces.Repositories;
using AcademyLover.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AcademyLover.Domain.AggregateModels.UserAgg.Services
{
    public class UserService : IUserService
    {
        private readonly IPersonRepository _personRepository;
        public UserService(IPersonRepository personRepository)
        {
            _personRepository = personRepository;
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
