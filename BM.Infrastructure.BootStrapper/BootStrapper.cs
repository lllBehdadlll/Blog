﻿using BM.Application;
using BM.Application.Contracts.ArticleCategory;
using BM.Domain.ArticleCategoryAgg;
using BM.Infrastructure.EFCore;
using BM.Infrastructure.EFCore.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace BM.Infrastructure.Configuration
{
    public class BootStrapper
    {
        public static void Config(IServiceCollection service, string connectionString)
        {
            service.AddDbContext<BlogContext>(x => x.UseSqlServer(connectionString));
            service.AddTransient<IArticleCategoryRepository, ArticleCategoryRepository>();
            service.AddTransient<IArticleCategoryApplication, ArticleCategoryApplication>();
        }
    }
}