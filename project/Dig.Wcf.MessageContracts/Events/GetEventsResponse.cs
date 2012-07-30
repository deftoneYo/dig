using System;
using System.Runtime.Serialization;

namespace Dig.Wcf.MessageContracts.Events
{
	[DataContract]
	public class GetEventsResponse
	{
		[DataMember]
		public string EventName { get; set; }
	}
}
