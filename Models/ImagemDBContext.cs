using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Photos.Models
{
    public class ImagemDBContext : DbContext
    {
        public ImagemDBContext(DbContextOptions<ImagemDBContext> options) : base(options)
        { }
        public DbSet<Imagem> Imagens { get; set; }
    }
}
