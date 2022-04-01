using Admin.Models;
using Microsoft.EntityFrameworkCore;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repos
{
    public class UnitofWork<T> : IUnitofWork<T> where T : BaseClass
    {
        DbContext context;
        IModelRepo<T> Repo;

        public UnitofWork(DbContext _ContextFactory, IModelRepo<T> _Repo)
        {
            context = _ContextFactory;
            Repo = _Repo;
        }

        public IModelRepo<T> GetRepo()
        {
            return Repo;
        }
        public void Save()
        {
            context.SaveChanges();
        }
    }
}
