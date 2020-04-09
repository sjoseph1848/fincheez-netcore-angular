using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Infrastructure.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers {
    [ApiController]
    [Route ("api/[controller]")]
    public class StocksController : ControllerBase {
        private readonly StoreContext _context;
        public StocksController (StoreContext context) 
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Stock>>> GetStocks() 
        {
            var stocks = await _context.Stocks.ToListAsync();

            return Ok(stocks);
        }

        [HttpGet ("{id}")]
        public async Task<ActionResult<Stock>> GetStock (int id) 
        {
            return await _context.Stocks.FindAsync(id);
        }
    }
}