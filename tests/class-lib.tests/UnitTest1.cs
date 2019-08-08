using class_lib.interfaces;
using Xunit;

namespace class_lib.tests
{

    public class UnitTest1 : ContainerFixture
    {
        public IService01 svc01;

        public IService02 svc02;


        [Fact]
        public void Test1()
        {
            var value = svc01.GenerateValue();
            var echo = svc02.Echo02(value);
        }
    }
}
