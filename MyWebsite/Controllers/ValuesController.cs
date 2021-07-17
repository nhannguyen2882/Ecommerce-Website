using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyWebsite.Entities;
using Microsoft.EntityFrameworkCore;

namespace MyWebsite.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly UserContext _context;
        public ValuesController(UserContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IActionResult Get()
        {
            //Logic with the injected _context object.
            var entity = _context.Model
            .FindEntityType(typeof(User).FullName);
            var tableName = entity.GetTableName();
            var schemaName = entity.GetSchema();
            var key = entity.FindPrimaryKey();
            var properties = entity.GetProperties();
            return null; 
        }
    }

}
