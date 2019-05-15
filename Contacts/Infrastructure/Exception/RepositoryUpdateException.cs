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
	public class RepositoryUpdateException : Exception
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="RepositoryUpdateException"/> class.
		/// </summary>
		public RepositoryUpdateException()
		{
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="RepositoryUpdateException"/> class.
		/// </summary>
		/// <param name="message">Exception message.</param>
		public RepositoryUpdateException(string message)
			: base(message)
		{
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="RepositoryUpdateException"/> class.
		/// </summary>
		/// <param name="message">Exception message.</param>
		/// <param name="inner">Inner exception</param>
		public RepositoryUpdateException(string message, Exception inner)
			: base(message, inner)
		{
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="RepositoryUpdateException"/> class.
		/// </summary>
		/// <param name="info">Serialization info.</param>
		/// <param name="context">Streaming context.</param>
		protected RepositoryUpdateException(
		  System.Runtime.Serialization.SerializationInfo info,
		  System.Runtime.Serialization.StreamingContext context)
			: base(info, context)
		{
		}
	}
}
