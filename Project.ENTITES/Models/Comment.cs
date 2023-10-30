﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITES.Models
{
    public class Comment:BaseEntity
    {
        public Comment()
        {
            List<Comment> list = new List<Comment>();
        }
        public string Description { get; set; }
        public int AppUserID { get; set; }
        public string Title { get; set; }
        public List<Comment> Comments { get; set; }
        public int GameID { get; set; }
        //Relational Properties
        public virtual Game Game { get; set; }    
        public  virtual List<Like> Likes{ get; set; }
        public virtual List<Disslike> Disslikes { get; set; }
      

    }
}
