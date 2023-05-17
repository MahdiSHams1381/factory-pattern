using ConsoleApp24.Model.Interface.PhoneType;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp24.Model.PhoneModel
{
    internal class GalexyPhone : ISmartPhone
    {
        public long GetBuildNumber()
        {
            return 7598423;
        }

        public long GetIMEINumber()
        {
            return 1458745;
        }

        public string GetName()
        {
            return " Galexy Phone ";
        }

        public int GetSmartLevel()
        {
            return 6;
        }
    }
}
