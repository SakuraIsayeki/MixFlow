using System;
using System.ComponentModel.DataAnnotations;

namespace MixFlow.Core.Data.Models
{
	public record Genre
	{
		[Key]
		public Guid Id { get; init; }

		[Required]
		public string Name { get; set; }
	}
}
