using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MixFlow.Core.Data.Models
{
	public record Album : IDataModel<Guid>
	{
		[Key]
		public Guid Id { get; init; }

		[Required]
		public string Name { get; set; }

		
		public Artist Artist { get; set; }

		public IList<Track> Tracks { get; set; }
	}
}
