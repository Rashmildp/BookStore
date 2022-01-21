
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
        [HttpGet]
        public ActionResult<ICollection<AutorDto>> GetAuthotrs()
        {
            var authors = _authorService.AllAuthors();
            var authotDto = _mapper.Map<List<AutorDto>>(authors);
            return Ok(authotDto);



        }
        [HttpGet("{id}", Name = "GetAuthor")]
        public IActionResult GetAuthotrs(int id)
        {
            var author = _authorService.getAuthor(id);
            if (author is null)
            {
                return NotFound();
            }
            var authotDto = _mapper.Map<AutorDto>(author);
            return Ok(authotDto);



        }
        [HttpPost]
        public ActionResult<AutorDto> CreateAuthor(CreateAuthorDto author)
        {
            var authorEntity = _mapper.Map<Author>(author);
            var newAuthor = _authorService.AddAuthor(authorEntity);
            var authorForReturn = _mapper.Map<AutorDto>(newAuthor);
            return CreatedAtRoute("GetAuthor", new { id = authorForReturn.Id }, authorForReturn);


        }

        [HttpDelete("{authorId}")]

        public ActionResult DeleteAuthor(int authorTd)
        {
            var deletingTodo = _authorService.getAuthor(authorTd);
            if(deletingTodo is null)
            {
                return NotFound();
            }
            _authorService.DeleteAuthor(deletingTodo);
            return NoContent();

        }


    }
}
