namespace WebAPI.Models
{
	/// <summary>
	/// Description and characteristics pancake.
	/// </summary>
	internal class Pancake : IFood
	{
		/// <summary>
		/// Id number pancake.
		/// </summary>
		public int Id { get; set; }

		/// <summary>
		/// Pancake name.
		/// </summary>
		public string Name { get; set; }

		/// <summary>
		/// Pancake price.
		/// </summary>
		public double Price { get; set; }
	}
}
