using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITES.Models
{
    public class Like:BaseEntity    
    {
        public int AppUserID { get; set; }
        public int CommentID { get; set; }

        //Relational Properties

        public virtual AppUser AppUser { get; set; }
        public virtual Comment Comment { get; set; }


    }
}
