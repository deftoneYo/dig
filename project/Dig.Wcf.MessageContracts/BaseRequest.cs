using System;
using System.Runtime.Serialization;

namespace Dig.Wcf.MessageContracts
{
	[DataContract]
	public class RequestBase
	{
		[DataMember]
		public Guid SessionId { get; set; }
	}
}
