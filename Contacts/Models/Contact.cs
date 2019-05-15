using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Contacts.Models
{
	public class Contact
	{
		[Key]
		public int Id { get; set; }

		[Required]
		public String Name { get; set; }

		[Column(TypeName = "text")]
		public String Description { get; set; }

		public DateTimeOffset VisitDate { get; set; }

		[MaxLength(2)]
		public String Gender { get; set; }

		[MaxLength(50)]
		public String Source { get; set; }

		public bool AcceptedTerms { get; set; }
	}
}