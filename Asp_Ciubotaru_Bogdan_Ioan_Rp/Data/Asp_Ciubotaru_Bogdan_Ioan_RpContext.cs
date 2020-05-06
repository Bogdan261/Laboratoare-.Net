using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Asp_Ciubotaru_Bogdan_Ioan_Rp.Models;

namespace Asp_Ciubotaru_Bogdan_Ioan_Rp.Data
{
    public class Asp_Ciubotaru_Bogdan_Ioan_RpContext : DbContext
    {
        public Asp_Ciubotaru_Bogdan_Ioan_RpContext (DbContextOptions<Asp_Ciubotaru_Bogdan_Ioan_RpContext> options)
            : base(options)
        {
        }

        public DbSet<Asp_Ciubotaru_Bogdan_Ioan_Rp.Models.Movie> Movie { get; set; }
    }
}
