using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Borbola_Anamaria_Lab11.Models;

namespace Borbola_Anamaria_Lab11.Data
{
    public class Borbola_Anamaria_Lab11Context : DbContext
    {
        public Borbola_Anamaria_Lab11Context (DbContextOptions<Borbola_Anamaria_Lab11Context> options)
            : base(options)
        {
        }

        public DbSet<Borbola_Anamaria_Lab11.Models.ShopList> ShopList { get; set; } = default!;
    }
}
