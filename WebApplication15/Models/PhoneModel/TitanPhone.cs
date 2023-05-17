using ConsoleApp24.Model.Interface.PhoneType;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp24.Model.PhoneModel
{
    internal class TitanPhone : ISmartPhone
    {
        public long GetBuildNumber()
        {
            return 123456;
        }

        public long GetIMEINumber()
        {
            return 147852;
        }

        public string GetName()
        {
            return " Titan Phone ";
        }

        public int GetSmartLevel()
        {
            return 3;
        }
    }
}
