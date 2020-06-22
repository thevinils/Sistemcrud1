using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Sistemcrud1.Models
{
    public class Ctxt: DbContext 

    {
        public DbSet<Pessoa> Pessoas { get; set; }


    }
}