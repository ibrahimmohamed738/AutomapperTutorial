using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AutomapperTutorial.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ContactController : ControllerBase
	{
		private List<Contact> contacts = new List<Contact> 
		{
			new Contact { 
				Id = 1,
				Name = "Ibrahim Mohamed",
				FirstName = "Ibrahim",
				LastName = "Mohamed",
				PlaceOfBirth = "Burco",
				DateAdded = new DateTime (2023,01,01),
				DateModified = null
			},

			new Contact {
				Id = 2,
				Name = "Ahmed Mohamed",
				FirstName = "Ahmed",
				LastName = "Mohamed",
				PlaceOfBirth = "Dubai",
				DateAdded = new DateTime (2023,01,04),
				DateModified = null
			}
		};

		[HttpGet]
		public ActionResult<List<Contact>> GetContacts()
		{
			return contacts;
		}
	}
}
