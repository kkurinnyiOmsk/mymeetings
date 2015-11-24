using System;
using DataAccessLayer.Entitys;
using DataAccessLayer.IRepositorys;

namespace DataAccessLayer.Repositorys
{
    public class UserRepository : IUserRepository
    {
        public ApplicationUser GetUserById(Guid id)
        {
            ApplicationUser user = null;
            using (var db = new MeetingContext())
            {
                
            }

            return user;
        }

        public OperationResult UpdateUserName(Guid id, string userName)
        {
            throw new NotImplementedException();
        }

    }
}