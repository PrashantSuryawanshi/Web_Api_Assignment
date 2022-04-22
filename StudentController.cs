using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Sample_Web_Api.RepositoriesContext;
using Sample_Web_Api.Service;

namespace Sample_Web_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IStudentServices _iStudentService;

       
        public StudentController(IStudentServices studentService)
        {
            _iStudentService = studentService;
        }
    }
}
