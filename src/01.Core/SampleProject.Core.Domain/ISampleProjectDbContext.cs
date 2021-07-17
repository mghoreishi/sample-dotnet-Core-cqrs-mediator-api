using Microsoft.EntityFrameworkCore;
using SampleProject.Core.Domain.ArticelCategoryAggregate;
using SampleProject.Core.Domain.ArticleAggregate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SampleProject.Core.Domain
{
    public interface ISampleProjectDbContext
    {
        public DbSet<Article> Articles { get; set; }
        public DbSet<ArticleCategory> ArticleCategories { get; set; }
        Task<int> SaveChangesAsync(CancellationToken cancellationToken);

    }
}
