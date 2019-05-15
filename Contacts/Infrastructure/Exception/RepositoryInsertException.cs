using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contacts.Infrastructure.Exception
{
	using System;

	/// <summary>
	/// Represents an error which occurs when a repository encounters an
	/// error when inserting an object.
	/// </summary>
	[Serializable]
	public class RepositoryInsertException : Exception
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="RepositoryInsertException"/> class.
		/// </summary>
		public RepositoryInsertException()
		{
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="RepositoryInsertException"/> class.
		/// </summary>
		/// <param name="message">Exception message.</param>
		public RepositoryInsertException(string message)
			: base(message)
		{
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="RepositoryInsertException"/> class.
		/// </summary>
		/// <param name="message">Exception message.</param>
		/// <param name="inner">Inner exception</param>
		public RepositoryInsertException(string message, Exception inner)
			: base(message, inner)
		{
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="RepositoryInsertException"/> class.
		/// </summary>
		/// <param name="info">Serialization info.</param>
		/// <param name="context">Streaming context.</param>
		protected RepositoryInsertException(
		  System.Runtime.Serialization.SerializationInfo info,
		  System.Runtime.Serialization.StreamingContext context)
			: base(info, context)
		{
		}
	}
}
