using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MixFlow.Core.Data.Models
{
	public record Artist : IDataModel<Guid>
	{
		[Key]
		public Guid Id { get; init; }

		[Required]
		public string Name { get; set; }

		public IEnumerable<Album> Albums { get; set; }

		public IEnumerable<Track> Tracks { get; set; }
	}
}
