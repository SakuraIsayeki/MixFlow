using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MixFlow.Core.Data.Models
{
	public record Track : IDataModel<Guid>
	{
		[Key]
		public Guid Id { get; init; }

		[Required]
		public string Name { get; set; }

		[Required]
		public Artist Artist { get; set; }

		public Album Album { get; set; }
		
		public Genre Genre { get; set; }
	}
}
