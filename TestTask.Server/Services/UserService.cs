using TestTask.Server.Entities;

namespace TestTask.Server.Services
{
    public class UserService : IOperations<User>
    {
        public UserService(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        private AppDbContext _appDbContext;

        public bool SuccessfulLogin(User item)
        {
            User UserToLogin = this._appDbContext.Users.Single(u => u.UserLogin == item.UserLogin);
            if (UserToLogin != null)
            {
                return UserToLogin.UserPassword == item.UserPassword ? true : false;
            }
            return false;
        }

        public void Create(User item)
        {
            this._appDbContext.Users.Add(item);
            this._appDbContext.SaveChanges();
        }

        public User Get(int id)
        {
            return this._appDbContext.Users.SingleOrDefault(u => u.Id == id);
        }

        public ICollection<User> GetAll()
        {
            return this._appDbContext.Users.ToList<User>();
        }

        public User Update(User item)
        {
            User UserToUpdate = this._appDbContext.Users.Find(item.Id);
            if (UserToUpdate != null)
            {
                UserToUpdate.UserLogin = item.UserLogin;
                UserToUpdate.UserPassword = item.UserPassword;
                this._appDbContext.SaveChanges();
            }
            return UserToUpdate;
        }

        public void Delete(int id)
        {
            User UserToDelete = this._appDbContext.Users.Find(id);
            if (UserToDelete != null)
            {
                this._appDbContext.Remove(UserToDelete);
                this._appDbContext.SaveChanges();
            }
        }
    }
}
