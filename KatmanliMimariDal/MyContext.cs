using KatmanliMimariEntity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KatmanliMimariDal
{
    public class MyContext:DbContext
    {
        public MyContext(DbContextOptions<MyContext> db): base(db)
        {

        }
        DbSet<Personel> Personel { get; set; }
    }
}
