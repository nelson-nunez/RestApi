using GYF.Model;
using GYF.Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GYF.DataAccess.Repository
{
    public class AppUserRepository : GenericRepository<AppUser>
    {
        public AppUserRepository(DbModelContext context) : base(context)
        { }
    }
}
