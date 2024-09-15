using Microsoft.AspNetCore.Mvc;
using RatingAPITest.Repositories;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RatingAPITest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RatingController : ControllerBase
    {
        private readonly RatingRepository _ratingRepository;
        public RatingController(RatingRepository ratingRepository)
        {
            _ratingRepository = ratingRepository;
        }
        // GET: api/<RatingController>
        [HttpGet]
        public IEnumerable<Rate> Get()
        {
            return _ratingRepository.Ratings;
        }

        // GET api/<RatingController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<RatingController>
        [HttpPost]
        public void Post([FromBody] Rate value)
        {
            _ratingRepository.AddRating(value);
        }

        // PUT api/<RatingController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<RatingController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
