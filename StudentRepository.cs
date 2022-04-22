using Sample_Web_Api.DB;
using Sample_Web_Api.Modal;
using System.Collections.Generic;
using System.Linq;

namespace Sample_Web_Api.RepositoriesContext
{
    public class StudentRepository : IStudentRepository
    {
        DBStudent studentcontext;
        public StudentRepository(DBStudent db)
        {
            studentcontext = db; 
        }
        public int addStudents(Student student)
        {
            studentcontext.students.Add(student);
            studentcontext.SaveChanges();
            return 1;
        }

        public int deleteStudents(int id)
        {
            var stud = studentcontext.students.Where(stud => stud.Id == id).SingleOrDefault();
            
            if (stud != null)
            {
               studentcontext.students.Remove(stud);
               studentcontext.SaveChanges();
                return 1;
            }
            else
            {
                return 0;
            }
        }

        public IEnumerable<Student> GetStudents()
        {
            return studentcontext.students.ToList();
        }

        public int updateStudents(Student student)
        {
            var sudent = studentcontext.students.Where(p => p.Id == student.Id).SingleOrDefault();
            if (student != null)
            {
                student.Name = student.Name;
                student.CorseName = student.CorseName;
                studentcontext.SaveChanges();
                return 1;
            }
            else
            {
                return 0;
            }
        }
    }
}
