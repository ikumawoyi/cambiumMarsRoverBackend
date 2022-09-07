using Cambium.Interfaces;
using Cambium.Requests;
using Cambium.Responses;

namespace Cambium.Services
{
	public class RoverService : IRover
	{

		public RoverResponse GetRoverPosition(RoverRequest roverRequest)
		{
			var roverProperty = new RoverRequest();
			roverProperty.InitialD = roverRequest.InitialD;
			roverProperty.InitialX = roverRequest.InitialX;
			roverProperty.InitialY = roverRequest.InitialY;
			roverProperty.Input = roverRequest.Input;
			var roverResponse = new RoverResponse();
			char letter;
			for (int i = 0; i < roverProperty.Input.Length; i++)
			{
				letter = roverProperty.Input[i];
				switch (letter)
				{
					case 'L':
						if (roverProperty.InitialD == "N")
						{
							roverProperty.InitialD = "W";
						}
						else if (roverProperty.InitialD == "W")
						{
							roverProperty.InitialD = "S";
						}
						else if (roverProperty.InitialD == "S")
						{
							roverProperty.InitialD = "E";
						}
						else
						{
							roverProperty.InitialD = "N";
						}
						break;
					case 'R':
						if (roverProperty.InitialD == "N")
						{
							roverProperty.InitialD = "E";
						}
						else if (roverProperty.InitialD == "E")
						{
							roverProperty.InitialD = "S";
						}
						else if (roverProperty.InitialD == "S")
						{
							roverProperty.InitialD = "W";
						}
						else
						{
							roverProperty.InitialD = "N";
						}
						break;
					case 'M':
						if (roverProperty.InitialD == "N")
						{
							roverProperty.InitialY = roverRequest.InitialY++;
						}
						else if (roverProperty.InitialD == "E")
						{
							roverProperty.InitialX++;
						}
						else if (roverProperty.InitialD == "S")
						{
							roverProperty.InitialY--;
						}
						else
						{
							roverProperty.InitialX--;
						}
						break;
				}
			}
			roverResponse.FinalD = roverProperty.InitialD;
			roverResponse.FinalX = roverProperty.InitialX;
			roverResponse.FinalY = roverProperty.InitialY;
			return roverResponse;
		}
	}
}
