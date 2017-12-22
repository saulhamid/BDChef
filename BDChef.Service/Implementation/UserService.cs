using System.Linq;
using BDChef.Data;
using BDChef.Domain;
using BDChef.Domain.Data;
using System;

namespace BDChef.Service
{
   public  class UserService : IUserService
    {
       private IRepository<User> userRepository;
       private IRepository<UserProfile> userProfileRepository;
       public UserService(IRepository<User> userRepository, IRepository<UserProfile> userProfileRepository)
       {
           this.userRepository = userRepository;
           this.userProfileRepository = userProfileRepository;
       }
       public IQueryable<User> GetUsers()
       {
            try
            {
                return userRepository.Table;
            }
            catch (Exception ex)
            {

                throw ex;
            }
       }
       public User GetUser(long id)
       {
            try
            {
                return userRepository.GetById(id);
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally {

            }
       }
       public void InsertUser(User user)
       {
           userRepository.Insert(user);
       }

       public void UpdateUser(User user)
       {
           userRepository.Update(user);
       }

       public void DeleteUser(User user)
       {
           //userProfileRepository.Delete(user.UserProfile);
           userRepository.Delete(user);
       }
    }
}
