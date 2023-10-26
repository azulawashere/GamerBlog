using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITES.Models
{
    public class Like:BaseEntity    

    {

        public int Number { get; set; }
        public int AppUserID { get; set; }

        // rerwersd

        public virtual AppUser AppUser { get; set; }

    }
}
