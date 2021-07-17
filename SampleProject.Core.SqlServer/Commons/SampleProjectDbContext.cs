using Microsoft.EntityFrameworkCore;
using SampleProject.Core.Domain;
using SampleProject.Core.Domain.ArticelCategoryAggregate;
using SampleProject.Core.Domain.ArticleAggregate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SampleProject.Core.SqlServer.Commons
{
    public class SampleProjectDbContext : DbContext, ISampleProjectDbContext
    {
        public SampleProjectDbContext(DbContextOptions<SampleProjectDbContext> options) : base(options)
        {
        }
        public DbSet<Article> Articles { get; set; }
        public DbSet<ArticleCategory> ArticleCategories { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfigurationsFromAssembly(GetType().Assembly);
            base.OnModelCreating(builder);

        }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
        {
            return base.SaveChangesAsync(cancellationToken);
        }
    }
}
