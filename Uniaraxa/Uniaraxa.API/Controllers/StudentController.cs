using Microsoft.AspNetCore.Mvc;
using Uniaraxa.Domain.Entities;
using Uniaraxa.Service.Services;

namespace Uniaraxa.API.Controllers
{
    public class StudentController : ControllerBase
    {
        private readonly IStudentservice _studentservice;

        public StudentController(IStudentservice studentservice)
        {
            _studentservice = studentservice;
        }

        [HttpPost]
        [Route("Api/student")]
        public IActionResult AddStudent([FromBody] StudentService student)
        {
            _studentservice.AddStudent(student);
            return Ok("Student cadastrado com sucesso");
        }

        [HttpGet]
        [Route("Api/student/{id}")]
        public IActionResult GetById(int id) {
            var resultado= _studentservice.GetStudentById(id);

            if(resultado==null) 
                return NotFound("Student não encontrado!");
            
            return Ok(resultado);

        }

        [HttpGet]
        [Route("Api/student")]
        public IActionResult GetByAll()
        {
            var resultado = _studentservice.GetAllStudents();

            if (resultado == null)
                return NotFound("Nenhum student encontrado!");

            return Ok(resultado);

        }

        [HttpDelete]
        [Route("Api/student")]
        public IActionResult Delete(int id)
        {
            _studentservice.DeleteStudent(id);
            return NoContent();

        }



        [HttpPut]
        [Route("Api/student")]
        public IActionResult UpdateStudent([FromBody] StudentService student)
        {
            _studentservice.UpdateStudent(student);
            return Ok("Student atualizado com sucesso");
        }
        [HttpPost]
        [Route("Api/teacher")]
        public IActionResult AddTeacher([FromBody] StudentService teacher)
        {
            _studentservice.AddTeacher(teacher);
            return Ok("Teacher cadastrado com sucesso");
        }

        [HttpGet]
        [Route("Api/teacher/{id}")]
        public IActionResult GetByIdT(int id)
        {
            var resultado = _studentservice.GetTeacherById(id);

            if (resultado == null)
                return NotFound("Teacher não encontrado!");

            return Ok(resultado);

        }

        [HttpGet]
        [Route("Api/teacher")]
        public IActionResult GetByAllT()
        {
            var resultado = _studentservice.GetAllTeachers();

            if (resultado == null)
                return NotFound("Nenhum Teacher encontrado!");

            return Ok(resultado);

        }

        [HttpDelete]
        [Route("Api/teacher")]
        public IActionResult DeleteT(int id)
        {
            _studentservice.DeleteTeacher(id);
            return NoContent();

        }



        [HttpPut]
        [Route("Api/teacher")]
        public IActionResult UpdateTeacher([FromBody] StudentService teacher)
        {
            _studentservice.UpdateTeacher(teacher);
            return Ok("Student atualizado com sucesso");
        }


    }
}
