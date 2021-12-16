using Core.DatabaseInfrastructure;
using Pomelo.EntityFrameworkCore.MySql.Infrastructure;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdvancedField.HashWeb.Data
{
    public class MiddlewareDBContext : DbContext
    {
        public MiddlewareDBContext(DbContextOptions<MiddlewareDBContext> options) : base(options) { 
        }
        public DbSet<FunTranslationResult> FunTranslationResult { get; set; }
    }
}
