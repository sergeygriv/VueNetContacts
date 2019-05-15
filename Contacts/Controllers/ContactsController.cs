using Contacts.Models;
using Contacts.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Contacts.Controllers
{
	public class ContactsController : ApiController
	{
		// GET api/<controller>
		public IEnumerable<Contact> Get(string search)
		{
			var r = new ContactRepository(() => new ContactsContext());

			if (string.IsNullOrWhiteSpace(search))
				return r.GetAllContacts();
			else
				return r.FindContacts(search).ToList();
		}

		// GET api/<controller>/5
		public string Get(int id)
		{
			return "value";
		}

		/// <summary>
		/// Add contact to db
		/// </summary>
		/// <param name="value"></param>
		public void Post(Contact vm)
		{
			var r = new ContactRepository(() => new ContactsContext());
			r.AddContact(vm);

		}

		// PUT api/<controller>/5
		public void Put(int id, [FromBody]string value)
		{
		}

		// DELETE api/<controller>/5
		public void Delete(int id)
		{
		}
	}
}