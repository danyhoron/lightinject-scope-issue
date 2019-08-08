using System;
using class_lib.interfaces;

namespace class_lib.services
{
    public class Service02 : IService02
    {
        private readonly Lazy<IService01> _svc01;
        public Service02(Lazy<IService01> svc01)
        {
            _svc01 = svc01;
        }

        public string Echo02(string value)
        {
            return _svc01.Value.Echo(value);
        }
    }
}