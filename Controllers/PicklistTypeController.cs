using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using SpiritPenguin.Data;
using SpiritPenguin.Data.Entities;

namespace SpiritPenguin.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PicklistTypeController : ControllerBase
    {
        private readonly DatabaseContext _context;
        public PicklistTypeController(DatabaseContext context)
        {
            _context = context;
        }


        [HttpGet]
        public IEnumerable<PicklistType> Get()
        {
            return _context.PicklistTypes.ToList();
        }

    }
}