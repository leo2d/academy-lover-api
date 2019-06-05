using AcademyLover.Domain.Enums;

namespace AcademyLover.Domain.SharedKernel.Interfaces
{
    public interface IUser
    {
        string Password { get; set; }
        string Login { get; set; }
        UserProfile Profile { get; set; }
    }
}
