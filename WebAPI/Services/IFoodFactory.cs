namespace WebAPI.Services
{
	/// <summary>
	/// Interface implementing the Simply Factory Pattern
	/// </summary>
	internal interface IFoodFactory
	{
		/// <summary>
		/// Method returning the appropriate type of service
		/// </summary>
		public IFoodService CreateFoodService(string foodName);
	}
}
