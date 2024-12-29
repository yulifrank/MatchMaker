using AutoMapper;
using MatchMaker.API.Models;
using MatchMaker.Core.Entities;
using MatchMaker.Core.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MatchMaker.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IdeaController : ControllerBase
    {
        private readonly IIdeaService _ideaService;
        private readonly IMapper _mapper;  // הזרקת AutoMapper

        public IdeaController(IIdeaService ideaService, IMapper mapper)
        {
            _ideaService = ideaService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<List<Idea>>> Get()
        {
            var ideas = await _ideaService.GetListAsync();
            return Ok(ideas);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Idea>> GetById(int id)
        {
            var idea = await _ideaService.GetByIdAsync(id);
            if (idea == null)
            {
                return NotFound();
            }
            return Ok(idea);
        }

        [HttpPost]
        public async Task<ActionResult<Idea>> Post([FromBody] IdeaPostModel ideaPostModel)  // הוספת המודל פוסט
        {
            // שימוש ב- AutoMapper למיפוי מהמודל למודל Entity
            var idea = _mapper.Map<Idea>(ideaPostModel);
            
            var createdIdea = await _ideaService.AddAsync(idea);
            return CreatedAtAction(nameof(GetById), new { id = createdIdea.Id }, createdIdea);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<Idea>> Put(int id, IdeaPostModel ideaPostModel)
        {
            var idea = await _ideaService.GetByIdAsync(id);
            if (idea == null)
            {
                return NotFound();
            }

            // Update the properties of the existing idea with new data
            _mapper.Map(ideaPostModel, idea);
            var updatedIdea = await _ideaService.UpdateAsync(idea);

            return Ok(updatedIdea);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var idea = await _ideaService.GetByIdAsync(id);
            if (idea == null)
            {
                return NotFound();
            }

            await _ideaService.DeleteAsync(idea);
            return NoContent();
        }
    }
}
