using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contacts.Repository
{
	using Contacts.Models;

	public class ContactsContext : DbContext
	{
		public ContactsContext()
			: base("Contacts")
		{ }

		public DbSet<Contact> Contacts { get; set; }
	}
}
