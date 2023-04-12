using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb1_Generics
{
    internal class LådaSameVol : EqualityComparer<Låda>
    {
        public override bool Equals(Låda L1, Låda L2)
        {
            decimal volym1 = L1.bredd * L1.längd * L1.höjd;
            decimal volym2 = L2.bredd * L2.längd * L2.höjd;

            if (volym1 == volym2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override int GetHashCode([DisallowNull] Låda obj)
        {
            throw new NotImplementedException();
        }
    }
}
