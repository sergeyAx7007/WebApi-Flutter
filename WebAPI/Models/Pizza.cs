namespace WebAPI.Models
{
	/// <summary>
	/// Description and characteristics pizza.
	/// </summary>
	internal class Pizza : IFood
	{
		/// <summary>
		/// Round of pizza.
		/// </summary>
		internal int Round { get; set; }

		/// <summary>
		/// Id number pizza.
		/// </summary>
		public int Id { get; set; }

		/// <summary>
		/// Pizza name.
		/// </summary>
		public string Name { get; set; }

		/// <summary>
		/// Without gluten.
		/// </summary>
		public double Price { get; set; }
	}
}
