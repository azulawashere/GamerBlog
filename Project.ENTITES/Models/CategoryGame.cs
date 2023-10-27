using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITES.Models
{
    public class CategoryGame: BaseEntity
    {
        public int  GameID { get; set; }
        public int CategoryID{ get; set; }

        //Relational Properties

        public virtual Game Game{ get; set; }
        public virtual Category Category  { get; set; }


    }

}
