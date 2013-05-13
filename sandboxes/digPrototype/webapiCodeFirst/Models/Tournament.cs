using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace webapiCodeFirst.Models
{
	public class Tournament
	{

			[ScaffoldColumn(false)]
			public int Id { get; set; }
			public int EventId { get; set; }
			public int RefCompositionId { get; set; }
			public int RefSportId { get; set; }
			public int RefSkillLevelId { get; set; }
			[Required]
			public string Name { get; set; }
			public string Description { get; set; }
			public DateTime DateStart { get; set; }
			public DateTime DateEnd { get; set; }
			public int Priority { get; set; }
			public bool CashPrize { get; set; }
			public bool OtherPrize { get; set; }
			public string PrizeDescription { get; set; }
			public Decimal EntranceFee { get; set; }
			public bool IsActive { get; set; }
	}
}