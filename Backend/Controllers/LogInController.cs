using Backend.Dtos;
using Backend.Services;
using ContainerToolDB;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Backend.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class LogInController : ControllerBase
    {
        private readonly LogInService _service;
        private readonly ContainerToolDBContext _db;

        public LogInController(LogInService service, ContainerToolDBContext db)
        {
            _service = service;
            _db = db;
        }

        [HttpPost("register")]
        public IActionResult Register(UserDto userDto)
        {
            // Überprüfe, ob bereits ein Benutzer mit der angegebenen E-Mail existiert
            var userExists = _db.Users.Any(x => x.Email == userDto.Email);
            if (!userExists) // Wenn kein Benutzer existiert, fahre fort mit der Registrierung
            {
                var hashedPassword = _service.HashPassword(userDto.Password);
                var user = new User
                {
                    UserName = userDto.UserName,
                    Password = hashedPassword,
                    Email = userDto.Email
                };
                _db.Users.Add(user);
                _db.SaveChanges();
                return Ok();
            }
            // Wenn ein Benutzer existiert, gib eine Fehlermeldung zurück
            return BadRequest("Ein Benutzer mit dieser E-Mail existiert bereits.");
        }

        [HttpPost("login")]
        public IActionResult Login(UserDto userDto)
        {
            if(userDto.Email == "" || userDto.Password == "")
            {
                return Unauthorized();
            }
            var user = _db.Users.FirstOrDefault(x => x.Email == userDto.Email);
            if (user != null && _service.VerifyPassword(userDto.Password, user.Password))
            {
                var token = _service.GenerateJwtToken(user);
                return Ok(new { token });
            }
            return Unauthorized();
        }
    }
}
