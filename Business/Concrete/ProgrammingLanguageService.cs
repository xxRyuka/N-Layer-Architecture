using Data_Access.Abstract;
using Data_Access.Concrete;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
	public class ProgrammingLanguageService : IProgrammingLanguageService
	{

		private readonly IProgrammingLanguageRepository _repository;

		public ProgrammingLanguageService(IProgrammingLanguageRepository programmingLanguageRepository)
		{
			_repository = programmingLanguageRepository;
		}

		// Yeni bir programlama dili ekler
		public void Add(ProgrammingLanguage language)
		{
			// Aynı isimde programlama dili eklenemez
			if (_repository.GetAll().Exists(l => l.Name == language.Name))
			{
				throw new Exception("Bu programlama dili zaten mevcut.");
			}

			_repository.Add(language);
		}

		// Tüm programlama dillerini listeler
		public List<ProgrammingLanguage> GetAll()
		{
			return _repository.GetAll();
		}

		// Belirli bir ID'ye sahip programlama dilini getirir
		public ProgrammingLanguage GetById(int id)
		{
			return _repository.GetById(id);
		}

		// Belirli bir ID'ye sahip programlama dilini siler
		public void Delete(int id)
		{
			var language = _repository.GetById(id);
			if (language == null)
			{
				throw new Exception("Silinecek programlama dili bulunamadı.");
			}

			_repository.Delete(id);
		}

		// Mevcut bir programlama dilini günceller
		public void Update(ProgrammingLanguage language)
		{
			var existingLanguage = _repository.GetById(language.Id);
			if (existingLanguage == null)
			{
				throw new Exception("Güncellenecek programlama dili bulunamadı.");
			}

			// Güncelleme işlemleri
			existingLanguage.Name = language.Name;

			_repository.Update(existingLanguage);
		}
	}
}
