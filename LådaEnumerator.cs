using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb1_Generics
{
    internal class LådaEnumerator : IEnumerator<Låda>
    {
        private LådaCollection _låda;
        private int _currIndex;
        private Låda _currLåda;

        public LådaEnumerator(LådaCollection låda)
        {
            this._låda = låda;
            _currIndex = -1;
            _currLåda = default(Låda);
        }
        public Låda Current { get { return _currLåda; } }

        object IEnumerator.Current { get { return Current; } }

        public void Dispose()
        {

        }

        public bool MoveNext()
        {
            if (++_currIndex >= _låda.Count)
            {
                return false;
            }
            else
            {
                _currLåda = _låda[_currIndex];
            }
            return true;
        }

        public void Reset()
        {
            _currIndex = -1;
        }
    }
}
