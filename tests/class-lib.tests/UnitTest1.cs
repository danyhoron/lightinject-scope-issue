using System;
using class_lib.interfaces;
using class_lib.services;
using LightInject;
using LightInject.xUnit2;
using Xunit;

namespace class_lib.tests
{

    public class UnitTest1
    {

        public static void Configure(IServiceContainer container)
        {
            container.ScopeManagerProvider = new PerLogicalCallContextScopeManagerProvider();

            container.Register<IService01, Service01>(new PerScopeLifetime());
            container.Register<IService02, Service02>(new PerScopeLifetime());
        }

        [Theory, Scoped, InjectData]
        public void Test1(IService01 svc01, IService02 svc02)
        {
            var value = svc01.GenerateValue();
            var echo = svc02.Echo02(value);
        }
    }
}
