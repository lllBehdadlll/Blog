﻿using BM.Domain.ArticleAgg;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BM.Infrastructure.EFCore.Mapping
{
    public class ArticleMapping : IEntityTypeConfiguration<Article>
    {
        public void Configure(EntityTypeBuilder<Article> builder)
        {
            builder.ToTable("Articles");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Title).HasMaxLength(150).IsRequired();
            builder.Property(x => x.ShortDescription).HasMaxLength(355).IsRequired();
            builder.Property(x =>x.Content).IsRequired();

            builder.HasOne(x => x.ArticleCategory).WithMany(x => x.Articles).HasForeignKey(x => x.ArticleCategoryId);
            builder.HasMany(x=>x.Comments).WithOne(x=>x.Article).HasForeignKey(x => x.ArticleId);
        }
    }
}
