using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;

namespace Labb1_Generics
{
    internal class LådaSameDimensions : EqualityComparer<Låda>
    {
        public override bool Equals(Låda? L1, Låda? L2)
        {
            if (L1.bredd == L2.bredd && L1.längd == L2.längd && L1.höjd == L2.höjd)
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
