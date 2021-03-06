﻿using CRMSporKulubu.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMSporKulubu.DAL.RepositoryAbstract
{
	interface IGelirGiderKategoriRepository : IBaseRepository<GelirGiderKategori>
	{
        ICollection<GelirGiderKategori> GelirKategorileriniGetir();
        ICollection<GelirGiderKategori> GiderKategorileriniGetir();
    }
}
