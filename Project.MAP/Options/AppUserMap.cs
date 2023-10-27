using Project.ENTITES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.MAP.Options
{
    public  class AppUserMap:BaseMap<AppUser>
    {
        public AppUserMap()
        {
            ToTable("Kullanicilar");
            Property(x => x.UserName).HasColumnName("Kullanici Ismi").IsRequired();
            Property(x => x.Password).HasColumnName("Sifre").IsRequired();

            //Relational Options
            HasOptional(x => x.Profile).WithRequired(x => x.AppUser); //one to one Relation
        }
    }
}
