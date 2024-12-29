using AutoMapper;
using MatchMaker.API.Models;
using MatchMaker.Core.Entities;
using MatchMaker.Core.Entities.MatchMaker.Core.Entities;
using MatchMaker.Core.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MatchMaker.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        private readonly IPersonService _personService;
        private readonly IMapper _mapper; // הזרקת AutoMapper

        public PersonController(IPersonService personService, IMapper mapper)
        {
            _personService = personService;
            _mapper = mapper; // הזרקת AutoMapper
        }

        [HttpGet]
        public async Task<ActionResult<List<Person>>> Get()
        {
            var people = await _personService.GetListAsync();
            return Ok(people);
        }
        [HttpGet("guys")]
        public async Task<ActionResult<List<Guy>>> GetGuys()
        {
            // קבלת כל האנשים מהשירות
            var people = await _personService.GetListAsync();

            // סינון האנשים רק לאובייקטים מהסוג Guy
            var guys = people.OfType<Guy>().ToList();

            return Ok(guys);
        }

        [HttpGet("girls")]
        public async Task<ActionResult<List<Girl>>> GetGirls()
        {
            // קבלת כל האנשים מהשירות
            var people = await _personService.GetListAsync();

            // סינון האנשים רק לאובייקטים מהסוג Girl
            var girls = people.OfType<Girl>().ToList();

            return Ok(girls);
        }


        [HttpGet("{id}")]
        public async Task<ActionResult<Person>> GetById(int id)
        {
            var person = await _personService.GetByIdAsync(id);
            if (person == null)
            {
                return NotFound();
            }
            return Ok(person);
        }

        [HttpPost]
        public async Task<ActionResult<Person>> Post([FromBody] PersonPostModel personPostModel)
        {
            // המיפוי של המודל ל- Entity
            var person = _mapper.Map<Person>(personPostModel);

            var createdPerson = await _personService.Add(person);
            return CreatedAtAction(nameof(GetById), new { id = createdPerson.Id }, createdPerson);
        }






        [HttpPost("addGuy")]
        public async Task<ActionResult<Person>> AddGuy([FromBody] GuyPostModel guyPostModel)
        {
            var guy = _mapper.Map<Guy>(guyPostModel);
            var createdGuy = await _personService.Add(guy);
            return CreatedAtAction(nameof(GetById), new { id = createdGuy.Id }, createdGuy);
        }
        [HttpPost("addGirl")]
        public async Task<ActionResult<Person>> AddGirl([FromBody] GirlPostModel girlPostModel)
        {
            var girl = _mapper.Map<Girl>(girlPostModel);
            var createdGirl = await _personService.Add(girl);
            return CreatedAtAction(nameof(GetById), new { id = createdGirl.Id }, createdGirl);
        }


        [HttpPut("{id}")]
        public async Task<ActionResult<Person>> Put(int id, [FromBody] PersonPostModel personPostModel)
        {
            // המיפוי של המודל ל- Entity
            var person = _mapper.Map<Person>(personPostModel);
            person.Id = id; // אנחנו חייבים להגדיר את ה- ID פה, כי הוא מגיע מה- URL ולא מה- Body

            var updatedPerson = await _personService.Update(person);
            return Ok(updatedPerson);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var person = await _personService.GetByIdAsync(id);
            if (person == null)
            {
                return NotFound();
            }

            await _personService.Delete(person);
            return NoContent();
        }
    }
}