using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public interface IProgrammingLanguageService
    {
		void Add(ProgrammingLanguage programmingLanguage);
		void Update(ProgrammingLanguage programmingLanguage);
		ProgrammingLanguage GetById(int id);
		List<ProgrammingLanguage> GetAll();
		void Delete(int id);

	}
}
