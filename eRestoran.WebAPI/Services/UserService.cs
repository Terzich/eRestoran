using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using eRestoran.Model;
using eRestoran.Model.Request;
using eRestoran.WebAPI.Database;

namespace eRestoran.WebAPI.Services
{
    public class UserService : IUserService
    {
        private readonly eRestoranContext _context;
        private readonly IMapper _mapper;

        public UserService(eRestoranContext context,IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public List<Model.User> Get ()
        {
            var list = _context.User.ToList();

            return _mapper.Map<List<Model.User>>(list);
        }

        public Model.User Insert(UserInsertRequest request)
        {
            var entity = _mapper.Map<Database.User>(request);
            entity.CityId = 1;
            entity.GenderId = 1;
            _context.Add(entity);
            _context.SaveChanges();

            return _mapper.Map<Model.User>(entity);

        }
    }
}
