using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Contacts.Repository
{
	using Contacts.Models;
	using Contacts.Infrastructure;

	public class ContactRepository
	{
		private Func<DbContext> _contextCreater;
		private IRepository<Contact> _entityRepository;

		protected IRepository<Contact> EntityRepository
		{
			get
			{
				if (_entityRepository == null)
				{
					_entityRepository = new EntityRepository<Contact>(_contextCreater());
				}
				return _entityRepository;
			}
		}
		/// <summary>
		/// Initializes a new instance of the UnitOfWork class.
		/// </summary>
		/// <param name="context">The object context</param>
		public ContactRepository(Func<DbContext> contextCreater)
		{
			_contextCreater = contextCreater;
		}

		public void AddContact(Contact contact)
		{
			EntityRepository.Insert(contact);
		}

		/// <summary>
		/// return amount of contacts
		/// </summary>
		/// <returns></returns>
		public int GetAmountOfContacts()
		{
			return EntityRepository.GetAll().Count();
		}

		public IQueryable<Contact> GetAllContacts()
		{
			return EntityRepository.GetAll();
		}

		public IQueryable<Contact> FindContacts(string search)
		{
			return EntityRepository.FindBy(c => c.Name.Contains(search) || c.Description.Contains(search) || c.Source.Contains(search));
		}
	}
}
