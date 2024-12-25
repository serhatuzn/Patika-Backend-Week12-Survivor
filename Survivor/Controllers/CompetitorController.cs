using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Survivor.Data;
using Survivor.Models;

namespace Survivor.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompetitorController : ControllerBase
    {
        private readonly SurvivorDbContext _context;

        public CompetitorController(SurvivorDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult GetCompetitors() // Tüm yarışmacıları getirir.
        {
            var competitors = _context.Competitiors.ToList();
            return Ok(competitors);
        }

        [HttpGet("{id}")]
        public ActionResult GetCompetitor(int id) // Id'ye göre yarışmacı getirir.
        {
            var comptetitor = _context.Competitiors.Find(id);
            if (comptetitor == null)
            {
                return NotFound();
            }
            return Ok(comptetitor);
        }

        [HttpGet("category/{categoryId}")] // Kategoriye göre yarışmacıları getirir.
        public ActionResult GetCompetitorsByCategory(int categoryId)
        {
            var competitors = _context.Competitiors.Where(c => c.CategoryId == categoryId).ToList();
            return Ok(competitors);
        }

        [HttpPost]
        public ActionResult NewCompetitor(Competitiors competitiors) // Yeni yarışmacı ekler.
        {
            _context.Competitiors.Add(competitiors);
            _context.SaveChanges();
            return Ok(competitiors);
        }

        [HttpPut("{id}")]
        public ActionResult UpdateCompetitor(int id, Competitiors competitiors) // Yarışmacı günceller.
        {
            if (id != competitiors.Id)
            {
                return BadRequest();
            }
            _context.Entry(competitiors).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();
            return Ok(competitiors);
        }

        [HttpDelete("{id}")]
        public ActionResult DeleteCompetitor(int id) // Yarışmacı siler.
        {
            var competitor = _context.Competitiors.Find(id);
            if (competitor == null)
            {
                return NotFound();
            }
            _context.Competitiors.Remove(competitor);
            _context.SaveChanges();
            return Ok(competitor);
        }
    }
}
