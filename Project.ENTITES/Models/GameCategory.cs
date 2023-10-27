using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITES.Models
{
    public class GameCategory: BaseEntity
    {
        public Game GameID { get; set; }
        public Category CategoryID{ get; set; }

        //Relational Properties

        public virtual Game Game{ get; set; }
        public virtual Category Category  { get; set; }


    }

}
