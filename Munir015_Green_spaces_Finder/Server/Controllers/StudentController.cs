using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Munir015_Green_spaces_Finder.Server.Data;
using Munir015_Green_spaces_Finder.Shared;

namespace Munir015_Green_spaces_Finder.Server.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        // Database context for handling reviews
        private readonly AppDbContext _context;

        // Constructor to inject the database context
        public StudentController(AppDbContext context)
        {
            _context = context;
        }

        // GET api/<StudentController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Student>>> GetStudent()
        {
            // Retrieve all reviews asynchronously from the database
            return await _context.Students.ToListAsync();
        }

        // GET api/<StudentController>/id
        [HttpGet("{id}")]
        public async Task<ActionResult<Student>> GetStudent(int id)
        {
           ]
            var review = await _context.Students.FindAsync(id);

            // Check if the review with the specified ID exists
            if (student == null)
            {
                return NotFound(); // Return a 404 Not Found response if the review is not found
            }

            return Student; // Return the found review
        }

        // POST api/<StudentController>
        [HttpPost]
        public async Task<ActionResult<Student>> PostReview(Student student)
        {
            // Add a new review to the database
            _context.Students.Add(student);
            await _context.SaveChangesAsync();

            // Return a 201 Created response with the details of the newly created review
            return CreatedAtAction(nameof(GetStudent), new { id = student.sid }, student);
        }

        // PUT api/<StudentController>/id
        [HttpPut("{id}")]
        public async Task<IActionResult> PutStudent(int id, Student student
            )
        {
            // Check if the provided ID matches the review's ID
            if (id != student.sid)
            {
                return BadRequest(); // Return a 400 Bad Request response if the IDs do not match
            }

            
            _context.Entry(student).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync(); // Save changes to the database
            }
            catch (DbUpdateConcurrencyException)
            {
                // Handle concurrency conflicts
                if (!StudentExists(id))
                {
                    return NotFound(); // Return a 404 Not Found response if the review is not found
                }
                else
                {
                    throw;
                }
            }

            return NoContent(); // Return a 204 No Content response on successful update
        }

        // DELETE api/<ReviewController>/id
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteStudent(int id)
        {
            // Find a review by its ID in the database
            var student = await _context.Student.FindAsync(id);

            // Check if the review with the specified ID exists
            if (student == null)
            {
                return NotFound(); // Return a 404 Not Found response if the review is not found
            }

            // Remove the review from the database and save changes
            _context.Reviews.Remove(student);
            await _context.SaveChangesAsync();

            return NoContent(); // Return a 204 No Content response on successful deletion
        }

        // Helper method to check if a review with a given ID exists
        private bool StudentExists(int id)
        {
            return _context.Student.Any(e => e.sid == id);
        }
    }
}
