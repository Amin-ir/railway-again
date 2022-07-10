using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace railway.Data
{
    public class dbCntxt:DbContext
    {
        public dbCntxt(DbContextOptions<dbCntxt> options) : base(options)
        {

        }
    }
}
