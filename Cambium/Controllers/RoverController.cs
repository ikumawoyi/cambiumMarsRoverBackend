using Cambium.Interfaces;
using Cambium.Requests;
using Microsoft.AspNetCore.Mvc;

namespace Cambium.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class RoverController : ControllerBase
	{
		private readonly IRover _rover;

		public RoverController(IRover rover)
		{
			_rover = rover;
		}

		[HttpPost]
		public async Task<IActionResult> PostRover(RoverRequest roverRequest)
		{
			var response = _rover.GetRoverPosition(roverRequest);

			return Ok(response);
		}
	}
}
