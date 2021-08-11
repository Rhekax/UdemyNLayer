using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UdemyNLayer.Core.Entitiy_Model_;
using UdemyNLayer.Core.Service;

namespace UdemyNLayer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        private readonly IMapper _mapper;

        private readonly IService<Person> _personService;

        public PersonController(IService<Person> personService,IMapper mapper)
        {
            _personService = personService;
            _mapper = mapper;
        }

        [HttpGet("{Id}")]
        public async Task<IActionResult> GetPerson(int Id)
        {
            var person = await _personService.GetByIdAsync(Id);
            return Ok(person);
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var people = await _personService.GetAllAsync();
            return Ok(people);
        }
        [HttpPost]
        public async Task<IActionResult> Save (Person person)
        {
            var newPerson = await _personService.AddAsync(person);
            
            return Created(string.Empty, newPerson);
        }

        [HttpPut]
        public  IActionResult Update(Person person)
        {
            var personUpdate =  _personService.Update(person);

            return NoContent();
        }

        [HttpDelete("{id}")]

        public IActionResult Remove(int id)
        {
            var delPerson = _personService.GetByIdAsync(id).Result;
            _personService.Remove(delPerson);
            
            return NoContent();
        }






    }
}
