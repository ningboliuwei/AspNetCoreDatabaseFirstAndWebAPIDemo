using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetCoreDatabaseFirstAndWebAPIDemo.Data;
using AspNetCoreDatabaseFirstAndWebAPIDemo.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AspNetCoreDatabaseFirstAndWebAPIDemo.Controllers
{
    [Produces("application/json")]
    [Route("api/Category")]
    public class CategoryController : Controller
    {
        private readonly OrderingContext _context;

        public CategoryController(OrderingContext context)
        {
            _context = context;
        }

        // GET: api/Category
        [HttpGet]
        public IEnumerable<CategoryInfo> GetCategories()
        {
            return _context.Categories;
        }

        // GET: api/Category/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetCategoryInfo([FromRoute] long id)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);

            var categoryInfo = await _context.Categories.SingleOrDefaultAsync(m => m.Id == id);

            if (categoryInfo == null) return NotFound();

            return Ok(categoryInfo);
        }

        // PUT: api/Category/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCategoryInfo([FromRoute] long id, [FromBody] CategoryInfo categoryInfo)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);

            if (id != categoryInfo.Id) return BadRequest();

            _context.Entry(categoryInfo).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CategoryInfoExists(id))
                    return NotFound();
                throw;
            }

            return NoContent();
        }

        // POST: api/Category
        [HttpPost]
        public async Task<IActionResult> PostCategoryInfo([FromBody] CategoryInfo categoryInfo)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);

            _context.Categories.Add(categoryInfo);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCategoryInfo", new {id = categoryInfo.Id}, categoryInfo);
        }

        // DELETE: api/Category/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCategoryInfo([FromRoute] long id)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);

            var categoryInfo = await _context.Categories.SingleOrDefaultAsync(m => m.Id == id);
            if (categoryInfo == null) return NotFound();

            _context.Categories.Remove(categoryInfo);
            await _context.SaveChangesAsync();

            return Ok(categoryInfo);
        }

        private bool CategoryInfoExists(long id)
        {
            return _context.Categories.Any(e => e.Id == id);
        }
    }
}