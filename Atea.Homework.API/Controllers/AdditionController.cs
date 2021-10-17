using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Atea.Homework.API.Controllers
{
    
    [ApiController]
    [Route("[controller]")]
    public class AdditionController : ControllerBase
    {
        private readonly IDatabaseConnection _databaseConnection;

        public AdditionController(IDatabaseConnection databaseConnection)
        {
            _databaseConnection = databaseConnection;
        }  
        

       
        [HttpPost]
        public async Task<IActionResult> Add(Entity entity)
        {
            try
            {
                await _databaseConnection.SaveDataToDb(entity);
                return Ok(entity);
            }
            catch (Exception Ex)
            {                
                return StatusCode(500);
            }
        }

        
    }
}
