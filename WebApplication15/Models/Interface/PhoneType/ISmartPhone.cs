using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp24.Model.Interface.PhoneType
{
    // the interface to return smartPhones
    internal interface ISmartPhone
    {
        public string GetName();
        public long GetBuildNumber();
        public long GetIMEINumber();
        public int GetSmartLevel();
    }
}
