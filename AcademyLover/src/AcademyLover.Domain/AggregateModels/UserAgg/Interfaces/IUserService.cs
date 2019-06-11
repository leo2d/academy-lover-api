using AcademyLover.Domain.AggregateModels.UserAgg.Entities;
using AcademyLover.Models.ViewModels;
using System.Threading.Tasks;

namespace AcademyLover.Domain.AggregateModels.UserAgg.Interfaces
{
    public interface IUserService
    {
        Task<Token> DoLogin(LoginViewModel loginViewModel);
        Task DoLogout(string token);

    }
}
