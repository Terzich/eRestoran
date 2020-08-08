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
        public List<Model.User> Get (UserSearchRequest search)
        {
            var query = _context.User.AsQueryable();
            if(!string.IsNullOrWhiteSpace(search.Name))
            {
                query = query.Where(q => q.Name.StartsWith(search.Name));
            }
            if (!string.IsNullOrWhiteSpace(search.Surname))
            {
                query = query.Where(q => q.Surname.StartsWith(search.Surname));
            }

            var list = query.ToList();

            return _mapper.Map<List<Model.User>>(list);
        }

        public Model.User Get(int userId)
        {
            var entity = _context.User.Find(userId);
            
            return _mapper.Map<Model.User>(entity);
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

        public Model.User Update(int id, UserInsertRequest request)
        {
            var entity = _context.User.Find(id);
            _context.User.Attach(entity);
            _context.User.Update(entity);

            _mapper.Map(request, entity);

            _context.SaveChanges();

            return _mapper.Map<Model.User>(entity);
        }
    }
}
