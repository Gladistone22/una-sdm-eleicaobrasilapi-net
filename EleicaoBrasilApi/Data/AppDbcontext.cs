using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EleicaoBrasilApi.Models;
using Microsoft.EntityFrameworkCore;

namespace EleicaoBrasilApi.Data
{
    public class AppDbcontext : DbContext

    {
        public AppDbcontext (DbContextOptions<AppDbcontext> options) : base(options)
        {
            
        }
        public DbSet<Candidato>candidatos {get; set;}
    }
}