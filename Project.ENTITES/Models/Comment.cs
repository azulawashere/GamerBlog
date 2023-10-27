using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITES.Models
{
    public class Comment:BaseEntity
    {
        public string UserName { get; set; }
        public int AppUserID { get; set; }
        
        //Relational Properties

        public virtual Game game { get; set; }
        public  virtual Like Like{ get; set; }
        public virtual Disslike Disslike { get; set; }

    }
}
