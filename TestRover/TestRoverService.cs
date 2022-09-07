using Cambium.Requests;
using Cambium.Services;

namespace TestRover
{
	public class TestRoverService
	{
		private readonly RoverService _service;
		public TestRoverService()
		{
			_service = new RoverService();
		}

		[Theory]
		[InlineData(1,2,"N", "LMLMLMLMM", 1, 3, "N")]
		[InlineData(3, 3, "E", "MMRMMRMRRM", 5, 1, "E")]
		[InlineData(2, 2, "N", "MMRMMRMRRM", 4, 4, "N")]
		public void GetRoverPosition_Return_Correct_Location(int initialX, int initialY, string initialD, string input,int finalX, int finalY, string finalD)
		{
			// Arrange
			var inputMissingItem = new RoverRequest()
			{
				InitialD = initialD,
				InitialX = initialX,
				InitialY = initialY,
				Input = input
			};
			// Act
			var response = _service.GetRoverPosition(inputMissingItem);
			// Assert
			Assert.Equal(response.FinalX, finalX);
			Assert.Equal(response.FinalY, finalY);
			Assert.Equal(response.FinalD, finalD);
		}
	}
}
