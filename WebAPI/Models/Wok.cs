namespace WebAPI.Models
{
	/// <summary>
	/// Description and characteristics wok.
	/// </summary>
	internal class Wok : IFood
	{
		/// <summary>
		/// Spice or no wok.
		/// </summary>
		internal bool Spice { get; set; }

		/// <summary>
		/// Id number wok.
		/// </summary>
		public int Id { get; set; }

		/// <summary>
		/// Food wok.
		/// </summary>
		public string Name { get; set; }

		/// <summary>
		/// Wok price.
		/// </summary>
		public double Price { get; set; }
	}
}
