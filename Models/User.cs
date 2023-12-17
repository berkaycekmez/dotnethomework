using System.ComponentModel.DataAnnotations;

namespace dotnethomework.Models
{
	public class User
	{
		public int ID { get; set; }
		public string email { get; set; }
		public string name { get; set; }
		public string surname { get; set; }
		public string password { get; set; }


		public virtual List<Blog> blogs { get; set; }
	}
}
