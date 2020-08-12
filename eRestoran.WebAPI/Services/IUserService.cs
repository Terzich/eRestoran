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
        List<Model.User> Get(UserSearchRequest search);
        Model.User Get(int userId);
        Model.User Insert(UserInsertRequest request);
        Model.User Update(int id, UserInsertRequest request);
        Model.User Authenticate(string username, string password);

    }
}
