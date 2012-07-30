using System.Runtime.Serialization;

namespace Dig.Wcf.MessageContracts.Events
{
	[DataContract]
	public class GetEventsRequest : RequestBase
	{
		[DataMember]
		public string EventName { get; set; }
	}
}
