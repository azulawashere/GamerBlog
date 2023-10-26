using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITES.Models
{
    public class Game:BaseEntity
    {
        public string  Name { get; set; }
        public string Description { get; set; }

        //Relational Properties
        public virtual List<Category>Categories { get; set; }
        public virtual List<Comment> Comments { get; set; }
        public virtual Like like { get; set; }
        public virtual Disslike Disslike { get; set; }

    }
}
