using Clinic.Data;
using Clinic.Entities;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Clinic.Controllers
{
    [Route("Clinic/[controller]")]
    [ApiController]
    public class PatientController : ControllerBase
    {
       public DataContext DataContext { get; set; }
        // GET: api/<PatientController>
        [HttpGet]
        public ActionResult Get()
        {
            return Ok(DataContext.Patients);
        }

        // GET api/<PatientController>/5
        [HttpGet("{id}")]
        public ActionResult<Patient> Get(int id)
        {
            if (DataContext.Patients.Find(x => x.Id == id) == null)
                return NotFound();
            return DataContext.Patients.Where(x => x.Id == id).First();
        }

        // POST api/<PatientController>
        [HttpPost]
        public ActionResult Post([FromBody] Patient p)
        {
            if (DataContext.Patients.Find(x => x.Id == p.Id) != null)
                return NotFound();
            DataContext.Patients.Add(p);
            return Ok(DataContext.Patients);
        }

        // PUT api/<PatientController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Patient p)
        {
            if (DataContext.Patients.Find(x => x.Id == id) == null)
                return NotFound();
            DataContext.Patients.Find(x => x.Id == id).Name = p.Name;
            return Ok();
        }

        // DELETE api/<PatientController>/5
        [HttpPut("{id}/status")]
        public ActionResult Put(int id,bool status)
        {
            if (DataContext.Patients.Find(x => x.Id == id) == null)
                return NotFound(status);
            DataContext.Patients.Find(x => x.Id == id).Status = status;
            return Ok();
        }
    }
}
