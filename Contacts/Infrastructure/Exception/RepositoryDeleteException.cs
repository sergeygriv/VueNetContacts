using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contacts.Infrastructure.Exception
{
	using System;

	/// <summary>
	/// Represents an error which occurs when deleting an entity in a repository.
	/// </summary>
	[Serializable]
	public class RepositoryDeleteException : Exception
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="RepositoryDeleteException"/> class.
		/// </summary>
		public RepositoryDeleteException()
		{
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="RepositoryDeleteException"/> class.
		/// </summary>
		/// <param name="message">Exception message.</param>
		public RepositoryDeleteException(string message)
			: base(message)
		{
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="RepositoryDeleteException"/> class.
		/// </summary>
		/// <param name="message">Exception message.</param>
		/// <param name="inner">Inner exception</param>
		public RepositoryDeleteException(string message, Exception inner)
			: base(message, inner)
		{
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="RepositoryDeleteException"/> class.
		/// </summary>
		/// <param name="info">Serialization info.</param>
		/// <param name="context">Streaming context.</param>
		protected RepositoryDeleteException(
		  System.Runtime.Serialization.SerializationInfo info,
		  System.Runtime.Serialization.StreamingContext context)
			: base(info, context)
		{
		}
	}
}
