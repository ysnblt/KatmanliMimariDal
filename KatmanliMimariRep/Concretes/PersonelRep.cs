using KatmanliMimariCore;
using KatmanliMimariDal;
using KatmanliMimariEntity;
using KatmanliMimariRep.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KatmanliMimariRep.Concretes
{
    public class PersonelRep<T> : BaseRepository<Personel>, IPersonelRep
    {
        public PersonelRep(MyContext db) : base(db)
        {
        }
    }
}
