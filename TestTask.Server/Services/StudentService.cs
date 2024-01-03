using TestTask.Server.Entities;

namespace TestTask.Server.Services
{
    public class StudentService : IOperations<Student>
    {
        public StudentService(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        private AppDbContext _appDbContext;

        public void Create(Student item)
        {
            this._appDbContext.Students.Add(item);
            this._appDbContext.SaveChanges();
        }

        public Student Get(int id)
        {
            return this._appDbContext.Students.SingleOrDefault(s => s.Id == id);
        }

        public ICollection<Student> GetAll()
        {
            return this._appDbContext.Students.ToList<Student>();
        }

        public Student Update(Student item)
        {
            Student StudentToUpdate = this._appDbContext.Students.Find(item.Id);
            if (StudentToUpdate != null)
            {
                StudentToUpdate.StudentFirstName = item.StudentFirstName;
                StudentToUpdate.StudentLastName = item.StudentLastName;
                this._appDbContext.SaveChanges();
            }
            return StudentToUpdate;
        }

        public void Delete(int id)
        {
            Student StudentToDelete = this._appDbContext.Students.Find(id);
            if (StudentToDelete != null)
            {
                this._appDbContext.Remove(StudentToDelete);
                this._appDbContext.SaveChanges();
            }
        }
    }
}
