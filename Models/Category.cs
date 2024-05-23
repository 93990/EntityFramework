using System.ComponentModel.DataAnnotations;

namespace Sakshi_Web_APP.Models
{
	public class Categoryies
	{
		[Key]
		public int ID { get; set; }
		[Required]
		public string PropertyName { get; set; }

		public int DisplayOrder { get; set; }
	}
}
