// backend/JCertPreBackend/Controllers/AuthController.cs
  using Microsoft.AspNetCore.Mvc;
  using JCertPreBackend.Data;
  using JCertPreBackend.Models;

  namespace JCertPreBackend.Controllers
  {
      [Route("api/[controller]")]
      [ApiController]
      public class AuthController : ControllerBase
      {
          private readonly JCertPreContext _context;

          public AuthController(JCertPreContext context)
          {
              _context = context;
              if (!_context.Users.Any())
              {
                  _context.Users.Add(new User { Id = 1, Username = "test", Password = "123456" });
                  _context.SaveChanges();
              }
          }

          [HttpPost("login")]
          public IActionResult Login([FromBody] LoginRequest request)
          {
              var user = _context.Users.FirstOrDefault(u => u.Username == request.Username && u.Password == request.Password);
              if (user == null) return Unauthorized("Sai tên đăng nhập hoặc mật khẩu");
              return Ok(new { UserId = user.Id, Message = "Đăng nhập thành công" });
          }
      }

      public class LoginRequest
      {
          public string? Username { get; set; }
          public string? Password { get; set; }
      }
  }