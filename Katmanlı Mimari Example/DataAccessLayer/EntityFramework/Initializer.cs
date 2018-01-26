using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class Initializer:CreateDatabaseIfNotExists<DatabaseContext>
    {
        //public override void InitializeDatabase(DatabaseContext context)
        //{
        //    base.InitializeDatabase(context);
        //}

        protected override void Seed(DatabaseContext context)
        {
            base.Seed(context);
        }
    }
}
