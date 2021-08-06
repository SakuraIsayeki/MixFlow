using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MixFlow.Core.Data.Models
{
	public record Artist
	{
		[Key]
		public Guid Id { get; init; }

		[Required]
		public string Name { get; set; }

		public virtual IEnumerable<Album> Albums { get; set; }

		public virtual IEnumerable<Track> Tracks { get; set; }
	}
}
