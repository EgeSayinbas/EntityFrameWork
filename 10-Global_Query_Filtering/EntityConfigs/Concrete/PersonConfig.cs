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
    public class PersonConfig : BaseConfig<Person>
    {
        public override void Configure(EntityTypeBuilder<Person> builder)
        {
            base.Configure(builder);
            builder.Property(p=>p.Name).HasMaxLength(50);
            builder.Property(p => p.SureName).HasMaxLength(50);
            builder.HasQueryFilter(p => p.IsDelete == false);

        }
    }
}
