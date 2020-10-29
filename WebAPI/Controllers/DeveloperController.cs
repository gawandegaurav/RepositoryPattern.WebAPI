using Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DeveloperController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public DeveloperController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IActionResult GetPopularDevelopers(int count)
        {
            var popularDevelpers = _unitOfWork.DeveloperRepository.GetTopDevelopers(count);
            return Ok(popularDevelpers);
        }
    }
}