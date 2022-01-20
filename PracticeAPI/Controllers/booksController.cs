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
    public class booksController : ControllerBase
    {
        private readonly IbookRepository _bookService;
        public booksController(IbookRepository repository)
        {
            _bookService = repository;
        }
        [HttpGet("{id?}")]
        public IActionResult GetBooks(int ? id)
        {
            var mybooks = _bookService.AllBooks();

            if (id is null) return Ok(mybooks);
            mybooks = mybooks.Where(t => t.Id == id).ToList();
            return Ok(mybooks);

        }
    }
}
