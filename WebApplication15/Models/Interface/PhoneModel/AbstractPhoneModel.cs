using ConsoleApp24.Model.Interface.PhoneType;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp24.Model.Interface.PhoneModel
{
    // the abstract class to get the phone model in them and get the value of each phone 
    abstract class AbstractPhoneModel
    {
        public virtual ISmartPhone GetSmartPhone() { return null; }
        public virtual ISimplePhone GetSimplePhone() { return null; }
    }
}
