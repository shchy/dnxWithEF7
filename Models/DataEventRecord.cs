using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Data.Entity;

namespace sqlite.Models
{
    public class DataEventRecord
    {
      public int Id { get; set; }
      public string Name { get; set; }
      public string Description { get; set; }
      public DateTime TimeStamp { get; set; }
    }


    public class DataEventRecordContext : DbContext
    {
      public DbSet<DataEventRecord> DataEventRecords { get; set; }
      protected override void OnModelCreating(ModelBuilder builder)
      {
        builder.Entity<DataEventRecord>().HasKey(m=>m.Id);
        base.OnModelCreating(builder);
      }
    }
}
