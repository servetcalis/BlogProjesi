using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Abstract
{
    public class EntityBase : IEntityBase
    {
        public int Id { get; set; }

        public Status Status { get; set; } = Status.Active;
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public bool IsDeleted { get; set; }
        public DateTime? DeletedDate { get; set; }
    }
}
