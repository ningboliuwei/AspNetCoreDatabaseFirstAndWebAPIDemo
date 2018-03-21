using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetCoreDatabseFirstAndWebAPIDemo.models;
using Microsoft.EntityFrameworkCore;

namespace AspNetCoreDatabaseFirstAndWebAPIDemo.Utilties
{
    public class MigrationHelper
    {
        public static void CheckMigrations(DbContext db)
        {
            //判断是否有待迁移
            if (db.Database.GetPendingMigrations().Any())
            {
                //执行迁移
                db.Database.Migrate();
            }
        }
    }
}
