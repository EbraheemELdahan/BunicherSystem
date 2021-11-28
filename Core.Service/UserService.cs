using Core.Data;
using Core.Model.Models;

using System.Linq;


namespace Core.Service
{
    public class UserService : IService<User>,IUserService
    {
        private readonly IRepositoryWrapper _repowrapper;

        public UserService(IRepositoryWrapper repowrapper)
        {
            _repowrapper = repowrapper;
        }
        public void Add(User entity)
        {
            _repowrapper.UserRepository.Add(entity);
        }

        public void Delete(User entity)
        {
            _repowrapper.UserRepository.Delete(entity);
        }

        public IQueryable<User> GetAll()
        {
            return _repowrapper.UserRepository.GetAll();
        }

        public User GetById(int id)
        {
          return  _repowrapper.UserRepository.GetById(id);
        }

        public void SaveChanges()
        {
            _repowrapper.UserRepository.Commit();
        }

        public void Update(User entity)
        {
            _repowrapper.UserRepository.Update(entity);   
        }
    }
    public interface IUserService:IService<User>
    {

    }
}
