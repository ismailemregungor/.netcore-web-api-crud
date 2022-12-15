using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using crudapi.Entities;
using crudapi.Models.Users;

namespace crudapi.Service
{
    public interface IUserService
    {
        IEnumerable<User> GetAll();
        User GetById(int id);
        void Create(CreateRequest model);
        void Update(int id, UpdateRequest model);
        void Delete(int id);
    }
}