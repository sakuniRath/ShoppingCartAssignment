using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace ShoppingCartApp.DataAccessLayer.DataContext
{
    public class DatabaseContestFactory:IDesignTimeDbContextFactory<DatabaseContext>
    {
        public DatabaseContext CreateDbContext(string[] args) {
            return new DatabaseContext();
        }
    }
}
