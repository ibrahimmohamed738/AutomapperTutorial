namespace AutomapperTutorial
{
	public class Contact
	{
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string FirstName { get; set; } = string.Empty;
		public string LastName { get; set; } = string.Empty;
		public string PlaceOfBirth { get; set; } = string.Empty;
		public DateTime DateAdded { get; set; }
        public DateTime? DateModified { get; set; }
    }
}
