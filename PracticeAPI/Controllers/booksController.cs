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
    public class BooksController : ControllerBase
    {
        private readonly IbookRepository _bookService;
        public BooksController(IbookRepository repository)
        {
            _bookService = repository;
        }
        [HttpGet]
        public IActionResult GetBooks()
        {
            var mybooks = _bookService.AllBooks();
            return Ok(mybooks);
         
        }
    }
}
