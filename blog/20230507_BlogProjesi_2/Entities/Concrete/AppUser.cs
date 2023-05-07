using Entities.Abstract;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class AppUser : IdentityUser<int>
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public string About { get; set; }
        public string Picture { get; set; }

        public ICollection<Blog> Blogs { get; set; }


        public Status Status { get; set; } = Status.Active;
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public bool IsDeleted { get; set; }
        public DateTime? DeletedDate { get; set; }
    }
}
