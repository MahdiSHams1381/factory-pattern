using ConsoleApp24.Model.Interface.PhoneType;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp24.Model.PhoneModel
{
    internal class AshaPhone : ISimplePhone
    {
        public long GetBuildNumber()
        {
            return 654789;
        }

        public long GetIMEINumber()
        {
            return 654123;
        }

        public string GetName()
        {
            return " Asha Phone ";
        }

    }
}
