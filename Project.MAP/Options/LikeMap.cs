﻿using Project.ENTITES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.MAP.Options
{
    public class LikeMap:BaseMap<Like>
    {
        public LikeMap()
        {
            Property(x => x.Number).HasColumnName("Sayi").IsRequired();
        }
    }
}
