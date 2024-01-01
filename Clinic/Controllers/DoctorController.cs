

using Clinic.Data;
using Clinic.Entities;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Clinic.Controllers
{
    [Route("Clinic/[controller]")]
    [ApiController]
    public class DoctorController : ControllerBase
    {
        public DataContext DataContext { get; set; }
        public DoctorController()
        {
            DataContext = new DataContext();
        }
       
        // GET: api/<DoctorController>
        [HttpGet]
        public ActionResult Get()
        {
            return Ok(DataContext.Doctors);
        }

        // GET api/<DoctorController>/5
        [HttpGet("{id}")]
        public ActionResult<Doctor> Get(int id)
        {
            if (DataContext.Doctors.Find(x => x.Id == id) == null)
                return NotFound();
            return DataContext.Doctors.Where(x => x.Id == id).First();
        }

        // POST api/<DoctorController>
        [HttpPost]
        public ActionResult Post([FromBody] Doctor d)
        {
            if (DataContext.Doctors.Find(x => x.Id == d.Id) != null)
                return NotFound();
            DataContext.Doctors.Add(d);
            return Ok(DataContext.Doctors);
        }

        // PUT api/<DoctorController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Doctor d)
        {
            if (DataContext.Doctors.Find(x => x.Id == id) == null)
                return NotFound();
            DataContext.Doctors.Find(x => x.Id == id).Name = d.Name;
            return Ok();

        }

        // DELETE api/<DoctorController>/5
        [HttpPut("{id}/status")]
        public ActionResult Put(int id, bool status)
        {
            if (DataContext.Doctors.Find(x => x.Id == id) == null)
                return NotFound(status);
           
            return Ok(DataContext.Doctors.Find(x => x.Id == id).Status = status);
        }
    }
}
