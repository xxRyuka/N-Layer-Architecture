using Data_Access.Abstract;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access.Concrete
{
	public class TechnologyRepository : ITechnologyRepository
	{
		private readonly List<Technology> _technologies;

		public TechnologyRepository()
		{
			_technologies = new List<Technology> {
				new Technology { Id = Guid.NewGuid(), Name = "React", Language = "JavaScript" },
				new Technology { Id = Guid.NewGuid(), Name = "Angular", Language = "JavaScript" },
				new Technology { Id = Guid.NewGuid(), Name = "Vue", Language = "JavaScript" },
				new Technology { Id = Guid.NewGuid(), Name = "Asp.Net Core", Language = "C#" },
				new Technology { Id = Guid.NewGuid(), Name = "Entity Framework Core", Language = "C#" },
				new Technology { Id = Guid.NewGuid(), Name = "Windows Forms", Language = "C#" },
				new Technology { Id = Guid.NewGuid(), Name = "TensorFlow", Language = "Python" }
			};
		}

		public void Add(Technology technology)
		{
			Console.WriteLine(technology.Name + " Eklendi");
			_technologies.Add(technology);
		}

		public void Delete(Guid id)
		{
			var deleted = _technologies.FirstOrDefault(t => t.Id == id);
			if (deleted != null)
			{
				_technologies.Remove(deleted);
				Console.WriteLine($"{deleted.Name} silindi.");
			}
			else
			{
				Console.WriteLine($"{id}  teknoloji bulunamadı, silme işlemi başarısız.");
			}
		}

		public List<Technology> GetAll()
		{
			Console.WriteLine($"Tüm teknolojiler getirildi. Toplam: {_technologies.Count} adet");
			return _technologies;
		}

		public Technology GetById(Guid id)
		{
			Console.WriteLine($"{id}  teknoloji aranıyor.");
			var technology = _technologies.FirstOrDefault(t => t.Id == id);
			if (technology != null)
			{
				Console.WriteLine($"Teknoloji bulundu: {technology.Name} (ID: {technology.Id})");
			}
			else
			{
				Console.WriteLine($"{id}  teknoloji bulunamadı.");
			}
			return technology;
		}

		public void Update(Technology technology)
		{
			var technologyToUpdate = _technologies.FirstOrDefault(t => t.Id == technology.Id);
			if (technologyToUpdate != null)
			{
				technologyToUpdate.Name = technology.Name;
				technologyToUpdate.Language = technology.Language;
				Console.WriteLine($"Teknoloji güncellendi: {technologyToUpdate.Name}, Dil: {technologyToUpdate.Language}");
			}
			else
			{
				Console.WriteLine($"Güncelleme başarısız: {technology.Id}  teknoloji bulunamadı.");
			}
		}
	}
}