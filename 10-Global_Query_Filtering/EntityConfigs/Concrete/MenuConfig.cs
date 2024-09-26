using _10_Global_Query_Filtering.Entites.Concrete;
using _10_Global_Query_Filtering.EntityConfigs.Abstract;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Global_Query_Filtering.EntityConfigs.Concrete
{
    public class MenuConfig:BaseConfig<Menu>
    {
        public override void Configure(EntityTypeBuilder<Menu> builder)
        {
            base.Configure(builder);
            builder.Property(p => p.MenuAdi).HasMaxLength(50);
            
        }
    }
}
