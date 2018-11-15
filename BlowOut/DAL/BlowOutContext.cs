using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using BlowOut.Models;

namespace BlowOut.DAL
{
    public class BlowOutContext : DbContext
    {
        public BlowOutContext() : base("BlowOutContext")
        {

        }

        public DbSet<Client> Clients { get; set; }
        public DbSet<Instrument> Instruments { get; set; }
    }
}