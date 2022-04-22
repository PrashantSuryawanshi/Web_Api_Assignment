using Sample_Web_Api.Modal;
using Sample_Web_Api.RepositoriesContext;
using System.Collections.Generic;

namespace Sample_Web_Api.Service
{
    public class StudentService : IStudentServices
    {
        private readonly IStudentRepository _iStudentRepo;

        public StudentService(IStudentRepository iStudentRepo)
        {
            _iStudentRepo = iStudentRepo;
        }
        public int addStudents(Student student)
        {
            return _iStudentRepo.addStudents(student);
        }

        public int deleteStudents(int id)
        {
            return _iStudentRepo.deleteStudents(id);
        }

        public IEnumerable<Student> GetStudents()
        {
          return _iStudentRepo.GetStudents();
        }

        public int updateStudents(Student student)
        {
            return _iStudentRepo.updateStudents(student);
        }
    }
}
