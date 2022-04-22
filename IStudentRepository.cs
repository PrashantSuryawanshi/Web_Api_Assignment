using Sample_Web_Api.Modal;
using System.Collections.Generic;

namespace Sample_Web_Api.RepositoriesContext
{
    public interface IStudentRepository
    {
        IEnumerable<Student> GetStudents();
        int addStudents(Student student);
        int updateStudents(Student student);    
        int deleteStudents(int id);
        
    }
    
}
