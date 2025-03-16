using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public interface ITechnologyService
    {
        void Add(Technology technology);
		void Update(Technology technology);
		Technology GetById(Guid id);
		List<Technology> GetAll();
		void Delete(Guid id);

	}
}
