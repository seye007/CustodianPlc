using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Custodian.Domain
{
	public class Event
	{
		public string CompanyName { get; set; }
		public string InvolvementDetails { get; set; }
		public string EventType { get; set; }
		public string EventHoldingType { get; set; }
		public string ExpectedGuests { get; set; }
		public decimal SumInsured { get; set; }
		public DateTime EventDate { get; set; }
		public int EventDuration { get; set; }
		public byte[] EventCovers { get; set; }
	}
}
