using System;
using System.Collections.Generic;
using System.Linq;
using YSKProje.ToDo.DataAccess.Concrete.EfCore.Contextintegrated;
using YSKProje.ToDo.DataAccess.Interfaces;
using YSKProje.ToDo.Entities.Concrete;

namespace YSKProje.ToDo.DataAccess.Concrete.EfCore.Repositories
{
    public class EfKullaniciRepository : EfGenericRepository<Kullanici>, IKullaniciDal
    {
        
    }
}
