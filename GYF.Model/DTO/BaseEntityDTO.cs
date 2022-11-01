using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GYF.Model.DTO
{
    public abstract class BaseEntityDTO<Tid>
    {
        public virtual Tid Id { get; set; }

        public DateTime? Created { get; set; }
        public DateTime? Updated { get; set; }
        public DateTime? Deleted { get; set; }
        
    }
}
