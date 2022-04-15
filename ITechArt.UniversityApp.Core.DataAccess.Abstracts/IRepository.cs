using System;
using System.Collections.Generic;
using System.Text;

namespace ITechArt.UniversityApp.Core.DataAccess
{
	public interface IRepository<T>
	{
		IEnumerable<T> GetAll();
		T Get(int id);
		void Create(T TObject);
		void Update(T TObject);
		void Delete(int id);
		void Save();

	}
}
