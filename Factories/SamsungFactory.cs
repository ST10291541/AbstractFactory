

namespace AbstractFactory 
{
    public class SamsungFactoryFactory : IGadgetFactory 
    {
        public Smartwatch CreateSmartWatch()
        {
            return new Smartwatch("Samsung", "Galaxy Watch");
        }

        public VRHeadset CreateVRHeadset()
        {
            return new VRHeadset("Samsung", "Gear VR");
        }

        public WirelessEarbuds CreateWirelessEarbuds()
        {
            return new WirelessEarbuds("Samsung", "Galaxy Earbuds Pro");
        }
    }
}

