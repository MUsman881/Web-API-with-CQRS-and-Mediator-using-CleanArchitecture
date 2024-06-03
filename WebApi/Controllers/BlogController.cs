using Application.Blogs.Commands.Create;
using Application.Blogs.Commands.Delete;
using Application.Blogs.Commands.Update;
using Application.Blogs.Queries.GetAll;
using Application.Blogs.Queries.GetById;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BlogController : ApiControllerBase
    {
        [HttpGet]
        public async Task<ActionResult> GetAll()
        {
            var blogs = await Mediator.Send(new GetBlogsQuery());
            return Ok(blogs);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult> GetById(int id)
        {
            var blog = await Mediator.Send(new GetByIdQuery(id));
            if (blog == null)
            {
                return NotFound();
            }
            return Ok(blog);
        }

        // post action 
        [HttpPost]
        public async Task<ActionResult> Create(CreateCommand command)
        {
            var create = await Mediator.Send(command);
            return CreatedAtAction(nameof(GetById), new { id = create }, create);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> Update(int id, UpdateCommand command)
        {
            if (id != command.Id)
            {
                return BadRequest();
            }

            var update = await Mediator.Send(command);
            return Ok(update);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var delete = await Mediator.Send(new DeleteCommand(id));
            return Ok(delete);
        }
    }
}
