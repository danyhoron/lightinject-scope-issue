using class_lib.interfaces;
using class_lib.services;
using LightInject;

namespace class_lib
{
    public class CompositionRoot : ICompositionRoot
    {
        public void Compose(IServiceRegistry serviceRegistry)
        {
            serviceRegistry
                .Register<IService01, Service01>(new PerScopeLifetime())
                .Register<IService02, Service02>(new PerScopeLifetime());
        }
    }
}