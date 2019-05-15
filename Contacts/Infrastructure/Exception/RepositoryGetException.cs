using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contacts.Infrastructure.Exception
{
	using System;

	/// <summary>
	/// Represents an error which occurs during a repository get action on a repository.
	/// </summary>
	[Serializable]
	public class RepositoryGetException : Exception
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="RepositoryGetException"/> class.
		/// </summary>
		public RepositoryGetException()
		{
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="RepositoryGetException"/> class.
		/// </summary>
		/// <param name="message">Exception message.</param>
		public RepositoryGetException(string message)
			: base(message)
		{
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="RepositoryGetException"/> class.
		/// </summary>
		/// <param name="message">Exception message.</param>
		/// <param name="inner">Inner exception</param>
		public RepositoryGetException(string message, Exception inner)
			: base(message, inner)
		{
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="RepositoryGetException"/> class.
		/// </summary>
		/// <param name="info">Serialization info.</param>
		/// <param name="context">Streaming context.</param>
		protected RepositoryGetException(
		  System.Runtime.Serialization.SerializationInfo info,
		  System.Runtime.Serialization.StreamingContext context)
			: base(info, context)
		{
		}
	}
}
