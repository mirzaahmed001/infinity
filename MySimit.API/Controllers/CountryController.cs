using Microsoft.AspNetCore.Mvc;
using MySimit.Admin.Application.CountryService;
using MySimit.Domain.Entities;

namespace MySimit.API.Controllers
{
    [Route("api/[controller]")]
    public class CountryController : Controller
    {
        private readonly ICountryService _countryService;
        public CountryController(ICountryService countryService)
        {
            this._countryService = countryService;
        }
        [HttpPost("Create")]
        public IActionResult Create([FromBody] Country country)
        {
            _countryService.AddAsync(country);
            return CreatedAtAction(nameof(Create), new { country.Id }, country);
        }

        [HttpGet("Get/{id}")]
        public async Task<IActionResult> GetCountry(int id)
        {
            var cards = await _countryService.GetByID(id);
            if (cards != null)
            {
                return Ok(cards);
            }
            return NotFound("Country Not Found");
        }

        [HttpDelete("id")]
        public IActionResult DeleteCountry(int id)
        {
            var numberOfRowsEffected = _countryService.Delete(id);
            if (numberOfRowsEffected > 0)
            {
                return Ok();
            }

            return NotFound("Country Not Found");
        }
    }
}
