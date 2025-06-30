// backend/JCertPreBackend/Controllers/CourseController.cs
  using Microsoft.AspNetCore.Mvc;
  using Microsoft.EntityFrameworkCore;
  using JCertPreBackend.Data;
  using JCertPreBackend.Models;

  namespace JCertPreBackend.Controllers
  {
      [Route("api/[controller]")]
      [ApiController]
      public class CourseController : ControllerBase
      {
          private readonly JCertPreContext _context;

          public CourseController(JCertPreContext context)
          {
              _context = context;
              if (!_context.Courses.Any())
              {
                  _context.Courses.AddRange(
                      new Course { Id = 1, Name = "JLPT N5", Type = "Video" },
                      new Course { Id = 2, Name = "NAT-TEST N4", Type = "Livestream" }
                  );
                  _context.SaveChanges();
              }
          }

          [HttpGet]
          public async Task<ActionResult<IEnumerable<Course>>> GetCourses()
          {
              return await _context.Courses.ToListAsync();
          }

          [HttpPost("enroll")]
          public IActionResult EnrollCourse([FromBody] EnrollRequest request)
          {
              return Ok(new { Message = $"Đăng ký khóa học {request.CourseId} thành công" });
          }
      }

      public class EnrollRequest
      {
          public int UserId { get; set; }
          public int CourseId { get; set; }
      }
  }