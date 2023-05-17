using ConsoleApp24.Model.Interface.PhoneModel;
using ConsoleApp24.Model.Interface.PhoneType;
using ConsoleApp24.Model.PhoneModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp24.Model.Factory.ModelPhoneFactory
{
    //the type model factory to creat Samsung object 
    internal class SamsungFactory : AbstractPhoneModel
    {
        public override ISmartPhone GetSmartPhone() { return new GalexyPhone(); }
        public override ISimplePhone GetSimplePhone() { return new PrimoPhone(); }
    }
}
