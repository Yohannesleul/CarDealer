using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CarDealership.Data;
using CarDealership.Models;

namespace CarDealership.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarsController : ControllerBase
    {
        private readonly CarContext _context;

        public CarsController(CarContext context)
        {
            _context = context;
        }

        // GET: api/Cars
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Car>>> Getcars()
        {
            return await _context.cars.ToListAsync();
        }

        // GET: api/Cars/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Car>> GetCar(string id)
        {
            var car = await _context.cars.FindAsync(id);

            if (car == null)
            {
                return NotFound();
            }

            return car;
        }

        // GET: api/Cars/true/true/true/true/true/true
        [HttpGet("select/{hasSunRoof}/{isFourWheelDrive}/{powerWindows}/{hasLowMiles}/{hasNavigation}/{hasHeatedSeat}")]
        public async Task<ActionResult<IEnumerable<Car>>> GetCar(bool hasSunRoof, bool isFourWheelDrive, bool powerWindows, bool hasLowMiles, bool hasNavigation, bool hasHeatedSeat)
        {
            //var car = await _context.cars.FindAsync(id);
            var car = await _context.cars.Where(x => x.HasHeatedSeat == hasSunRoof && x.IsFourWheelDrive == isFourWheelDrive && x.HasPowerWindws == powerWindows && x.HasLowMiles == hasLowMiles && x.HasNavigation == hasNavigation && x.HasHeatedSeat == hasHeatedSeat).ToListAsync();

            if (car == null)
            {
                return NotFound();
            }

            return car;
        }


        // POST: api/Cars
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Car>> PostCar(Car car)
        {
            _context.cars.Add(car);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (CarExists(car._id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetCar", new { id = car._id }, car);
        }

        private bool CarExists(string id)
        {
            return _context.cars.Any(e => e._id == id);
        }
    }

}
