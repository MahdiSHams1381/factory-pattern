using ConsoleApp24.Model.Interface.PhoneType;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp24.Model.PhoneModel
{
    internal class GeniePhone : ISimplePhone
    {
        public long GetBuildNumber()
        {
            return 963258;
        }

        public long GetIMEINumber()
        {
            return 15987;
        }

        public string GetName()
        {
            return " Genie Phone ";
        }

    }
}
