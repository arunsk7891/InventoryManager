using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InventoryManager.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace InventoryManager.Controllers
{
   
    [ApiController]
    [Route("[controller]")]
    public class ValuesAPIController : ControllerBase
    {

        private readonly ILogger<ValuesAPIController> _logger;

        public ValuesAPIController(ILogger<ValuesAPIController> logger)
        {
            _logger = logger;
        }


        [HttpGet]
        
        public IEnumerable<InventoryItem>Get()
        {

            return Enumerable.Range(1, 5).Select(index => new InventoryItem
            {
                Created = DateTime.Now,
                Id = 1,
                Name = "Test",
                Description = "New Item"
            })
            .ToArray();
        }

        [HttpGet("{itemId}")]
        public InventoryItem GetItem(int itemId)
        {
            return new InventoryItem
            {
                Created = DateTime.Now,
                Id = itemId,
                Name = "Test",
                Description = "New Item"
            };
        }

        [HttpPost]
        public ActionResult<InventoryItem> Post([FromBody] InventoryItem inventoryItem)
        {
            _logger.LogDebug("InsidePost");
            return Ok();
        }



        /*
        // GET: api/<ValuesControllerAPI>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }
        
        // GET api/<ValuesControllerAPI>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ValuesControllerAPI>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ValuesControllerAPI>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ValuesControllerAPI>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }

        */



    }
}
