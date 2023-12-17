namespace dotnethomework.Models
{
	public class Blog
	{
		public int ID { get; set; }
		public string title { get; set; }
		public string content { get; set; }

		public int userID { get; set; }

		public virtual User user { get; set; }
	}
}
