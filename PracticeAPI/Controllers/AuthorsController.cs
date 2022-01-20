
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PracticeAPI.ViewModel;
using PracticeAPI.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PracticeAPI.Models;
using AutoMapper;

namespace PracticeAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorsController : ControllerBase
    {
        private readonly IAuthorRepository _authorService;
        private readonly IMapper _mapper;
        
  
        public AuthorsController(IAuthorRepository repository, IMapper mapper)
        {
            _authorService = repository;
            _mapper = mapper;
           
        }
        [HttpGet("{id?}")]
        public ActionResult<ICollection<AutorDto>> GetAuthotrs()
        {
            var authors = _authorService.AllAuthors();
            var authotDto = _mapper.Map<List<AutorDto>>(authors);
            return Ok(authotDto);

        

        }
        [HttpGet("{Id}")]
        public IActionResult GetAuthor(int id)
        {
            var author=_authorService.
        }
    }
}
