using ConsoleApp24.Model.Factory.ModelPhoneFactory;
using ConsoleApp24.Model.Interface.PhoneModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp24.Model.Factory.PhoneFactory
{
    // the all type factory to creat the object (object of each type (model))
    internal class PhoneFactory
    {
        public AbstractPhoneModel GetSamsungPhone () { return new SamsungFactory() ; }
        public AbstractPhoneModel GetHTC() { return new HTCFactory(); }
        public AbstractPhoneModel GetNokia() { return new NokiaFactory(); }
    }
}
