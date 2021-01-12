using AccessModifiers;
using System;
using System.Collections.Generic;
using System.Text;

namespace AccessModifiers2
{
    class DemoOvererving : Demo
    {
        public DemoOvererving()
        {
            IkBenEenPrivateMethode();
            IkBenEenPublicMethode();
            IkBenEenProtectedMethode();
            IkBenEenInternalMethode();
            IkBenEenPrivateProtectedMethode();
            IkBenEenProtectedInternalMethode();
        }
    }
}
