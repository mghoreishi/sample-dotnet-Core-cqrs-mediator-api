using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SampleProject.Core.Domain.ArticleAggregate;
using System;

namespace SampleProject.Core.SqlServer.Configuration
{
    public class ArticleConfig : IEntityTypeConfiguration<Article>
    {
        public void Configure(EntityTypeBuilder<Article> builder)
        {
            builder.ToTable("Articles");
            builder.HasKey(ci => ci.Id);

            builder.HasOne(x => x.ArticleCategory)
                    .WithMany(x => x.Articles)
                   .HasForeignKey(x => x.ArticleCategoryId);

            builder.HasData(new
            {
                Id = 1,
                ArticleCategoryId=1,
                ShortDescription= "Value Object in Domain Driven Design",
                Content= "Value Object in Domain Driven Design",
                Title = "Value Object",
                Created = DateTime.Now


            }, new
            {
                Id = 2,
                ArticleCategoryId = 1,
                ShortDescription = "Domian Event in Domain Driven Design",
                Content = "Domian Event in Domain Driven Design",
                Title = "Domian Event",
                Created = DateTime.Now

            });
        }
    }
}
