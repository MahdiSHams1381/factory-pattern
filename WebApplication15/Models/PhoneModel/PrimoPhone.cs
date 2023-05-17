using ConsoleApp24.Model.Interface.PhoneType;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp24.Model.PhoneModel
{
    internal class PrimoPhone : ISimplePhone
    {
        public long GetBuildNumber()
        {
            return 1478963;
        }

        public long GetIMEINumber()
        {
            return 951236;
        }

        public string GetName()
        {
            return " Primo Phone ";
        }
    }
}
