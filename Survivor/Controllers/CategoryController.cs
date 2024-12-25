using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Survivor.Data;
using Survivor.Models;

namespace Survivor.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly SurvivorDbContext _context;
        public CategoryController(SurvivorDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult GetCategories() // Tüm kategorileri getirir.
        {
            var categories = _context.Categories.ToList();
            return Ok(categories);
        }

        [HttpGet("{id}")]
        public ActionResult GetCategory(int id) // Id'ye göre kategori getirir.
        {
            var category = _context.Categories.Find(id);

            if (category == null)
            {
                return NotFound();
            }
            return Ok(category);
        }

        [HttpPost]
        public ActionResult NewCategory(Category category) // Yeni kategori ekler.
        {
            _context.Categories.Add(category);
            _context.SaveChanges();
            return Ok(category);
        }

        [HttpPut("{id}")]
        public ActionResult UpdateCategory(int id, Category category) // Kategori günceller.
        {
            if (id != category.Id)
            {
                return BadRequest();
            }
            _context.Entry(category).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();
            return Ok(category);
        }

        [HttpDelete("{id}")]
        public ActionResult DeleteCategory(int id) // Kategori siler.
        {
            var category = _context.Categories.Find(id);
            if (category == null)
            {
                return NotFound();
            }
            _context.Categories.Remove(category);
            _context.SaveChanges();
            return Ok(category);
        }
    }
}
