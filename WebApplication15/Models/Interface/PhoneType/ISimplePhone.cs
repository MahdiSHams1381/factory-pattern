using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp24.Model.Interface.PhoneType
{
    // interface to return simple phone
    internal interface ISimplePhone
    {
        public string GetName();
        public long GetBuildNumber();
        public long GetIMEINumber();
    }
}
