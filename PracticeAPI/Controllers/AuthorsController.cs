
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
        public IActionResult GetAuthotrs(int? id)
        {
            var authors = _authorService.AllAuthors();
            var authotDto = _mapper.Map<List<AutorDto>>(authors);
           

            if (id is null) return Ok(authotDto);
            authotDto = authotDto.Where(t => t.Id == id).ToList();
            return Ok(authotDto);

        }
    }
}
