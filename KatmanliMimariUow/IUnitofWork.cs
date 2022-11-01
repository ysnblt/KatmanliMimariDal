using KatmanliMimariRep.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KatmanliMimariUow
{
    public interface IUnitofWork
    {
        IPersonelRep _personelRep { get; }

        void Commit();
    }
}
