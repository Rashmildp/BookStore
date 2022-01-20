using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PracticeAPI.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PracticeAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorsController : ControllerBase
    {
        private readonly IAuthorRepository _authorService;
        public AuthorsController(IAuthorRepository repository)
        {
            _authorService = repository;
        }
        [HttpGet("{id?}")]
        public IActionResult GetAuthotrs(int? id)
        {
            var authors = _authorService.AllAuthors();

            if (id is null) return Ok(authors);
            authors = authors.Where(t => t.Id == id).ToList();
            return Ok(authors);

        }
    }
}
