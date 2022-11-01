using GYF.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GYF.DataAccess.Repository
{
    public class CustomerRepository : GenericRepository<Customer>
    {
        public CustomerRepository(DbModelContext context) : base(context)
        {

        }
    }
}