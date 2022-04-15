﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ITechArt.UniversityApp.Core.DataAccess
{
	public interface IRepository<T> where T : class
	{
		Task<IEnumerable<T>> GetAll();
		Task<T> Get(int id);
		Task Create(T TObject);
		Task Update(T TObject);
		Task Delete(int id);
		Task Save();

	}
}
