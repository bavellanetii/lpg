using api.Data;
using api.Dto;
using api.Interfaces;
using api.Models;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : Controller
    {
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;
        private readonly DataContext _context;
        public UserController(IUserRepository userRepository, IMapper mapper, DataContext context)
        {
            _context = context;
            _mapper = mapper;
            _userRepository = userRepository;
        }

        [HttpGet("/api/users")]
        [ProducesResponseType(200, Type = typeof(IEnumerable<User>))]
        public IActionResult GetUsers()
        {
            var users = _mapper.Map<List<UserDto>>(_userRepository.GetUsers());

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            return Ok(users);
        }

        [HttpGet("{id}")]
        [ProducesResponseType(200, Type = typeof(User))]
        [ProducesResponseType(400)]
        public IActionResult GetUser(int id)
        {
            if (!_userRepository.UserExists(id))
                return NotFound();

            var user = _mapper.Map<UserDto>(_userRepository.GetUser(id));

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            return Ok(user);
        }

        [HttpPut("/api/incrementprogrammingxp/{id}")]
        public IActionResult IncrementProgrammingXP(int id)
        {
             if (!_userRepository.UserExists(id))
                return NotFound();
            
            var user = _mapper.Map<UserDto>(_userRepository.IncrementProgrammingXP(id));
            
            return Ok(user);
        }

        [HttpPut("/api/decrementprogrammingxp/{id}")]
        public IActionResult DecrementProgrammingXP(int id)
        {
            if(!_userRepository.UserExists(id))
                return NotFound();

            var user = _mapper.Map<UserDto>(_userRepository.DecrementProgrammingXP(id));

            return Ok(user);
        }

        [HttpPut("/api/incrementfitnessxp/{id}")]
        public IActionResult IncrementFitnessXP(int id)
        {
            if(!_userRepository.UserExists(id))
                return NotFound();

            var user = _mapper.Map<UserDto>(_userRepository.IncrementFitnessXP(id));

            return Ok(user);
        }

        [HttpPut("/api/decrementfitnessxp/{id}")]
        public IActionResult DecrementFitnessXP(int id)
        {
            if(!_userRepository.UserExists(id))
                return NotFound();

            var user = _mapper.Map<UserDto>(_userRepository.DecrementFitnessXP(id));

            return Ok(user);
        }
        
        [HttpPut("/api/incrementhouseworkxp/{id}")]
        public IActionResult IncrementHouseworkXP(int id)
        {
            if(!_userRepository.UserExists(id))
                return NotFound();

            var user = _mapper.Map<UserDto>(_userRepository.IncrementHouseworkXP(id));

            return Ok(user);
        }

        [HttpPut("/api/decrementhouseworkxp/{id}")]
        public IActionResult DecrementHouseworkXP(int id)
        {
            if(!_userRepository.UserExists(id))
                return NotFound();

            var user = _mapper.Map<UserDto>(_userRepository.DecrementHouseworkXP(id));

            return Ok(user);
        }

        [HttpPut("/api/incrementreadingxp/{id}")]
        public IActionResult IncrementReadingXP(int id)
        {
            if(!_userRepository.UserExists(id))
                return NotFound();

            var user = _mapper.Map<UserDto>(_userRepository.IncrementReadingXP(id));

            return Ok(user);
        }

        [HttpPut("/api/decrementreadingxp/{id}")]
        public IActionResult DecrementReadingXP(int id)
        {
            if(!_userRepository.UserExists(id))
                return NotFound();

            var user = _mapper.Map<UserDto>(_userRepository.DecrementReadingXP(id));

            return Ok(user);
        }
    }
}