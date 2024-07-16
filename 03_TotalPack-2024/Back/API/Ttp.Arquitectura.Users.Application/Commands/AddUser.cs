using Mapster;
using Ttp.Arquitectura.Users.Application.Models;
using Ttp.Arquitectura.Users.Domain;
using Ttp.Arquitectura.Users.Domain.Interfaces.Repository;

namespace Ttp.Arquitectura.Users.Application.Commands
{
    public class AddUserHandler
    {
        private readonly IGenericRepository<User> _userRepository;

        public AddUserHandler(IGenericRepository<User> userRepository)
        {
            _userRepository = userRepository;
        }

        public void Handle(AddUserCommand command)
        {
            var user = command.Adapt<User>();
            _userRepository.Insert(user);
            _userRepository.Save();
        }
    }
}