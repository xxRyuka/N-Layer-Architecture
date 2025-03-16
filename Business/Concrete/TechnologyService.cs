using Data_Access.Abstract;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
	public class TechnologyService : ITechnologyService
	{

		private readonly ITechnologyRepository _repository;

		public TechnologyService(ITechnologyRepository technologyRepository)
		{
			_repository = technologyRepository;
		}


		public void Add(Technology technology)
		{
			// aynı isimde teknoloji eklenemez
			if (_repository.GetAll().Exists(t => t.Name == technology.Name))
			{
				throw new Exception("Bu teknoloji zaten mevcut.");
			}

			_repository.Add(technology);
		}

		public List<Technology> GetAll()
		{
			return _repository.GetAll();
		}

		public Technology GetById(Guid id)
		{
			return _repository.GetById(id);
		}

		public void Delete(Guid id)
		{
			var technology = _repository.GetById(id);
			if (technology == null)
			{
				throw new Exception("Silinecek teknoloji bulunamadı.");
			}

			_repository.Delete(id);
		}

		public void Update(Technology technology)
		{
			var existingTechnology = _repository.GetById(technology.Id);
			if (existingTechnology == null)
			{
				throw new Exception("Güncellenecek teknoloji bulunamadı.");
			}

			existingTechnology.Name = technology.Name;
			existingTechnology.Language= technology.Language;
			_repository.Update(existingTechnology);
		}
	}
}
