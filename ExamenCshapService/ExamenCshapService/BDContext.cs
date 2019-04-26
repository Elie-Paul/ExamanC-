using ExamenCshapService.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenCshapService
{
    public class BDContext : DbContext
    {
        public DbSet<Indicateur> Indicateurs { get; set; }
        public DbSet<CritereEvaluation> Evaluations { get; set; }
        public BDContext() : base("name=examenContext")

        {
            Database.SetInitializer<BDContext>(new DropCreateDatabaseIfModelChanges<BDContext>());
        }
    }
}
