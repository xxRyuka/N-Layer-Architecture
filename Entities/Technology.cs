using Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Technology : BaseEntity<Guid>
	{

		// Base entity ile idsini(guid tipinden) ve olusturulma tarihlerini alir
		public string Name { get; set; }

		public string Language { get; set; } 
	}
}
