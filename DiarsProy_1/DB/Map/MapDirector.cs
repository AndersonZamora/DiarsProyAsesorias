using DiarsProy_1.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace DiarsProy_1.DB.Map
{
    public class MapDirector : EntityTypeConfiguration<Director>
    {
        public MapDirector()
        {
            ToTable("Director");
            HasKey(a => a.IdDirector);
        }
    }
}