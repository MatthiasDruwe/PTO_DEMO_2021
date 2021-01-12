using System;
using System.Collections.Generic;
using System.Text;

namespace AccessModifiers
{
    public class DemoOvererving: Demo
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
