using AcademyLover.Domain.AggregateModels.UserAgg.Entities;
using AcademyLover.Models.ViewModels;
using System.Threading.Tasks;

namespace AcademyLover.Application.Interfaces
{
    public interface IUserAppService
    {
        Task<Token> DoLogin(LoginViewModel loginViewModel);
        Task DoLogout(string token);

        Task CreateNewUser(UserViewModel userViewModel);

    }
}
