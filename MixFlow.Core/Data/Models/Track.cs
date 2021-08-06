using System;
using System.ComponentModel.DataAnnotations;


namespace MixFlow.Core.Data.Models
{
	public record Track
	{
		[Key]
		public Guid Id { get; init; }

		[Required]
		public string Name { get; set; }

		[Required]
		public virtual Artist Artist { get; set; }

		public virtual Album Album { get; set; }
		
		public virtual Genre Genre { get; set; }
	}
}
