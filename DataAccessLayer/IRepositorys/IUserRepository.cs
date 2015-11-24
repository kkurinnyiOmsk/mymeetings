using System;
using DataAccessLayer.Entitys;

namespace DataAccessLayer.IRepositorys
{
    public interface IUserRepository
    {
        ApplicationUser GetUserById(Guid id);

        OperationResult UpdateUserName(Guid id, string userName);
    }
}