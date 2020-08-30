using eRestoran.Model.Request;
using eRestoran.WebAPI.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eRestoran.WebAPI.Services
{
    public interface IUserService
    {
        List<Model.Visitor> Get(UserSearchRequest search);
        Model.Visitor Get(int userId);
        Model.Visitor Insert(UserInsertRequest request);
        Model.Visitor Update(int id, UserInsertRequest request);
        Model.User Authenticate(string username, string password);

    }
}
