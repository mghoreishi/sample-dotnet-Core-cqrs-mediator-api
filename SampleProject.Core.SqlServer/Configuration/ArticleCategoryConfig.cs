using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SampleProject.Core.Domain.ArticelCategoryAggregate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleProject.Core.SqlServer.Configuration
{
    public class ArticleCategoryConfig : IEntityTypeConfiguration<ArticleCategory>
    {
        public void Configure(EntityTypeBuilder<ArticleCategory> builder)
        {
            builder.ToTable("ArticleCategories");
            builder.HasKey(ci => ci.Id);

            builder.HasMany(o => o.Articles)
             .WithOne()
             .OnDelete(DeleteBehavior.Cascade);

            builder.HasData(new
            {
                Id = 1,
                Title = "Domain Driven Design",
                Created = DateTime.Now

            }, new
            {
                Id = 2,
                Title = "Asp Core",
                Created = DateTime.Now

            }); ;

        }
    }
}
