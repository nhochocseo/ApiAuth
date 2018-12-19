using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.Entities;

namespace WebApi.IServices
{
    public interface IUserService
    {
        UserToken Authenticate(string username, string password);
        List<Users> GetListUser();
    }
}
