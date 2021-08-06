using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MixFlow.Core.Data.Models
{
	public record Album
	{
		[Key]
		public Guid Id { get; init; }

		[Required]
		public string Name { get; set; }

		
		public virtual Artist Artist { get; set; }

		public virtual IList<Track> Tracks { get; set; }
	}
}
