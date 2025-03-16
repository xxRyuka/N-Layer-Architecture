using Data_Access.Abstract;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access.Concrete
{
	public class ProgrammingLanguageRepository : IProgrammingLanguageRepository
	{

		private readonly List<ProgrammingLanguage> _programmingLanguages;

		public ProgrammingLanguageRepository()
		{
			_programmingLanguages = new List<ProgrammingLanguage> {

			   new ProgrammingLanguage { Id = 1, Name = "C#" },
				new ProgrammingLanguage { Id = 2, Name = "Java" },
				new ProgrammingLanguage { Id = 3, Name = "Python" },
				new ProgrammingLanguage { Id = 4, Name = "JavaScript" },
			};
		}


		public void Add(ProgrammingLanguage programmingLanguage)
		{
			Console.WriteLine(programmingLanguage.Name + " Eklendi");
			_programmingLanguages.Add(programmingLanguage);
		}

		public ProgrammingLanguage GetById(int id)
		{
			ProgrammingLanguage programmingLanguage = _programmingLanguages.FirstOrDefault(p => p.Id == id);
			return programmingLanguage;
		}

		public void Delete(int id)
		{
			ProgrammingLanguage DeletedLanguage = _programmingLanguages.FirstOrDefault(p => p.Id == id);
			_programmingLanguages.Remove(DeletedLanguage);
		}

		public List<ProgrammingLanguage> GetAll()
		{
			Console.WriteLine($"Tüm Programlama Dilleri getirildi. Toplam: {_programmingLanguages.Count} adet");
			return _programmingLanguages;	
		}


		public void Update(ProgrammingLanguage programmingLanguage)
		{
			ProgrammingLanguage languageToUpdate = _programmingLanguages.FirstOrDefault(p => p.Id == programmingLanguage.Id);
			if (languageToUpdate != null)
			{
				languageToUpdate.Name = programmingLanguage.Name;
			}
		}
	}
}
