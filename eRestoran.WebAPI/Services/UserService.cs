using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using eRestoran.Model;
using eRestoran.Model.Request;
using eRestoran.WebAPI.Database;
using Microsoft.EntityFrameworkCore;

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

        public static string GenerateSalt()
        {
            var buf = new byte[16];
            (new RNGCryptoServiceProvider()).GetBytes(buf);
            return Convert.ToBase64String(buf);
        }

        public static string GenerateHash(string salt, string password)
        {
            byte[] src = Convert.FromBase64String(salt);
            byte[] bytes = Encoding.Unicode.GetBytes(password);
            byte[] dst = new byte[src.Length + bytes.Length];

            System.Buffer.BlockCopy(src, 0, dst, 0, src.Length);
            System.Buffer.BlockCopy(bytes, 0, dst, src.Length, bytes.Length);

            HashAlgorithm algorithm = HashAlgorithm.Create("SHA1");
            byte[] inArray = algorithm.ComputeHash(dst);
            return Convert.ToBase64String(inArray);
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
            if(request.Password!=request.ConfirmationPassword)
            {
                throw new Exception("Lozinke se ne podudaraju!");
            }
            entity.CityId = 1;
            entity.GenderId = 1;
            entity.PasswordSalt = GenerateSalt();
            entity.PasswordHash = GenerateHash(entity.PasswordSalt, request.Password);
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

        public Model.User Authenticate(string username, string password)
        {
            var user = _context.User.Include("UserRole.Role").FirstOrDefault(u => u.Username == username);
            if(user!=null)
            {
                var newHash = GenerateHash(user.PasswordSalt, password);
                if (newHash == user.PasswordHash)
                {
                    
                    Model.User rt= _mapper.Map<Model.User>(user);
                    return rt;
                }

            }
            return null;
        }
    }
}
