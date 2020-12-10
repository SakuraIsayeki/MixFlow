using System;
using System.Collections.Generic;
using System.Text;

namespace MixFlow.Core.Data.Models
{
	interface IDataModel<T> where T : struct
	{
		T Id { get; init; }
	}
}
