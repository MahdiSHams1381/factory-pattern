using ConsoleApp24.Model.Interface.PhoneType;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp24.Model.PhoneModel
{
    internal class LumiaPhone : ISmartPhone
    {
        public long GetBuildNumber()
        {
            return 985632;
        }

        public long GetIMEINumber()
        {
            return 852369;
        }

        public string GetName()
        {
            return " Lumia Phone ";
        }

        public int GetSmartLevel()
        {
            return 2;
        }
    }
}
