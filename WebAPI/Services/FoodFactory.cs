using System.Collections.Generic;
using System.Linq;

namespace WebAPI.Services
{
	/// <summary>
	/// Class implementing the Simply Factory Pattern
	/// </summary>
	internal class FoodFactory : IFoodFactory
	{
		/// <summary>
		/// Dictionary contains pair name of food and class of food
		/// </summary>
		public readonly Dictionary<string, IFoodService> _servicesByType;

		/// <summary>
		/// Public constructor for create necessary class
		/// </summary>
		/// <param name="services">The object of the necessary type of food</param>
		public FoodFactory(IEnumerable<IFoodService> services)
		{
			_servicesByType = services.ToDictionary(e => e.Type.ToLowerInvariant(), e => e);
		}

		/// <summary>
		/// Method returning the appropriate type of service
		/// </summary>
		public IFoodService CreateFoodService(string foodName) => 
			_servicesByType.TryGetValue(foodName.ToLowerInvariant(), out var service) ? service : null;
	}
}
