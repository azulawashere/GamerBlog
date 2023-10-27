using Project.ENTITES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.MAP.Options
{
    public class CategoryGameMap:BaseMap<CategoryGame>
    {
        public CategoryGameMap()
        {
           
            //İlişki Ayarlamaları
            Ignore(x => x.ID);
            HasKey(x => new
            {
                x.CategoryID,
                x.GameID
            });
        }
    }
}
