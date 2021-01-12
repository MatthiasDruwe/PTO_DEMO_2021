using System;
using System.Collections.Generic;
using System.Text;

namespace AccessModifiers
{
    internal class Demo
    {
        public Demo()
        {
            IkBenEenPrivateMethode();
            IkBenEenPublicMethode();
            IkBenEenProtectedMethode();
            IkBenEenInternalMethode();
            IkBenEenPrivateProtectedMethode();
            IkBenEenProtectedInternalMethode();
        }

        private void IkBenEenPrivateMethode()
        {

        }

        public void IkBenEenPublicMethode()
        {

        }

        protected void IkBenEenProtectedMethode()
        {

        }

        internal void IkBenEenInternalMethode()
        {

        }

        private protected void IkBenEenPrivateProtectedMethode()
        {

        }

        protected internal void IkBenEenProtectedInternalMethode()
        {

        }
    }


}
