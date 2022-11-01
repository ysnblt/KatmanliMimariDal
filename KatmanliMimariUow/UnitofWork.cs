using KatmanliMimariDal;
using KatmanliMimariRep.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KatmanliMimariUow
{
    public class UnitofWork : IUnitofWork
    {
        MyContext _db;
        public IPersonelRep _personelRep { get; set; }



        public void Commit()
        {
            _db.SaveChanges();
        }

        public UnitofWork(MyContext db, IPersonelRep personelRep)
        {
            _db = db;
            _personelRep = personelRep;
        }
    }
}
