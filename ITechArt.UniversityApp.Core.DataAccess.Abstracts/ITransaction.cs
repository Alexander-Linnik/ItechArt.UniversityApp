using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ITechArt.UniversityApp.Core.DataAccess
{
	internal interface ITransaction<T> where T : class
	{
		IRepository<T> Entities { get; }

		Task Save();
	}
}
