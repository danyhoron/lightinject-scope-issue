using class_lib.interfaces;

namespace class_lib.services
{
    public class Service01 : IService01
    {
        public string Echo(string value)
        {
            return $"Echoing: {value}";
        }

        public string GenerateValue()
        {
            return "value";
        }
    }
}