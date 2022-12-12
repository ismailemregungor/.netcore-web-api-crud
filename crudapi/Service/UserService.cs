using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using crudapi.Entities;
using crudapi.Helpers;
using crudapi.Models.Users;

namespace crudapi.Service
{
    public class UserService : IUserService
    {
        private DataContext _context;
        private readonly IMapper _mapper;

        public UserService(DataContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public IEnumerable<User> GetAll()
        {
            return _context.Users;
        }

        public User GetById(int id)
        {
            return _context.Users?.Find(id);
        }

        public User Create(CreateRequest model)
        {
            var user = _mapper.Map<User>(model);

            _context.Users.Add(user);
            _context.SaveChanges();

            return user;
        }

        void IUserService.Create(CreateRequest model)
        {
            throw new NotImplementedException();
        }
    }
}