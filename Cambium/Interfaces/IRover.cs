using Cambium.Requests;
using Cambium.Responses;

namespace Cambium.Interfaces
{
	public interface IRover
	{
		RoverResponse GetRoverPosition(RoverRequest roverRequest);
	}
}
