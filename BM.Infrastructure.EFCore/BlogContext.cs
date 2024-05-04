﻿using BM.Domain.ArticleCategoryAgg;
using BM.Infrastructure.EFCore.Mapping;
using Microsoft.EntityFrameworkCore;

namespace BM.Infrastructure.EFCore
{
    public class BlogContext : DbContext
    {
        public DbSet<ArticleCategory> articleCategories { get; set; }
        public BlogContext(DbContextOptions<BlogContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ArticleCategoryMapping());
            base.OnModelCreating(modelBuilder);
        }
    }
}