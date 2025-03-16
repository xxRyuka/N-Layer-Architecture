using Business;
using Business.Concrete;
using Data_Access.Abstract;
using Data_Access.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;

IProgrammingLanguageRepository LanguageRepository = new ProgrammingLanguageRepository();
IProgrammingLanguageService LanguageManager= new ProgrammingLanguageService(LanguageRepository);

ITechnologyRepository TechnologyRepository = new TechnologyRepository();
ITechnologyService TechnologyService = new TechnologyService(TechnologyRepository);

TechnologyService.GetAll().ForEach(t => Console.WriteLine(t.Name));

LanguageManager.Add(new Entities.ProgrammingLanguage { Id = 5, Name = "C++" });
LanguageManager.GetAll().ForEach(l => Console.WriteLine(l.Name));

// Bir ui olusturulup işlemler yapılabilir fakat burda bırakacağım kodu 