using Project.ENTITES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.MAP.Options
{
    public class GameCategoryMap:BaseMap<GameCategory>
    {
        public GameCategoryMap()
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
