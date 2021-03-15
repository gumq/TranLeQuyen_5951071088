using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TranLeQuyen_5951071088.Models;

namespace TranLeQuyen_5951071088.Controllers
{

    public class StudentController : ApiController
    {
        // GET: api/Student
        public IEnumerable<StudentInfo> Get()
        {
            var StudentInfList = new List<StudentInfo>();
            for (int i = 0; i < 100; i++)
            {  
                var StudentInfo = new StudentInfo
                {
                    NameSt = $"Tran Van {i}",
                    Age = 21,
                    Student_code = $"Mã {i}"
                };
                StudentInfList.Add(StudentInfo);
            }
            return StudentInfList;
        }

        // GET: api/Student/5
        public StudentInfo Get(int id)
        {
            return new StudentInfo
            {
                NameSt = $"Tran Van {id}",
                Age = id,
                Student_code = $"Mã {id}"
            }; ;
        }
        // POST: api/nn
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/nn/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/nn/5
        public void Delete(int id)
        {
        }

    }
}
