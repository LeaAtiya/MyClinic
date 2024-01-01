using Clinic.Data;
using Clinic.Entities;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Clinic.Controllers
{
    [Route("Clinic/[controller]")]
    [ApiController]
    public class TurnController : ControllerBase
    {
        public DataContext DataContext { get; set; }
        // GET: api/<TurnController>
        [HttpGet]
        public ActionResult Get()
        {
            return Ok(DataContext.Turns);
        }

        // GET api/<TurnController>/5
        [HttpGet("{id}")]
        public ActionResult<Turn> Get(int id)
        {
            if (DataContext.Turns.Find(x => x.code == id) == null)
                return NotFound();
            return DataContext.Turns.Where(x => x.code == id).First();
        }

        // POST api/<TurnController>
        [HttpPost]
        public ActionResult Post([FromBody] Turn t)
        {
            if (DataContext.Turns.Find(x => x.code == t.code) != null)
                return NotFound();
            DataContext.Turns.Add(t);
            return Ok(DataContext.Turns);
        }

        // PUT api/<TurnController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Turn t)
        {
            if (DataContext.Turns.Find(x => x.code == id) == null)
               return NotFound();
            Turn turn = DataContext.Turns.Find(x => x.code == id);
            turn.date = t.date;
            turn.Pt = t.Pt;
            turn.Dr = t.Dr;
            return Ok();
        }

        // DELETE api/<TurnController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            if (DataContext.Turns.Find(x => x.code == id) == null)
                return NotFound();
            DataContext.Turns.Remove(DataContext.Turns.Find(x => x.code == id));
            return Ok();

        }
    }
}
