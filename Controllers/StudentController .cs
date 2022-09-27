using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.Models;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly DonationDBContext _context;

        public StudentController(DonationDBContext context)
        {
            _context = context;
        }

        // GET: api/DCandidate
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Student>>> GetStudents()
        {
            return await _context.students.ToListAsync();
        }

        // GET: api/DCandidate/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Student>> GetStudent(int id)
        {
            var _student = await _context.students.FindAsync(id);

            if (_student == null)
            {
                return NotFound();
            }

            return _student;
        }

        // PUT: api/DCandidate/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutStudent(int id, Student _student)
        {
            _student.id = id;

            _context.Entry(_student).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!StudentExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/DCandidate
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<DCandidate>> PostDCandidate(Student student)
        {
            _context.students.Add(student);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetDCandidate", new { id = student.id }, student);
            
        }

        // DELETE: api/DCandidate/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Student>> DeleteStudent(int id)
        {
            var _student = await _context.students.FindAsync(id);
            if (_student == null)
            {
                return NotFound();
            }

            _context.students.Remove(_student);
            await _context.SaveChangesAsync();

            return _student;
        }

        private bool StudentExists(int id)
        {
            return _context.students.Any(e => e.id == id);
        }
    }
}
