using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Models;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    public class EmpContext : DbContext
    {
        public EmpContext(DbContextOptions options):base(options)
        {

        }
        public virtual DbSet<PersonalInfo> PersonalInfos{get;set;}
    }
}