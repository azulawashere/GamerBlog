﻿using Project.ENTITES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.MAP.Options
{
    public class DisslikeMap:BaseMap<Disslike>
    {
        public DisslikeMap()
        {
            Property(x=>x.Number).HasColumnName("Sayi");
        }
    }
}