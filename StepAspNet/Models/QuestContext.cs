using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace StepAspNet.Models
{
    public class QuestContext : DbContext
    {
        public DbSet<Quest> QuestList { get; set; }
    }
}

